﻿namespace SteamAutoMarket.CustomElements.Controls.Market
{
    using System.Drawing;
    using System.Windows.Forms;

    partial class MarketRelistControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AccountNameLable = new System.Windows.Forms.Label();
            this.AllSteamItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.AllSteamItemsGridView = new System.Windows.Forms.DataGridView();
            this.CancleSelectedButton = new System.Windows.Forms.Button();
            this.SplitterPanel = new System.Windows.Forms.Panel();
            this.CalcleAllButton = new System.Windows.Forms.Button();
            this.LoadListingButton = new System.Windows.Forms.Button();
            this.AddAllToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ItemDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemNameLable = new System.Windows.Forms.Label();
            this.ItemImageBox = new System.Windows.Forms.Panel();
            this.CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AveragePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HidenItemMarketHashName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.AveregeMinusPriceRadioButton = new System.Windows.Forms.RadioButton();
            this.CurrentMinusPriceRadioButton = new System.Windows.Forms.RadioButton();
            this.RecomendedPriceRadioButton = new System.Windows.Forms.RadioButton();
            this.CancleOverpricedButton = new System.Windows.Forms.Button();
            this.ItemDescriptionTextBox = new SteamAutoMarket.CustomElements.Elements.RichTextBoxWithNoPaint();
            this.AllSteamItemsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllSteamItemsGridView)).BeginInit();
            this.ItemDescriptionGroupBox.SuspendLayout();
            this.PriceSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountNameLable
            // 
            this.AccountNameLable.BackColor = System.Drawing.Color.Transparent;
            this.AccountNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountNameLable.Location = new System.Drawing.Point(688, 40);
            this.AccountNameLable.Name = "AccountNameLable";
            this.AccountNameLable.Size = new System.Drawing.Size(140, 18);
            this.AccountNameLable.TabIndex = 21;
            this.AccountNameLable.Text = "Not logged in";
            this.AccountNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllSteamItemsGroupBox
            // 
            this.AllSteamItemsGroupBox.Controls.Add(this.AllSteamItemsGridView);
            this.AllSteamItemsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(220)))));
            this.AllSteamItemsGroupBox.Location = new System.Drawing.Point(7, 3);
            this.AllSteamItemsGroupBox.Name = "AllSteamItemsGroupBox";
            this.AllSteamItemsGroupBox.Size = new System.Drawing.Size(618, 587);
            this.AllSteamItemsGroupBox.TabIndex = 24;
            this.AllSteamItemsGroupBox.TabStop = false;
            this.AllSteamItemsGroupBox.Text = "All items";
            // 
            // AllSteamItemsGridView
            // 
            this.AllSteamItemsGridView.AllowUserToAddRows = false;
            this.AllSteamItemsGridView.AllowUserToDeleteRows = false;
            this.AllSteamItemsGridView.AllowUserToResizeRows = false;
            this.AllSteamItemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllSteamItemsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.AllSteamItemsGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.AllSteamItemsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllSteamItemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AllSteamItemsGridView.ColumnHeadersHeight = 30;
            this.AllSteamItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AllSteamItemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn,
            this.NameColumn,
            this.Amount,
            this.TypeColumn,
            this.CurrentPriceColumn,
            this.ListedPrice,
            this.CurrentPrice,
            this.AveragePrice,
            this.AddButtonColumn,
            this.HidenItemMarketHashName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(218)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllSteamItemsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.AllSteamItemsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllSteamItemsGridView.EnableHeadersVisualStyles = false;
            this.AllSteamItemsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.AllSteamItemsGridView.Location = new System.Drawing.Point(3, 16);
            this.AllSteamItemsGridView.Name = "AllSteamItemsGridView";
            this.AllSteamItemsGridView.RowHeadersVisible = false;
            this.AllSteamItemsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AllSteamItemsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AllSteamItemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllSteamItemsGridView.Size = new System.Drawing.Size(612, 568);
            this.AllSteamItemsGridView.TabIndex = 7;
            this.AllSteamItemsGridView.SelectionChanged += new System.EventHandler(this.AllSteamItemsGridViewSelectionChanged);
            // 
            // CancleSelectedButton
            // 
            this.CancleSelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(218)))), ((int)(((byte)(106)))));
            this.CancleSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancleSelectedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancleSelectedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.CancleSelectedButton.Location = new System.Drawing.Point(660, 511);
            this.CancleSelectedButton.Name = "CancleSelectedButton";
            this.CancleSelectedButton.Size = new System.Drawing.Size(203, 35);
            this.CancleSelectedButton.TabIndex = 15;
            this.CancleSelectedButton.Text = "Cancle selected";
            this.CancleSelectedButton.UseVisualStyleBackColor = false;
            // 
            // SplitterPanel
            // 
            this.SplitterPanel.BackgroundImage = global::SteamAutoMarket.Properties.Resources.NotLogined;
            this.SplitterPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SplitterPanel.Location = new System.Drawing.Point(720, 3);
            this.SplitterPanel.Name = "SplitterPanel";
            this.SplitterPanel.Size = new System.Drawing.Size(77, 36);
            this.SplitterPanel.TabIndex = 22;
            // 
            // CalcleAllButton
            // 
            this.CalcleAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(218)))), ((int)(((byte)(106)))));
            this.CalcleAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalcleAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalcleAllButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.CalcleAllButton.Location = new System.Drawing.Point(660, 552);
            this.CalcleAllButton.Name = "CalcleAllButton";
            this.CalcleAllButton.Size = new System.Drawing.Size(203, 35);
            this.CalcleAllButton.TabIndex = 26;
            this.CalcleAllButton.Text = "Cancle all";
            this.CalcleAllButton.UseVisualStyleBackColor = false;
            // 
            // LoadListingButton
            // 
            this.LoadListingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadListingButton.FlatAppearance.BorderSize = 0;
            this.LoadListingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadListingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(220)))));
            this.LoadListingButton.Image = global::SteamAutoMarket.Properties.Resources.Download;
            this.LoadListingButton.Location = new System.Drawing.Point(172, 8);
            this.LoadListingButton.Name = "LoadListingButton";
            this.LoadListingButton.Size = new System.Drawing.Size(76, 84);
            this.LoadListingButton.TabIndex = 28;
            this.AddAllToolTip.SetToolTip(this.LoadListingButton, "Load market listings");
            this.LoadListingButton.UseVisualStyleBackColor = true;
            this.LoadListingButton.Click += new System.EventHandler(this.LoadListingButtonClick);
            // 
            // AddAllToolTip
            // 
            this.AddAllToolTip.AutomaticDelay = 100;
            this.AddAllToolTip.AutoPopDelay = 50000;
            this.AddAllToolTip.InitialDelay = 100;
            this.AddAllToolTip.IsBalloon = true;
            this.AddAllToolTip.ReshowDelay = 20;
            this.AddAllToolTip.UseAnimation = false;
            this.AddAllToolTip.UseFading = false;
            // 
            // ItemDescriptionGroupBox
            // 
            this.ItemDescriptionGroupBox.Controls.Add(this.ItemDescriptionTextBox);
            this.ItemDescriptionGroupBox.Controls.Add(this.ItemNameLable);
            this.ItemDescriptionGroupBox.Controls.Add(this.ItemImageBox);
            this.ItemDescriptionGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(220)))));
            this.ItemDescriptionGroupBox.Location = new System.Drawing.Point(631, 71);
            this.ItemDescriptionGroupBox.Name = "ItemDescriptionGroupBox";
            this.ItemDescriptionGroupBox.Size = new System.Drawing.Size(254, 243);
            this.ItemDescriptionGroupBox.TabIndex = 29;
            this.ItemDescriptionGroupBox.TabStop = false;
            this.ItemDescriptionGroupBox.Text = "Item description";
            // 
            // ItemNameLable
            // 
            this.ItemNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemNameLable.Location = new System.Drawing.Point(150, 15);
            this.ItemNameLable.Name = "ItemNameLable";
            this.ItemNameLable.Size = new System.Drawing.Size(98, 120);
            this.ItemNameLable.TabIndex = 10;
            // 
            // ItemImageBox
            // 
            this.ItemImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.ItemImageBox.BackgroundImage = global::SteamAutoMarket.Properties.Resources.DefaultItem;
            this.ItemImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ItemImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemImageBox.Location = new System.Drawing.Point(3, 15);
            this.ItemImageBox.Name = "ItemImageBox";
            this.ItemImageBox.Size = new System.Drawing.Size(139, 120);
            this.ItemImageBox.TabIndex = 8;
            // 
            // CheckBoxColumn
            // 
            this.CheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CheckBoxColumn.FillWeight = 30F;
            this.CheckBoxColumn.HeaderText = "";
            this.CheckBoxColumn.Name = "CheckBoxColumn";
            this.CheckBoxColumn.Width = 30;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameColumn.FillWeight = 160F;
            this.NameColumn.HeaderText = "Item name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 160;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Amount.FillWeight = 45F;
            this.Amount.HeaderText = "#";
            this.Amount.Name = "Amount";
            this.Amount.Width = 45;
            // 
            // TypeColumn
            // 
            this.TypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TypeColumn.FillWeight = 105F;
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.Width = 105;
            // 
            // CurrentPriceColumn
            // 
            this.CurrentPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CurrentPriceColumn.FillWeight = 55F;
            this.CurrentPriceColumn.HeaderText = "Listed on";
            this.CurrentPriceColumn.Name = "CurrentPriceColumn";
            this.CurrentPriceColumn.ReadOnly = true;
            this.CurrentPriceColumn.ToolTipText = "ListedOn";
            this.CurrentPriceColumn.Width = 55;
            // 
            // ListedPrice
            // 
            this.ListedPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ListedPrice.FillWeight = 55F;
            this.ListedPrice.HeaderText = "Listed price";
            this.ListedPrice.Name = "ListedPrice";
            this.ListedPrice.Width = 55;
            // 
            // CurrentPrice
            // 
            this.CurrentPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CurrentPrice.FillWeight = 55F;
            this.CurrentPrice.HeaderText = "Cur price";
            this.CurrentPrice.Name = "CurrentPrice";
            this.CurrentPrice.Width = 55;
            // 
            // AveragePrice
            // 
            this.AveragePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AveragePrice.FillWeight = 55F;
            this.AveragePrice.HeaderText = "Avr price";
            this.AveragePrice.Name = "AveragePrice";
            this.AveragePrice.Width = 55;
            // 
            // AddButtonColumn
            // 
            this.AddButtonColumn.FillWeight = 30F;
            this.AddButtonColumn.HeaderText = "Cancel";
            this.AddButtonColumn.Name = "AddButtonColumn";
            this.AddButtonColumn.Text = "❌";
            this.AddButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // HidenItemMarketHashName
            // 
            this.HidenItemMarketHashName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HidenItemMarketHashName.HeaderText = "HidenIdColumn";
            this.HidenItemMarketHashName.Name = "HidenItemMarketHashName";
            this.HidenItemMarketHashName.Visible = false;
            // 
            // PriceSettingsGroupBox
            // 
            this.PriceSettingsGroupBox.Controls.Add(this.CancleOverpricedButton);
            this.PriceSettingsGroupBox.Controls.Add(this.AveregeMinusPriceRadioButton);
            this.PriceSettingsGroupBox.Controls.Add(this.CurrentMinusPriceRadioButton);
            this.PriceSettingsGroupBox.Controls.Add(this.LoadListingButton);
            this.PriceSettingsGroupBox.Controls.Add(this.RecomendedPriceRadioButton);
            this.PriceSettingsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(220)))));
            this.PriceSettingsGroupBox.Location = new System.Drawing.Point(631, 329);
            this.PriceSettingsGroupBox.Name = "PriceSettingsGroupBox";
            this.PriceSettingsGroupBox.Size = new System.Drawing.Size(254, 150);
            this.PriceSettingsGroupBox.TabIndex = 30;
            this.PriceSettingsGroupBox.TabStop = false;
            this.PriceSettingsGroupBox.Text = "Relist price formation setting ";
            // 
            // AveregeMinusPriceRadioButton
            // 
            this.AveregeMinusPriceRadioButton.AutoSize = true;
            this.AveregeMinusPriceRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AveregeMinusPriceRadioButton.Location = new System.Drawing.Point(12, 45);
            this.AveregeMinusPriceRadioButton.Name = "AveregeMinusPriceRadioButton";
            this.AveregeMinusPriceRadioButton.Size = new System.Drawing.Size(111, 20);
            this.AveregeMinusPriceRadioButton.TabIndex = 5;
            this.AveregeMinusPriceRadioButton.Text = "Average price";
            this.AddAllToolTip.SetToolTip(this.AveregeMinusPriceRadioButton, "The value to add to the average calculated price (minimum and maximum are respect" +
        "ed)");
            this.AveregeMinusPriceRadioButton.UseVisualStyleBackColor = true;
            // 
            // CurrentMinusPriceRadioButton
            // 
            this.CurrentMinusPriceRadioButton.AutoSize = true;
            this.CurrentMinusPriceRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMinusPriceRadioButton.Location = new System.Drawing.Point(12, 71);
            this.CurrentMinusPriceRadioButton.Name = "CurrentMinusPriceRadioButton";
            this.CurrentMinusPriceRadioButton.Size = new System.Drawing.Size(101, 20);
            this.CurrentMinusPriceRadioButton.TabIndex = 1;
            this.CurrentMinusPriceRadioButton.Text = "Current price";
            this.AddAllToolTip.SetToolTip(this.CurrentMinusPriceRadioButton, "The value to add to the current calculated price (minimum and maximum are respect" +
        "ed)");
            this.CurrentMinusPriceRadioButton.UseVisualStyleBackColor = true;
            // 
            // RecomendedPriceRadioButton
            // 
            this.RecomendedPriceRadioButton.AutoSize = true;
            this.RecomendedPriceRadioButton.Checked = true;
            this.RecomendedPriceRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecomendedPriceRadioButton.Location = new System.Drawing.Point(12, 19);
            this.RecomendedPriceRadioButton.Name = "RecomendedPriceRadioButton";
            this.RecomendedPriceRadioButton.Size = new System.Drawing.Size(153, 20);
            this.RecomendedPriceRadioButton.TabIndex = 0;
            this.RecomendedPriceRadioButton.TabStop = true;
            this.RecomendedPriceRadioButton.Text = "Recommended price";
            this.AddAllToolTip.SetToolTip(this.RecomendedPriceRadioButton, "The largest of the maximum and current prices");
            this.RecomendedPriceRadioButton.UseVisualStyleBackColor = true;
            // 
            // CancleOverpricedButton
            // 
            this.CancleOverpricedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(218)))), ((int)(((byte)(106)))));
            this.CancleOverpricedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancleOverpricedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancleOverpricedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.CancleOverpricedButton.Location = new System.Drawing.Point(29, 102);
            this.CancleOverpricedButton.Name = "CancleOverpricedButton";
            this.CancleOverpricedButton.Size = new System.Drawing.Size(203, 35);
            this.CancleOverpricedButton.TabIndex = 31;
            this.CancleOverpricedButton.Text = "Cancle overpriced";
            this.CancleOverpricedButton.UseVisualStyleBackColor = false;
            // 
            // ItemDescriptionTextBox
            // 
            this.ItemDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.ItemDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemDescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(220)))));
            this.ItemDescriptionTextBox.Location = new System.Drawing.Point(3, 141);
            this.ItemDescriptionTextBox.Name = "ItemDescriptionTextBox";
            this.ItemDescriptionTextBox.ReadOnly = true;
            this.ItemDescriptionTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.ItemDescriptionTextBox.Size = new System.Drawing.Size(248, 99);
            this.ItemDescriptionTextBox.TabIndex = 11;
            this.ItemDescriptionTextBox.Text = "";
            // 
            // MarketRelistControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.PriceSettingsGroupBox);
            this.Controls.Add(this.ItemDescriptionGroupBox);
            this.Controls.Add(this.CalcleAllButton);
            this.Controls.Add(this.CancleSelectedButton);
            this.Controls.Add(this.AllSteamItemsGroupBox);
            this.Controls.Add(this.SplitterPanel);
            this.Controls.Add(this.AccountNameLable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(220)))));
            this.Name = "MarketRelistControl";
            this.Size = new System.Drawing.Size(885, 599);
            this.AllSteamItemsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllSteamItemsGridView)).EndInit();
            this.ItemDescriptionGroupBox.ResumeLayout(false);
            this.PriceSettingsGroupBox.ResumeLayout(false);
            this.PriceSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        public void AddHeaderCheckBox()
        {
            // Header checkbox
            this.HeaderCheckBox = new CheckBox
                                      {
                                          Size = new Size(15, 15),
                                          BackColor = Color.Transparent,
                                          Padding = new Padding(0),
                                          Margin = new Padding(0),
                                          Text = string.Empty
                                      };

            this.AllSteamItemsGridView.Controls.Add(this.HeaderCheckBox);
            DataGridViewHeaderCell header = this.AllSteamItemsGridView.Columns[0].HeaderCell;

            this.HeaderCheckBox.Location = new Point(
                (header.ContentBounds.Left +
                 (header.ContentBounds.Right - header.ContentBounds.Left + this.HeaderCheckBox.Size.Width)
                 / 2) + 3,
                (header.ContentBounds.Top +
                 (header.ContentBounds.Bottom - header.ContentBounds.Top + this.HeaderCheckBox.Size.Height)
                 / 2) + 3);

            this.HeaderCheckBox.CheckStateChanged += HeaderCheckBoxOnCheckStateChanged;
        }

        private System.Windows.Forms.Panel SplitterPanel;
        private System.Windows.Forms.Label AccountNameLable;
        private System.Windows.Forms.GroupBox AllSteamItemsGroupBox;
        private System.Windows.Forms.DataGridView AllSteamItemsGridView;
        private System.Windows.Forms.Button CancleSelectedButton;
        private System.Windows.Forms.Button CalcleAllButton;
        private System.Windows.Forms.Button LoadListingButton;
        private System.Windows.Forms.ToolTip AddAllToolTip;
        private CheckBox HeaderCheckBox;
        private GroupBox ItemDescriptionGroupBox;
        private Elements.RichTextBoxWithNoPaint ItemDescriptionTextBox;
        private Label ItemNameLable;
        private Panel ItemImageBox;
        private DataGridViewCheckBoxColumn CheckBoxColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn TypeColumn;
        private DataGridViewTextBoxColumn CurrentPriceColumn;
        private DataGridViewTextBoxColumn ListedPrice;
        private DataGridViewTextBoxColumn CurrentPrice;
        private DataGridViewTextBoxColumn AveragePrice;
        private DataGridViewButtonColumn AddButtonColumn;
        private DataGridViewTextBoxColumn HidenItemMarketHashName;
        private GroupBox PriceSettingsGroupBox;
        private RadioButton AveregeMinusPriceRadioButton;
        private RadioButton CurrentMinusPriceRadioButton;
        private RadioButton RecomendedPriceRadioButton;
        private Button CancleOverpricedButton;
    }
}
