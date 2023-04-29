namespace ApiSample
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.termekekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bvinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitePriceOverrideTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metaKeywordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metaDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metaTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxExemptDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.taxScheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageFileSmallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageFileSmallAlternateTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageFileMediumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageFileMediumAlternateTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateUtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftWrapAllowedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.giftWrapPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keywordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preContentColumnIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postContentColumnIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlSlugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailableForSaleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.featuredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allowReviewsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSearchableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.shippingChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Termékek lekérdezése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bvinDataGridViewTextBoxColumn,
            this.skuDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productTypeIdDataGridViewTextBoxColumn,
            this.listPriceDataGridViewTextBoxColumn,
            this.sitePriceDataGridViewTextBoxColumn,
            this.sitePriceOverrideTextDataGridViewTextBoxColumn,
            this.siteCostDataGridViewTextBoxColumn,
            this.metaKeywordsDataGridViewTextBoxColumn,
            this.metaDescriptionDataGridViewTextBoxColumn,
            this.metaTitleDataGridViewTextBoxColumn,
            this.taxExemptDataGridViewCheckBoxColumn,
            this.taxScheduleDataGridViewTextBoxColumn,
            this.shippingDetailsDataGridViewTextBoxColumn,
            this.shippingModeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.imageFileSmallDataGridViewTextBoxColumn,
            this.imageFileSmallAlternateTextDataGridViewTextBoxColumn,
            this.imageFileMediumDataGridViewTextBoxColumn,
            this.imageFileMediumAlternateTextDataGridViewTextBoxColumn,
            this.creationDateUtcDataGridViewTextBoxColumn,
            this.minimumQtyDataGridViewTextBoxColumn,
            this.shortDescriptionDataGridViewTextBoxColumn,
            this.longDescriptionDataGridViewTextBoxColumn,
            this.manufacturerIdDataGridViewTextBoxColumn,
            this.vendorIdDataGridViewTextBoxColumn,
            this.giftWrapAllowedDataGridViewCheckBoxColumn,
            this.giftWrapPriceDataGridViewTextBoxColumn,
            this.keywordsDataGridViewTextBoxColumn,
            this.preContentColumnIdDataGridViewTextBoxColumn,
            this.postContentColumnIdDataGridViewTextBoxColumn,
            this.urlSlugDataGridViewTextBoxColumn,
            this.inventoryModeDataGridViewTextBoxColumn,
            this.isAvailableForSaleDataGridViewCheckBoxColumn,
            this.featuredDataGridViewCheckBoxColumn,
            this.allowReviewsDataGridViewTextBoxColumn,
            this.storeIdDataGridViewTextBoxColumn,
            this.isSearchableDataGridViewCheckBoxColumn,
            this.shippingChargeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productDTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(85, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(978, 375);
            this.dataGridView1.TabIndex = 10;
            // 
            // productDTOBindingSource
            // 
            this.productDTOBindingSource.DataSource = typeof(Hotcakes.CommerceDTO.v1.Catalog.ProductDTO);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(933, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 58);
            this.button2.TabIndex = 11;
            this.button2.Text = "Mentés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(772, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 12;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // bvinDataGridViewTextBoxColumn
            // 
            this.bvinDataGridViewTextBoxColumn.DataPropertyName = "Bvin";
            this.bvinDataGridViewTextBoxColumn.HeaderText = "Bvin";
            this.bvinDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.bvinDataGridViewTextBoxColumn.Name = "bvinDataGridViewTextBoxColumn";
            this.bvinDataGridViewTextBoxColumn.Visible = false;
            this.bvinDataGridViewTextBoxColumn.Width = 200;
            // 
            // skuDataGridViewTextBoxColumn
            // 
            this.skuDataGridViewTextBoxColumn.DataPropertyName = "Sku";
            this.skuDataGridViewTextBoxColumn.HeaderText = "Sku";
            this.skuDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            this.skuDataGridViewTextBoxColumn.Visible = false;
            this.skuDataGridViewTextBoxColumn.Width = 200;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Termék neve";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // productTypeIdDataGridViewTextBoxColumn
            // 
            this.productTypeIdDataGridViewTextBoxColumn.DataPropertyName = "ProductTypeId";
            this.productTypeIdDataGridViewTextBoxColumn.HeaderText = "ProductTypeId";
            this.productTypeIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productTypeIdDataGridViewTextBoxColumn.Name = "productTypeIdDataGridViewTextBoxColumn";
            this.productTypeIdDataGridViewTextBoxColumn.Visible = false;
            this.productTypeIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // listPriceDataGridViewTextBoxColumn
            // 
            this.listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
            this.listPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice";
            this.listPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
            this.listPriceDataGridViewTextBoxColumn.Visible = false;
            this.listPriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // sitePriceDataGridViewTextBoxColumn
            // 
            this.sitePriceDataGridViewTextBoxColumn.DataPropertyName = "SitePrice";
            this.sitePriceDataGridViewTextBoxColumn.HeaderText = "Ár";
            this.sitePriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.sitePriceDataGridViewTextBoxColumn.Name = "sitePriceDataGridViewTextBoxColumn";
            this.sitePriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // sitePriceOverrideTextDataGridViewTextBoxColumn
            // 
            this.sitePriceOverrideTextDataGridViewTextBoxColumn.DataPropertyName = "SitePriceOverrideText";
            this.sitePriceOverrideTextDataGridViewTextBoxColumn.HeaderText = "SitePriceOverrideText";
            this.sitePriceOverrideTextDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.sitePriceOverrideTextDataGridViewTextBoxColumn.Name = "sitePriceOverrideTextDataGridViewTextBoxColumn";
            this.sitePriceOverrideTextDataGridViewTextBoxColumn.Visible = false;
            this.sitePriceOverrideTextDataGridViewTextBoxColumn.Width = 200;
            // 
            // siteCostDataGridViewTextBoxColumn
            // 
            this.siteCostDataGridViewTextBoxColumn.DataPropertyName = "SiteCost";
            this.siteCostDataGridViewTextBoxColumn.HeaderText = "SiteCost";
            this.siteCostDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.siteCostDataGridViewTextBoxColumn.Name = "siteCostDataGridViewTextBoxColumn";
            this.siteCostDataGridViewTextBoxColumn.Visible = false;
            this.siteCostDataGridViewTextBoxColumn.Width = 200;
            // 
            // metaKeywordsDataGridViewTextBoxColumn
            // 
            this.metaKeywordsDataGridViewTextBoxColumn.DataPropertyName = "MetaKeywords";
            this.metaKeywordsDataGridViewTextBoxColumn.HeaderText = "MetaKeywords";
            this.metaKeywordsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.metaKeywordsDataGridViewTextBoxColumn.Name = "metaKeywordsDataGridViewTextBoxColumn";
            this.metaKeywordsDataGridViewTextBoxColumn.Visible = false;
            this.metaKeywordsDataGridViewTextBoxColumn.Width = 200;
            // 
            // metaDescriptionDataGridViewTextBoxColumn
            // 
            this.metaDescriptionDataGridViewTextBoxColumn.DataPropertyName = "MetaDescription";
            this.metaDescriptionDataGridViewTextBoxColumn.HeaderText = "MetaDescription";
            this.metaDescriptionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.metaDescriptionDataGridViewTextBoxColumn.Name = "metaDescriptionDataGridViewTextBoxColumn";
            this.metaDescriptionDataGridViewTextBoxColumn.Visible = false;
            this.metaDescriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // metaTitleDataGridViewTextBoxColumn
            // 
            this.metaTitleDataGridViewTextBoxColumn.DataPropertyName = "MetaTitle";
            this.metaTitleDataGridViewTextBoxColumn.HeaderText = "MetaTitle";
            this.metaTitleDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.metaTitleDataGridViewTextBoxColumn.Name = "metaTitleDataGridViewTextBoxColumn";
            this.metaTitleDataGridViewTextBoxColumn.Visible = false;
            this.metaTitleDataGridViewTextBoxColumn.Width = 200;
            // 
            // taxExemptDataGridViewCheckBoxColumn
            // 
            this.taxExemptDataGridViewCheckBoxColumn.DataPropertyName = "TaxExempt";
            this.taxExemptDataGridViewCheckBoxColumn.HeaderText = "TaxExempt";
            this.taxExemptDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.taxExemptDataGridViewCheckBoxColumn.Name = "taxExemptDataGridViewCheckBoxColumn";
            this.taxExemptDataGridViewCheckBoxColumn.Visible = false;
            this.taxExemptDataGridViewCheckBoxColumn.Width = 200;
            // 
            // taxScheduleDataGridViewTextBoxColumn
            // 
            this.taxScheduleDataGridViewTextBoxColumn.DataPropertyName = "TaxSchedule";
            this.taxScheduleDataGridViewTextBoxColumn.HeaderText = "TaxSchedule";
            this.taxScheduleDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.taxScheduleDataGridViewTextBoxColumn.Name = "taxScheduleDataGridViewTextBoxColumn";
            this.taxScheduleDataGridViewTextBoxColumn.Visible = false;
            this.taxScheduleDataGridViewTextBoxColumn.Width = 200;
            // 
            // shippingDetailsDataGridViewTextBoxColumn
            // 
            this.shippingDetailsDataGridViewTextBoxColumn.DataPropertyName = "ShippingDetails";
            this.shippingDetailsDataGridViewTextBoxColumn.HeaderText = "ShippingDetails";
            this.shippingDetailsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.shippingDetailsDataGridViewTextBoxColumn.Name = "shippingDetailsDataGridViewTextBoxColumn";
            this.shippingDetailsDataGridViewTextBoxColumn.Visible = false;
            this.shippingDetailsDataGridViewTextBoxColumn.Width = 200;
            // 
            // shippingModeDataGridViewTextBoxColumn
            // 
            this.shippingModeDataGridViewTextBoxColumn.DataPropertyName = "ShippingMode";
            this.shippingModeDataGridViewTextBoxColumn.HeaderText = "ShippingMode";
            this.shippingModeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.shippingModeDataGridViewTextBoxColumn.Name = "shippingModeDataGridViewTextBoxColumn";
            this.shippingModeDataGridViewTextBoxColumn.Visible = false;
            this.shippingModeDataGridViewTextBoxColumn.Width = 200;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            this.statusDataGridViewTextBoxColumn.Width = 200;
            // 
            // imageFileSmallDataGridViewTextBoxColumn
            // 
            this.imageFileSmallDataGridViewTextBoxColumn.DataPropertyName = "ImageFileSmall";
            this.imageFileSmallDataGridViewTextBoxColumn.HeaderText = "ImageFileSmall";
            this.imageFileSmallDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.imageFileSmallDataGridViewTextBoxColumn.Name = "imageFileSmallDataGridViewTextBoxColumn";
            this.imageFileSmallDataGridViewTextBoxColumn.Visible = false;
            this.imageFileSmallDataGridViewTextBoxColumn.Width = 200;
            // 
            // imageFileSmallAlternateTextDataGridViewTextBoxColumn
            // 
            this.imageFileSmallAlternateTextDataGridViewTextBoxColumn.DataPropertyName = "ImageFileSmallAlternateText";
            this.imageFileSmallAlternateTextDataGridViewTextBoxColumn.HeaderText = "ImageFileSmallAlternateText";
            this.imageFileSmallAlternateTextDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.imageFileSmallAlternateTextDataGridViewTextBoxColumn.Name = "imageFileSmallAlternateTextDataGridViewTextBoxColumn";
            this.imageFileSmallAlternateTextDataGridViewTextBoxColumn.Visible = false;
            this.imageFileSmallAlternateTextDataGridViewTextBoxColumn.Width = 200;
            // 
            // imageFileMediumDataGridViewTextBoxColumn
            // 
            this.imageFileMediumDataGridViewTextBoxColumn.DataPropertyName = "ImageFileMedium";
            this.imageFileMediumDataGridViewTextBoxColumn.HeaderText = "ImageFileMedium";
            this.imageFileMediumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.imageFileMediumDataGridViewTextBoxColumn.Name = "imageFileMediumDataGridViewTextBoxColumn";
            this.imageFileMediumDataGridViewTextBoxColumn.Visible = false;
            this.imageFileMediumDataGridViewTextBoxColumn.Width = 200;
            // 
            // imageFileMediumAlternateTextDataGridViewTextBoxColumn
            // 
            this.imageFileMediumAlternateTextDataGridViewTextBoxColumn.DataPropertyName = "ImageFileMediumAlternateText";
            this.imageFileMediumAlternateTextDataGridViewTextBoxColumn.HeaderText = "ImageFileMediumAlternateText";
            this.imageFileMediumAlternateTextDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.imageFileMediumAlternateTextDataGridViewTextBoxColumn.Name = "imageFileMediumAlternateTextDataGridViewTextBoxColumn";
            this.imageFileMediumAlternateTextDataGridViewTextBoxColumn.Visible = false;
            this.imageFileMediumAlternateTextDataGridViewTextBoxColumn.Width = 200;
            // 
            // creationDateUtcDataGridViewTextBoxColumn
            // 
            this.creationDateUtcDataGridViewTextBoxColumn.DataPropertyName = "CreationDateUtc";
            this.creationDateUtcDataGridViewTextBoxColumn.HeaderText = "CreationDateUtc";
            this.creationDateUtcDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.creationDateUtcDataGridViewTextBoxColumn.Name = "creationDateUtcDataGridViewTextBoxColumn";
            this.creationDateUtcDataGridViewTextBoxColumn.Visible = false;
            this.creationDateUtcDataGridViewTextBoxColumn.Width = 200;
            // 
            // minimumQtyDataGridViewTextBoxColumn
            // 
            this.minimumQtyDataGridViewTextBoxColumn.DataPropertyName = "MinimumQty";
            this.minimumQtyDataGridViewTextBoxColumn.HeaderText = "MinimumQty";
            this.minimumQtyDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.minimumQtyDataGridViewTextBoxColumn.Name = "minimumQtyDataGridViewTextBoxColumn";
            this.minimumQtyDataGridViewTextBoxColumn.Visible = false;
            this.minimumQtyDataGridViewTextBoxColumn.Width = 200;
            // 
            // shortDescriptionDataGridViewTextBoxColumn
            // 
            this.shortDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ShortDescription";
            this.shortDescriptionDataGridViewTextBoxColumn.HeaderText = "ShortDescription";
            this.shortDescriptionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.shortDescriptionDataGridViewTextBoxColumn.Name = "shortDescriptionDataGridViewTextBoxColumn";
            this.shortDescriptionDataGridViewTextBoxColumn.Visible = false;
            this.shortDescriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // longDescriptionDataGridViewTextBoxColumn
            // 
            this.longDescriptionDataGridViewTextBoxColumn.DataPropertyName = "LongDescription";
            this.longDescriptionDataGridViewTextBoxColumn.HeaderText = "LongDescription";
            this.longDescriptionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.longDescriptionDataGridViewTextBoxColumn.Name = "longDescriptionDataGridViewTextBoxColumn";
            this.longDescriptionDataGridViewTextBoxColumn.Visible = false;
            this.longDescriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // manufacturerIdDataGridViewTextBoxColumn
            // 
            this.manufacturerIdDataGridViewTextBoxColumn.DataPropertyName = "ManufacturerId";
            this.manufacturerIdDataGridViewTextBoxColumn.HeaderText = "ManufacturerId";
            this.manufacturerIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.manufacturerIdDataGridViewTextBoxColumn.Name = "manufacturerIdDataGridViewTextBoxColumn";
            this.manufacturerIdDataGridViewTextBoxColumn.Visible = false;
            this.manufacturerIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // vendorIdDataGridViewTextBoxColumn
            // 
            this.vendorIdDataGridViewTextBoxColumn.DataPropertyName = "VendorId";
            this.vendorIdDataGridViewTextBoxColumn.HeaderText = "VendorId";
            this.vendorIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.vendorIdDataGridViewTextBoxColumn.Name = "vendorIdDataGridViewTextBoxColumn";
            this.vendorIdDataGridViewTextBoxColumn.Visible = false;
            this.vendorIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // giftWrapAllowedDataGridViewCheckBoxColumn
            // 
            this.giftWrapAllowedDataGridViewCheckBoxColumn.DataPropertyName = "GiftWrapAllowed";
            this.giftWrapAllowedDataGridViewCheckBoxColumn.HeaderText = "GiftWrapAllowed";
            this.giftWrapAllowedDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.giftWrapAllowedDataGridViewCheckBoxColumn.Name = "giftWrapAllowedDataGridViewCheckBoxColumn";
            this.giftWrapAllowedDataGridViewCheckBoxColumn.Visible = false;
            this.giftWrapAllowedDataGridViewCheckBoxColumn.Width = 200;
            // 
            // giftWrapPriceDataGridViewTextBoxColumn
            // 
            this.giftWrapPriceDataGridViewTextBoxColumn.DataPropertyName = "GiftWrapPrice";
            this.giftWrapPriceDataGridViewTextBoxColumn.HeaderText = "GiftWrapPrice";
            this.giftWrapPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.giftWrapPriceDataGridViewTextBoxColumn.Name = "giftWrapPriceDataGridViewTextBoxColumn";
            this.giftWrapPriceDataGridViewTextBoxColumn.Visible = false;
            this.giftWrapPriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // keywordsDataGridViewTextBoxColumn
            // 
            this.keywordsDataGridViewTextBoxColumn.DataPropertyName = "Keywords";
            this.keywordsDataGridViewTextBoxColumn.HeaderText = "Keywords";
            this.keywordsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.keywordsDataGridViewTextBoxColumn.Name = "keywordsDataGridViewTextBoxColumn";
            this.keywordsDataGridViewTextBoxColumn.Visible = false;
            this.keywordsDataGridViewTextBoxColumn.Width = 200;
            // 
            // preContentColumnIdDataGridViewTextBoxColumn
            // 
            this.preContentColumnIdDataGridViewTextBoxColumn.DataPropertyName = "PreContentColumnId";
            this.preContentColumnIdDataGridViewTextBoxColumn.HeaderText = "PreContentColumnId";
            this.preContentColumnIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.preContentColumnIdDataGridViewTextBoxColumn.Name = "preContentColumnIdDataGridViewTextBoxColumn";
            this.preContentColumnIdDataGridViewTextBoxColumn.Visible = false;
            this.preContentColumnIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // postContentColumnIdDataGridViewTextBoxColumn
            // 
            this.postContentColumnIdDataGridViewTextBoxColumn.DataPropertyName = "PostContentColumnId";
            this.postContentColumnIdDataGridViewTextBoxColumn.HeaderText = "PostContentColumnId";
            this.postContentColumnIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.postContentColumnIdDataGridViewTextBoxColumn.Name = "postContentColumnIdDataGridViewTextBoxColumn";
            this.postContentColumnIdDataGridViewTextBoxColumn.Visible = false;
            this.postContentColumnIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // urlSlugDataGridViewTextBoxColumn
            // 
            this.urlSlugDataGridViewTextBoxColumn.DataPropertyName = "UrlSlug";
            this.urlSlugDataGridViewTextBoxColumn.HeaderText = "UrlSlug";
            this.urlSlugDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.urlSlugDataGridViewTextBoxColumn.Name = "urlSlugDataGridViewTextBoxColumn";
            this.urlSlugDataGridViewTextBoxColumn.Visible = false;
            this.urlSlugDataGridViewTextBoxColumn.Width = 200;
            // 
            // inventoryModeDataGridViewTextBoxColumn
            // 
            this.inventoryModeDataGridViewTextBoxColumn.DataPropertyName = "InventoryMode";
            this.inventoryModeDataGridViewTextBoxColumn.HeaderText = "InventoryMode";
            this.inventoryModeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.inventoryModeDataGridViewTextBoxColumn.Name = "inventoryModeDataGridViewTextBoxColumn";
            this.inventoryModeDataGridViewTextBoxColumn.Visible = false;
            this.inventoryModeDataGridViewTextBoxColumn.Width = 200;
            // 
            // isAvailableForSaleDataGridViewCheckBoxColumn
            // 
            this.isAvailableForSaleDataGridViewCheckBoxColumn.DataPropertyName = "IsAvailableForSale";
            this.isAvailableForSaleDataGridViewCheckBoxColumn.HeaderText = "IsAvailableForSale";
            this.isAvailableForSaleDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.isAvailableForSaleDataGridViewCheckBoxColumn.Name = "isAvailableForSaleDataGridViewCheckBoxColumn";
            this.isAvailableForSaleDataGridViewCheckBoxColumn.Visible = false;
            this.isAvailableForSaleDataGridViewCheckBoxColumn.Width = 200;
            // 
            // featuredDataGridViewCheckBoxColumn
            // 
            this.featuredDataGridViewCheckBoxColumn.DataPropertyName = "Featured";
            this.featuredDataGridViewCheckBoxColumn.HeaderText = "Featured";
            this.featuredDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.featuredDataGridViewCheckBoxColumn.Name = "featuredDataGridViewCheckBoxColumn";
            this.featuredDataGridViewCheckBoxColumn.Visible = false;
            this.featuredDataGridViewCheckBoxColumn.Width = 200;
            // 
            // allowReviewsDataGridViewTextBoxColumn
            // 
            this.allowReviewsDataGridViewTextBoxColumn.DataPropertyName = "AllowReviews";
            this.allowReviewsDataGridViewTextBoxColumn.HeaderText = "AllowReviews";
            this.allowReviewsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.allowReviewsDataGridViewTextBoxColumn.Name = "allowReviewsDataGridViewTextBoxColumn";
            this.allowReviewsDataGridViewTextBoxColumn.Visible = false;
            this.allowReviewsDataGridViewTextBoxColumn.Width = 200;
            // 
            // storeIdDataGridViewTextBoxColumn
            // 
            this.storeIdDataGridViewTextBoxColumn.DataPropertyName = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.HeaderText = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.storeIdDataGridViewTextBoxColumn.Name = "storeIdDataGridViewTextBoxColumn";
            this.storeIdDataGridViewTextBoxColumn.Visible = false;
            this.storeIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // isSearchableDataGridViewCheckBoxColumn
            // 
            this.isSearchableDataGridViewCheckBoxColumn.DataPropertyName = "IsSearchable";
            this.isSearchableDataGridViewCheckBoxColumn.HeaderText = "IsSearchable";
            this.isSearchableDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.isSearchableDataGridViewCheckBoxColumn.Name = "isSearchableDataGridViewCheckBoxColumn";
            this.isSearchableDataGridViewCheckBoxColumn.Visible = false;
            this.isSearchableDataGridViewCheckBoxColumn.Width = 200;
            // 
            // shippingChargeDataGridViewTextBoxColumn
            // 
            this.shippingChargeDataGridViewTextBoxColumn.DataPropertyName = "ShippingCharge";
            this.shippingChargeDataGridViewTextBoxColumn.HeaderText = "ShippingCharge";
            this.shippingChargeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.shippingChargeDataGridViewTextBoxColumn.Name = "shippingChargeDataGridViewTextBoxColumn";
            this.shippingChargeDataGridViewTextBoxColumn.Visible = false;
            this.shippingChargeDataGridViewTextBoxColumn.Width = 200;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(670, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Új ár:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 645);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource termekekBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource productDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bvinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitePriceOverrideTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metaKeywordsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metaDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metaTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn taxExemptDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxScheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageFileSmallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageFileSmallAlternateTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageFileMediumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageFileMediumAlternateTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateUtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn giftWrapAllowedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftWrapPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keywordsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preContentColumnIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postContentColumnIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlSlugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAvailableForSaleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn featuredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allowReviewsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSearchableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
    }
}