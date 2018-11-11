﻿namespace SteamAutoMarket.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows;

    using Core;
    using Core.Waiter;

    using SteamAutoMarket.Models;
    using SteamAutoMarket.Models.Enums;
    using SteamAutoMarket.Properties;
    using SteamAutoMarket.Repository.Context;
    using SteamAutoMarket.Repository.Settings;
    using SteamAutoMarket.SteamIntegration;
    using SteamAutoMarket.Utils.Logger;

    /// <summary>
    /// Interaction logic for Account.xaml
    /// </summary>
    public partial class MarketSell : INotifyPropertyChanged
    {
        private readonly List<Task> priceLoadSubTasks = new List<Task>();

        private CancellationTokenSource cancellationTokenSource;

        private SteamAppId marketSellSelectedAppid = SettingsProvider.GetInstance().MarketSellSelectedAppid;

        private MarketSellModel marketSellSelectedItem;

        private Task priceLoadingTask;

        private MarketSellStrategy marketSellStrategy;

        public MarketSell()
        {
            this.InitializeComponent();
            this.DataContext = this;
            UiGlobalVariables.MarketSellPage = this;

            this.MarketSellSelectedAppid = this.AppIdList.FirstOrDefault(
                appid => appid?.Name == SettingsProvider.GetInstance().MarketSellSelectedAppid?.Name);
            this.marketSellStrategy = this.GetMarketSellStrategy();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public List<SteamAppId> AppIdList => SettingsProvider.GetInstance().AppIdList;

        public ObservableCollection<MarketSellModel> MarketSellItems { get; } =
            new ObservableCollection<MarketSellModel>();

        public string MarketSellNewAppid
        {
            set
            {
                if (string.IsNullOrEmpty(value) || !int.TryParse(value, out var longValue))
                {
                    return;
                }

                var steamAppId = this.AppIdList.FirstOrDefault(e => e.AppId == longValue);
                if (steamAppId == null)
                {
                    steamAppId = new SteamAppId(longValue);
                    this.AppIdList.Add(steamAppId);
                }

                this.MarketSellSelectedAppid = steamAppId;
            }
        }

        public SteamAppId MarketSellSelectedAppid
        {
            get => this.marketSellSelectedAppid;

            set
            {
                if (this.marketSellSelectedAppid == value) return;
                this.marketSellSelectedAppid = value;
                SettingsProvider.GetInstance().MarketSellSelectedAppid = value;
                this.OnPropertyChanged();
            }
        }

        public MarketSellModel MarketSellSelectedItem
        {
            get => this.marketSellSelectedItem;

            set
            {
                if (this.marketSellSelectedItem == value) return;
                this.marketSellSelectedItem = value;
                this.OnPropertyChanged();
            }
        }

        public MarketSellStrategy MarketSellStrategy
        {
            get => this.marketSellStrategy;
            set
            {
                if (this.marketSellStrategy != null && this.marketSellStrategy.Equals(value)) return;
                this.marketSellStrategy = value;
                this.ReformatAllSellPrices();
            }
        }

        [NotifyPropertyChangedInvocator]
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void LoadInventoryItems(object sender, RoutedEventArgs e)
        {
            if (UiGlobalVariables.SteamManager == null)
            {
                ErrorNotify.CriticalMessageBox("You should login first!");
                return;
            }

            if (int.TryParse(this.MarketContextIdTextBox.Text, out var contextId) == false)
            {
                ErrorNotify.CriticalMessageBox($"Incorrect context id provided - {contextId}");
                return;
            }

            var form = WorkingProcessForm.NewWorkingProcessWindow(
                $"{this.MarketSellSelectedAppid.Name} inventory loading");

            this.MarketSellItems.Clear();

            UiGlobalVariables.SteamManager.LoadItemsToSaleWorkingProcess(
                form,
                this.MarketSellSelectedAppid,
                contextId,
                this.MarketSellItems);
        }

        private void MarketSellMarkAllItemsClick(object sender, RoutedEventArgs e)
        {
            for (var i = 0; i < this.MarketSellItems.Count; i++)
            {
                this.MarketSellItems[i].MarketSellNumericUpDown.SetToMaximum();
            }
        }

        private void RefreshAllPricesPriceButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.priceLoadingTask?.IsCompleted == false)
            {
                this.StopPriceLoadingTasks();
            }

            this.cancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = this.cancellationTokenSource.Token;

            this.priceLoadingTask = Task.Run(
                () =>
                    {
                        try
                        {
                            Logger.Log.Debug("Starting market sell price loading task");

                            var items = this.MarketSellItems.ToList();
                            items.ForEach(
                                i =>
                                    {
                                        i.CurrentPrice = null;
                                        i.AveragePrice = null;
                                        i.SellPrice.Value = null;
                                    });

                            var averagePriceDays = SettingsProvider.GetInstance().AveragePriceDays;

                            var currentPriceCache = UiGlobalVariables.SteamManager.CurrentPriceCache;
                            var averagePriceCache = UiGlobalVariables.SteamManager.AveragePriceCache;

                            var priceLoadingSemaphore = new Semaphore(
                                SettingsProvider.GetInstance().PriceLoadingThreads,
                                SettingsProvider.GetInstance().PriceLoadingThreads);

                            foreach (var item in items)
                            {
                                priceLoadingSemaphore.WaitOne();
                                Logger.Log.Debug($"Processing price for {item.ItemName}");

                                var task = Task.Run(
                                    () =>
                                        {
                                            var price =
                                                currentPriceCache.Get(item.ItemModel.Description.MarketHashName)?.Price
                                                ?? UiGlobalVariables.SteamManager.GetCurrentPrice(
                                                    item.ItemModel.Asset.Appid,
                                                    item.ItemModel.Description.MarketHashName);

                                            Logger.Log.Debug($"Current price for {item.ItemName} is - {price}");
                                            item.CurrentPrice = price;
                                            item.ProcessSellPrice(this.MarketSellStrategy);
                                            priceLoadingSemaphore.Release();
                                        },
                                    cancellationToken);
                                this.priceLoadSubTasks.Add(task);

                                priceLoadingSemaphore.WaitOne();
                                task = Task.Run(
                                    () =>
                                        {
                                            var price =
                                                averagePriceCache.Get(item.ItemModel.Description.MarketHashName)?.Price
                                                ?? UiGlobalVariables.SteamManager.GetAveragePrice(
                                                    item.ItemModel.Asset.Appid,
                                                    item.ItemModel.Description.MarketHashName,
                                                    averagePriceDays);

                                            Logger.Log.Debug(
                                                $"Average price for {averagePriceDays} days for {item.ItemName} is - {price}");

                                            item.AveragePrice = price;
                                            item.ProcessSellPrice(this.MarketSellStrategy);
                                            priceLoadingSemaphore.Release();
                                        },
                                    cancellationToken);
                                this.priceLoadSubTasks.Add(task);

                                if (cancellationToken.IsCancellationRequested)
                                {
                                    Logger.Log.Debug(
                                        $"Waiting for {this.priceLoadSubTasks.Count(t => t.IsCompleted == false)} price loading threads to finish");
                                    new Waiter().Until(() => this.priceLoadSubTasks.All(t => t.IsCompleted));
                                    Logger.Log.Debug("Market sell price loading was force stopped");
                                    this.priceLoadSubTasks.Clear();
                                    break;
                                }
                            }

                            new Waiter().Until(() => this.priceLoadSubTasks.All(t => t.IsCompleted));
                            this.priceLoadSubTasks.Clear();
                            Logger.Log.Debug("Market sell price loading task is finished");
                        }
                        catch (Exception ex)
                        {
                            ErrorNotify.CriticalMessageBox("Error on items price update", ex);
                        }
                    },
                cancellationToken);
        }

        private void RefreshSinglePriceButton_OnClick(object sender, RoutedEventArgs e)
        {
            Task.Run(
                () =>
                    {
                        var item = this.MarketSellSelectedItem;
                        if (item == null) return;
                        try
                        {
                            item.CurrentPrice = null;
                            item.AveragePrice = null;
                            item.SellPrice.Value = null;

                            var averagePriceDays = SettingsProvider.GetInstance().AveragePriceDays;

                            var price = UiGlobalVariables.SteamManager.GetCurrentPrice(
                                item.ItemModel.Asset.Appid,
                                item.ItemModel.Description.MarketHashName);

                            Logger.Log.Debug($"Current price for {item.ItemName} is - {price}");

                            item.CurrentPrice = price;

                            price = UiGlobalVariables.SteamManager.GetAveragePrice(
                                item.ItemModel.Asset.Appid,
                                item.ItemModel.Description.MarketHashName,
                                averagePriceDays);

                            Logger.Log.Debug(
                                $"Average price for {averagePriceDays} days for {item.ItemName} is - {price}");

                            item.AveragePrice = price;

                            item.ProcessSellPrice(this.MarketSellStrategy);
                        }
                        catch (Exception ex)
                        {
                            ErrorNotify.CriticalMessageBox("Error on item price update", ex);
                        }
                    });
        }

        private void StartMarketSellButtonClick_OnClick(object sender, RoutedEventArgs e)
        {
            if (UiGlobalVariables.SteamManager == null)
            {
                ErrorNotify.CriticalMessageBox("You should login first!");
                return;
            }

            this.StopPriceLoadingTasks();

            var itemsToSell = this.MarketSellItems.ToList().Where(i => i.MarketSellNumericUpDown.AmountToSell > 0)
                .Select(i => new MarketSellProcessModel(i)).Where(i => i.Count > 0).ToList();
            if (itemsToSell.Sum(i => i.Count) == 0)
            {
                ErrorNotify.CriticalMessageBox("No items was marked to sell! Mark items before starting sell process");
                return;
            }

            var form = WorkingProcessForm.NewWorkingProcessWindow("Market sell");

            UiGlobalVariables.SteamManager.SellOnMarket(
                form,
                this.priceLoadSubTasks,
                itemsToSell,
                this.MarketSellStrategy);
        }

        private void StopPriceLoadingButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.priceLoadingTask?.IsCompleted == false)
            {
                Task.Run(() => this.StopPriceLoadingTasks());
            }
            else
            {
                Logger.Log.Debug("No active market sell price loading task found. Nothing to stop");
            }
        }

        private void StopPriceLoadingTasks()
        {
            if (this.cancellationTokenSource != null)
            {
                Logger.Log.Debug("Active market sell price loading task found. Trying to force stop it");
                this.cancellationTokenSource.Cancel();
                new Waiter().Until(() => this.priceLoadingTask?.IsCompleted == true);
            }
        }

        private MarketSellStrategy GetMarketSellStrategy()
        {
            var sellStrategy = new MarketSellStrategy();

            if (this.ManualPriceRb?.IsChecked != null && this.ManualPriceRb.IsChecked == true)
            {
                sellStrategy.SaleType = EMarketSaleType.Manual;
            }
            else if (this.RecommendedPriceRb?.IsChecked != null && this.RecommendedPriceRb.IsChecked == true)
            {
                sellStrategy.SaleType = EMarketSaleType.Recommended;
            }
            else if (this.CurrentPriceRb?.IsChecked != null && this.CurrentPriceRb.IsChecked == true)
            {
                sellStrategy.SaleType = EMarketSaleType.LowerThanCurrent;
                sellStrategy.ChangeValue = this.CurrentPriceNumericUpDown?.Value ?? 0;
            }
            else if (this.AveragePriceRb?.IsChecked != null && this.AveragePriceRb.IsChecked == true)
            {
                sellStrategy.SaleType = EMarketSaleType.LowerThanAverage;
                sellStrategy.ChangeValue = this.AveragePriceNumericUpDown?.Value ?? 0;
            }
            else
            {
                ErrorNotify.CriticalMessageBox(
                    "Incorrect market sell strategy. Please check price formation radio buttons state");
                return null;
            }

            return sellStrategy;
        }

        private void ReformatAllSellPrices()
        {
            var items = this.MarketSellItems.ToList();
            foreach (var item in items)
            {
                item.ProcessSellPrice(this.MarketSellStrategy);
            }
        }

        private void ReformatSellStrategyOnControlStateChanged(object sender, RoutedEventArgs e)
        {
            this.MarketSellStrategy = this.GetMarketSellStrategy();
        }
    }
}