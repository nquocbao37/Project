namespace Project
{
    partial class frmMain
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
            this.boxQuantityImport = new System.Windows.Forms.NumericUpDown();
            this.lblDateImport = new System.Windows.Forms.Label();
            this.dtpDateImport = new System.Windows.Forms.DateTimePicker();
            this.tabExport = new System.Windows.Forms.TabPage();
            this.tblStoreBuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new Project.DataBaseDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReceiptIDExport = new System.Windows.Forms.Label();
            this.cbbReceiptIDExport = new System.Windows.Forms.ComboBox();
            this.tblExportReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblQuit2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalExport = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPrintExport = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvExport = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtShopMethod = new System.Windows.Forms.ComboBox();
            this.txtDayOrder = new System.Windows.Forms.TextBox();
            this.txtPayMethodExport = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateExport = new System.Windows.Forms.DateTimePicker();
            this.lblDateExport = new System.Windows.Forms.Label();
            this.tabStatistic = new System.Windows.Forms.TabPage();
            this.Product = new System.Windows.Forms.GroupBox();
            this.dgvProductStatis = new System.Windows.Forms.DataGridView();
            this.lblQuit3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalPriceNumber = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblInOut = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ccbMonthStatis = new System.Windows.Forms.ComboBox();
            this.cbbYearStatis = new System.Windows.Forms.ComboBox();
            this.lblYearStatis = new System.Windows.Forms.Label();
            this.lblMonthStatis = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.boxNameImport = new System.Windows.Forms.GroupBox();
            this.txtEmployeeNameImport = new System.Windows.Forms.TextBox();
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtProductIDImport = new System.Windows.Forms.TextBox();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtQuantityWImport = new System.Windows.Forms.TextBox();
            this.txtPriceImport = new System.Windows.Forms.TextBox();
            this.btnClearImportList = new System.Windows.Forms.Button();
            this.lblEmployeeNameImport = new System.Windows.Forms.Label();
            this.lblProductIDImport = new System.Windows.Forms.Label();
            this.lblQuantityWareHouse = new System.Windows.Forms.Label();
            this.lblImportPrice = new System.Windows.Forms.Label();
            this.btnDeleteProductImport = new System.Windows.Forms.Button();
            this.btnAddProductmport = new System.Windows.Forms.Button();
            this.cbbImportName = new System.Windows.Forms.ComboBox();
            this.lblQuantityImport = new System.Windows.Forms.Label();
            this.lblNameImport = new System.Windows.Forms.Label();
            this.tabImport = new System.Windows.Forms.TabPage();
            this.btnSetImportReceiptID = new System.Windows.Forms.Button();
            this.lblQuit1 = new System.Windows.Forms.Label();
            this.boxDistributorIDImport = new System.Windows.Forms.ComboBox();
            this.tblDistributorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ccbEmployeeIDImport = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImportReceiptID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.clReceiptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxDistributorID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalImport = new System.Windows.Forms.TextBox();
            this.btnCreateImport = new System.Windows.Forms.Button();
            this.lblImportReceiptID = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tblExportReceiptTableAdapter = new Project.DataBaseDataSetTableAdapters.tblExportReceiptTableAdapter();
            this.tblStoreBuyTableAdapter = new Project.DataBaseDataSetTableAdapters.tblStoreBuyTableAdapter();
            this.tblEmployeeTableAdapter = new Project.DataBaseDataSetTableAdapters.tblEmployeeTableAdapter();
            this.tblDistributorTableAdapter = new Project.DataBaseDataSetTableAdapters.tblDistributorTableAdapter();
            this.tblProductTableAdapter = new Project.DataBaseDataSetTableAdapters.tblProductTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStoreExportID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.boxQuantityImport)).BeginInit();
            this.tabExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStoreBuyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExportReceiptBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabStatistic.SuspendLayout();
            this.Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductStatis)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.boxNameImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            this.tabImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDistributorBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxQuantityImport
            // 
            this.boxQuantityImport.Location = new System.Drawing.Point(93, 42);
            this.boxQuantityImport.Margin = new System.Windows.Forms.Padding(2);
            this.boxQuantityImport.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.boxQuantityImport.Name = "boxQuantityImport";
            this.boxQuantityImport.Size = new System.Drawing.Size(237, 22);
            this.boxQuantityImport.TabIndex = 6;
            // 
            // lblDateImport
            // 
            this.lblDateImport.AutoSize = true;
            this.lblDateImport.Location = new System.Drawing.Point(8, 12);
            this.lblDateImport.Name = "lblDateImport";
            this.lblDateImport.Size = new System.Drawing.Size(32, 15);
            this.lblDateImport.TabIndex = 2;
            this.lblDateImport.Text = "Date";
            // 
            // dtpDateImport
            // 
            this.dtpDateImport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateImport.Location = new System.Drawing.Point(46, 5);
            this.dtpDateImport.Name = "dtpDateImport";
            this.dtpDateImport.Size = new System.Drawing.Size(200, 22);
            this.dtpDateImport.TabIndex = 1;
            // 
            // tabExport
            // 
            this.tabExport.Controls.Add(this.lblReceiptIDExport);
            this.tabExport.Controls.Add(this.cbbReceiptIDExport);
            this.tabExport.Controls.Add(this.lblQuit2);
            this.tabExport.Controls.Add(this.panel2);
            this.tabExport.Controls.Add(this.groupBox3);
            this.tabExport.Controls.Add(this.groupBox2);
            this.tabExport.Controls.Add(this.dtpDateExport);
            this.tabExport.Controls.Add(this.lblDateExport);
            this.tabExport.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabExport.Location = new System.Drawing.Point(4, 28);
            this.tabExport.Name = "tabExport";
            this.tabExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabExport.Size = new System.Drawing.Size(991, 503);
            this.tabExport.TabIndex = 1;
            this.tabExport.Text = "Export";
            this.tabExport.UseVisualStyleBackColor = true;
            // 
            // tblStoreBuyBindingSource
            // 
            this.tblStoreBuyBindingSource.DataMember = "tblStoreBuy";
            this.tblStoreBuyBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Store Order ID";
            // 
            // lblReceiptIDExport
            // 
            this.lblReceiptIDExport.AutoSize = true;
            this.lblReceiptIDExport.Location = new System.Drawing.Point(373, 11);
            this.lblReceiptIDExport.Name = "lblReceiptIDExport";
            this.lblReceiptIDExport.Size = new System.Drawing.Size(96, 15);
            this.lblReceiptIDExport.TabIndex = 15;
            this.lblReceiptIDExport.Text = "Order Receipt ID";
            // 
            // cbbReceiptIDExport
            // 
            this.cbbReceiptIDExport.DataSource = this.tblExportReceiptBindingSource;
            this.cbbReceiptIDExport.DisplayMember = "ExportReceiptID";
            this.cbbReceiptIDExport.FormattingEnabled = true;
            this.cbbReceiptIDExport.Location = new System.Drawing.Point(480, 6);
            this.cbbReceiptIDExport.Name = "cbbReceiptIDExport";
            this.cbbReceiptIDExport.Size = new System.Drawing.Size(203, 23);
            this.cbbReceiptIDExport.TabIndex = 2;
            this.cbbReceiptIDExport.ValueMember = "ExportReceiptID";
            this.cbbReceiptIDExport.SelectedValueChanged += new System.EventHandler(this.cbbReceiptIDExport_SelectedValueChanged);
            // 
            // tblExportReceiptBindingSource
            // 
            this.tblExportReceiptBindingSource.DataMember = "tblExportReceipt";
            this.tblExportReceiptBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // lblQuit2
            // 
            this.lblQuit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuit2.AutoSize = true;
            this.lblQuit2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuit2.ForeColor = System.Drawing.Color.Red;
            this.lblQuit2.Location = new System.Drawing.Point(953, 11);
            this.lblQuit2.Name = "lblQuit2";
            this.lblQuit2.Size = new System.Drawing.Size(30, 15);
            this.lblQuit2.TabIndex = 13;
            this.lblQuit2.Text = "Quit";
            this.lblQuit2.Click += new System.EventHandler(this.lblQuit2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.txtTotalExport);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.btnPrintExport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 53);
            this.panel2.TabIndex = 10;
            // 
            // txtTotalExport
            // 
            this.txtTotalExport.Location = new System.Drawing.Point(772, 15);
            this.txtTotalExport.Name = "txtTotalExport";
            this.txtTotalExport.Size = new System.Drawing.Size(162, 22);
            this.txtTotalExport.TabIndex = 13;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(732, 19);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 15);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total";
            // 
            // btnPrintExport
            // 
            this.btnPrintExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintExport.Location = new System.Drawing.Point(8, 15);
            this.btnPrintExport.Name = "btnPrintExport";
            this.btnPrintExport.Size = new System.Drawing.Size(75, 23);
            this.btnPrintExport.TabIndex = 11;
            this.btnPrintExport.Text = "Print";
            this.btnPrintExport.UseVisualStyleBackColor = true;
            this.btnPrintExport.Click += new System.EventHandler(this.btnPrintExport_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvExport);
            this.groupBox3.Location = new System.Drawing.Point(3, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(988, 297);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product list";
            // 
            // dgvExport
            // 
            this.dgvExport.AllowUserToAddRows = false;
            this.dgvExport.AllowUserToDeleteRows = false;
            this.dgvExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExport.Location = new System.Drawing.Point(3, 18);
            this.dgvExport.Name = "dgvExport";
            this.dgvExport.ReadOnly = true;
            this.dgvExport.Size = new System.Drawing.Size(982, 276);
            this.dgvExport.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtShopMethod);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtStoreExportID);
            this.groupBox2.Controls.Add(this.txtDayOrder);
            this.groupBox2.Controls.Add(this.txtPayMethodExport);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(0, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(991, 120);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order information";
            // 
            // txtShopMethod
            // 
            this.txtShopMethod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblExportReceiptBindingSource, "DeliveryStatus", true));
            this.txtShopMethod.DisplayMember = "DeliveryStatus";
            this.txtShopMethod.FormattingEnabled = true;
            this.txtShopMethod.Location = new System.Drawing.Point(114, 82);
            this.txtShopMethod.Name = "txtShopMethod";
            this.txtShopMethod.Size = new System.Drawing.Size(203, 23);
            this.txtShopMethod.TabIndex = 8;
            this.txtShopMethod.ValueMember = "DeliveryStatus";
            // 
            // txtDayOrder
            // 
            this.txtDayOrder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblExportReceiptBindingSource, "Date", true));
            this.txtDayOrder.Location = new System.Drawing.Point(115, 11);
            this.txtDayOrder.Name = "txtDayOrder";
            this.txtDayOrder.Size = new System.Drawing.Size(202, 22);
            this.txtDayOrder.TabIndex = 6;
            // 
            // txtPayMethodExport
            // 
            this.txtPayMethodExport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblExportReceiptBindingSource, "PayMethod", true));
            this.txtPayMethodExport.Location = new System.Drawing.Point(114, 48);
            this.txtPayMethodExport.Name = "txtPayMethodExport";
            this.txtPayMethodExport.Size = new System.Drawing.Size(203, 22);
            this.txtPayMethodExport.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Payment method";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Order day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Shipment status";
            // 
            // dtpDateExport
            // 
            this.dtpDateExport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateExport.Location = new System.Drawing.Point(84, 9);
            this.dtpDateExport.Name = "dtpDateExport";
            this.dtpDateExport.Size = new System.Drawing.Size(162, 22);
            this.dtpDateExport.TabIndex = 1;
            // 
            // lblDateExport
            // 
            this.lblDateExport.AutoSize = true;
            this.lblDateExport.Location = new System.Drawing.Point(8, 12);
            this.lblDateExport.Name = "lblDateExport";
            this.lblDateExport.Size = new System.Drawing.Size(32, 15);
            this.lblDateExport.TabIndex = 0;
            this.lblDateExport.Text = "Date";
            // 
            // tabStatistic
            // 
            this.tabStatistic.Controls.Add(this.Product);
            this.tabStatistic.Controls.Add(this.lblQuit3);
            this.tabStatistic.Controls.Add(this.panel3);
            this.tabStatistic.Controls.Add(this.lblInOut);
            this.tabStatistic.Controls.Add(this.comboBox1);
            this.tabStatistic.Controls.Add(this.ccbMonthStatis);
            this.tabStatistic.Controls.Add(this.cbbYearStatis);
            this.tabStatistic.Controls.Add(this.lblYearStatis);
            this.tabStatistic.Controls.Add(this.lblMonthStatis);
            this.tabStatistic.Controls.Add(this.groupBox6);
            this.tabStatistic.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStatistic.Location = new System.Drawing.Point(4, 28);
            this.tabStatistic.Name = "tabStatistic";
            this.tabStatistic.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistic.Size = new System.Drawing.Size(991, 503);
            this.tabStatistic.TabIndex = 2;
            this.tabStatistic.Text = "Statistic";
            this.tabStatistic.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            this.Product.Controls.Add(this.dgvProductStatis);
            this.Product.Location = new System.Drawing.Point(0, 42);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(991, 173);
            this.Product.TabIndex = 16;
            this.Product.TabStop = false;
            this.Product.Text = "Product list";
            // 
            // dgvProductStatis
            // 
            this.dgvProductStatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductStatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductStatis.Location = new System.Drawing.Point(3, 18);
            this.dgvProductStatis.Name = "dgvProductStatis";
            this.dgvProductStatis.Size = new System.Drawing.Size(985, 152);
            this.dgvProductStatis.TabIndex = 15;
            // 
            // lblQuit3
            // 
            this.lblQuit3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuit3.AutoSize = true;
            this.lblQuit3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuit3.ForeColor = System.Drawing.Color.Red;
            this.lblQuit3.Location = new System.Drawing.Point(953, 16);
            this.lblQuit3.Name = "lblQuit3";
            this.lblQuit3.Size = new System.Drawing.Size(30, 15);
            this.lblQuit3.TabIndex = 14;
            this.lblQuit3.Text = "Quit";
            this.lblQuit3.Click += new System.EventHandler(this.lblQuit3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTotalPriceNumber);
            this.panel3.Controls.Add(this.lblTotalPrice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 464);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 36);
            this.panel3.TabIndex = 5;
            // 
            // lblTotalPriceNumber
            // 
            this.lblTotalPriceNumber.AutoSize = true;
            this.lblTotalPriceNumber.Location = new System.Drawing.Point(747, 11);
            this.lblTotalPriceNumber.Name = "lblTotalPriceNumber";
            this.lblTotalPriceNumber.Size = new System.Drawing.Size(13, 15);
            this.lblTotalPriceNumber.TabIndex = 4;
            this.lblTotalPriceNumber.Text = "0";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(670, 11);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(71, 15);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblInOut
            // 
            this.lblInOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInOut.AutoSize = true;
            this.lblInOut.Location = new System.Drawing.Point(8, 16);
            this.lblInOut.Name = "lblInOut";
            this.lblInOut.Size = new System.Drawing.Size(49, 15);
            this.lblInOut.TabIndex = 4;
            this.lblInOut.Text = "Product";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Import",
            "Export"});
            this.comboBox1.Location = new System.Drawing.Point(63, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // ccbMonthStatis
            // 
            this.ccbMonthStatis.FormattingEnabled = true;
            this.ccbMonthStatis.Location = new System.Drawing.Point(350, 221);
            this.ccbMonthStatis.Name = "ccbMonthStatis";
            this.ccbMonthStatis.Size = new System.Drawing.Size(250, 23);
            this.ccbMonthStatis.TabIndex = 2;
            // 
            // cbbYearStatis
            // 
            this.cbbYearStatis.FormattingEnabled = true;
            this.cbbYearStatis.Location = new System.Drawing.Point(44, 221);
            this.cbbYearStatis.Name = "cbbYearStatis";
            this.cbbYearStatis.Size = new System.Drawing.Size(250, 23);
            this.cbbYearStatis.TabIndex = 1;
            // 
            // lblYearStatis
            // 
            this.lblYearStatis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYearStatis.AutoSize = true;
            this.lblYearStatis.Location = new System.Drawing.Point(8, 229);
            this.lblYearStatis.Name = "lblYearStatis";
            this.lblYearStatis.Size = new System.Drawing.Size(30, 15);
            this.lblYearStatis.TabIndex = 1;
            this.lblYearStatis.Text = "Year";
            // 
            // lblMonthStatis
            // 
            this.lblMonthStatis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthStatis.AutoSize = true;
            this.lblMonthStatis.Location = new System.Drawing.Point(300, 229);
            this.lblMonthStatis.Name = "lblMonthStatis";
            this.lblMonthStatis.Size = new System.Drawing.Size(44, 15);
            this.lblMonthStatis.TabIndex = 1;
            this.lblMonthStatis.Text = "Month";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.dgvReport);
            this.groupBox6.Location = new System.Drawing.Point(0, 247);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(991, 211);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Receipt Detail";
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(3, 18);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(985, 190);
            this.dgvReport.TabIndex = 5;
            // 
            // boxNameImport
            // 
            this.boxNameImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxNameImport.AutoSize = true;
            this.boxNameImport.Controls.Add(this.txtEmployeeNameImport);
            this.boxNameImport.Controls.Add(this.txtProductIDImport);
            this.boxNameImport.Controls.Add(this.txtQuantityWImport);
            this.boxNameImport.Controls.Add(this.txtPriceImport);
            this.boxNameImport.Controls.Add(this.btnClearImportList);
            this.boxNameImport.Controls.Add(this.lblEmployeeNameImport);
            this.boxNameImport.Controls.Add(this.lblProductIDImport);
            this.boxNameImport.Controls.Add(this.lblQuantityWareHouse);
            this.boxNameImport.Controls.Add(this.lblImportPrice);
            this.boxNameImport.Controls.Add(this.boxQuantityImport);
            this.boxNameImport.Controls.Add(this.btnDeleteProductImport);
            this.boxNameImport.Controls.Add(this.btnAddProductmport);
            this.boxNameImport.Controls.Add(this.cbbImportName);
            this.boxNameImport.Controls.Add(this.lblQuantityImport);
            this.boxNameImport.Controls.Add(this.lblNameImport);
            this.boxNameImport.Location = new System.Drawing.Point(0, 33);
            this.boxNameImport.Name = "boxNameImport";
            this.boxNameImport.Size = new System.Drawing.Size(991, 148);
            this.boxNameImport.TabIndex = 3;
            this.boxNameImport.TabStop = false;
            this.boxNameImport.Text = "Product";
            // 
            // txtEmployeeNameImport
            // 
            this.txtEmployeeNameImport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmployeeBindingSource, "EName", true));
            this.txtEmployeeNameImport.Location = new System.Drawing.Point(573, 104);
            this.txtEmployeeNameImport.Name = "txtEmployeeNameImport";
            this.txtEmployeeNameImport.Size = new System.Drawing.Size(255, 22);
            this.txtEmployeeNameImport.TabIndex = 10;
            // 
            // tblEmployeeBindingSource
            // 
            this.tblEmployeeBindingSource.DataMember = "tblEmployee";
            this.tblEmployeeBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // txtProductIDImport
            // 
            this.txtProductIDImport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "ProductID", true));
            this.txtProductIDImport.Location = new System.Drawing.Point(573, 73);
            this.txtProductIDImport.Name = "txtProductIDImport";
            this.txtProductIDImport.Size = new System.Drawing.Size(255, 22);
            this.txtProductIDImport.TabIndex = 9;
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // txtQuantityWImport
            // 
            this.txtQuantityWImport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "Quantity", true));
            this.txtQuantityWImport.Location = new System.Drawing.Point(573, 42);
            this.txtQuantityWImport.Name = "txtQuantityWImport";
            this.txtQuantityWImport.Size = new System.Drawing.Size(255, 22);
            this.txtQuantityWImport.TabIndex = 8;
            // 
            // txtPriceImport
            // 
            this.txtPriceImport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "ImportPrice", true));
            this.txtPriceImport.Location = new System.Drawing.Point(573, 15);
            this.txtPriceImport.Name = "txtPriceImport";
            this.txtPriceImport.Size = new System.Drawing.Size(255, 22);
            this.txtPriceImport.TabIndex = 7;
            // 
            // btnClearImportList
            // 
            this.btnClearImportList.Location = new System.Drawing.Point(255, 104);
            this.btnClearImportList.Name = "btnClearImportList";
            this.btnClearImportList.Size = new System.Drawing.Size(75, 23);
            this.btnClearImportList.TabIndex = 13;
            this.btnClearImportList.Text = "Clear";
            this.btnClearImportList.UseVisualStyleBackColor = true;
            this.btnClearImportList.Click += new System.EventHandler(this.btnClearImportList_Click_1);
            // 
            // lblEmployeeNameImport
            // 
            this.lblEmployeeNameImport.AutoSize = true;
            this.lblEmployeeNameImport.Location = new System.Drawing.Point(419, 111);
            this.lblEmployeeNameImport.Name = "lblEmployeeNameImport";
            this.lblEmployeeNameImport.Size = new System.Drawing.Size(92, 15);
            this.lblEmployeeNameImport.TabIndex = 10;
            this.lblEmployeeNameImport.Text = "Employee Name";
            // 
            // lblProductIDImport
            // 
            this.lblProductIDImport.AutoSize = true;
            this.lblProductIDImport.Location = new System.Drawing.Point(419, 80);
            this.lblProductIDImport.Name = "lblProductIDImport";
            this.lblProductIDImport.Size = new System.Drawing.Size(20, 15);
            this.lblProductIDImport.TabIndex = 10;
            this.lblProductIDImport.Text = "ID";
            // 
            // lblQuantityWareHouse
            // 
            this.lblQuantityWareHouse.AutoSize = true;
            this.lblQuantityWareHouse.Location = new System.Drawing.Point(419, 49);
            this.lblQuantityWareHouse.Name = "lblQuantityWareHouse";
            this.lblQuantityWareHouse.Size = new System.Drawing.Size(128, 15);
            this.lblQuantityWareHouse.TabIndex = 9;
            this.lblQuantityWareHouse.Text = "Quantity in warehouse";
            // 
            // lblImportPrice
            // 
            this.lblImportPrice.AutoSize = true;
            this.lblImportPrice.Location = new System.Drawing.Point(419, 18);
            this.lblImportPrice.Name = "lblImportPrice";
            this.lblImportPrice.Size = new System.Drawing.Size(33, 15);
            this.lblImportPrice.TabIndex = 8;
            this.lblImportPrice.Text = "Price";
            // 
            // btnDeleteProductImport
            // 
            this.btnDeleteProductImport.Location = new System.Drawing.Point(174, 104);
            this.btnDeleteProductImport.Name = "btnDeleteProductImport";
            this.btnDeleteProductImport.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProductImport.TabIndex = 12;
            this.btnDeleteProductImport.Text = "Delete";
            this.btnDeleteProductImport.UseVisualStyleBackColor = true;
            this.btnDeleteProductImport.Click += new System.EventHandler(this.btnDeleteProductImport_Click);
            // 
            // btnAddProductmport
            // 
            this.btnAddProductmport.Location = new System.Drawing.Point(93, 104);
            this.btnAddProductmport.Name = "btnAddProductmport";
            this.btnAddProductmport.Size = new System.Drawing.Size(75, 23);
            this.btnAddProductmport.TabIndex = 11;
            this.btnAddProductmport.Text = "Add";
            this.btnAddProductmport.UseVisualStyleBackColor = true;
            this.btnAddProductmport.Click += new System.EventHandler(this.btnAddProductmport_Click_1);
            // 
            // cbbImportName
            // 
            this.cbbImportName.DataSource = this.tblProductBindingSource;
            this.cbbImportName.DisplayMember = "Name";
            this.cbbImportName.FormattingEnabled = true;
            this.cbbImportName.Location = new System.Drawing.Point(93, 10);
            this.cbbImportName.Name = "cbbImportName";
            this.cbbImportName.Size = new System.Drawing.Size(237, 23);
            this.cbbImportName.TabIndex = 5;
            this.cbbImportName.ValueMember = "Name";
            // 
            // lblQuantityImport
            // 
            this.lblQuantityImport.AutoSize = true;
            this.lblQuantityImport.Location = new System.Drawing.Point(8, 49);
            this.lblQuantityImport.Name = "lblQuantityImport";
            this.lblQuantityImport.Size = new System.Drawing.Size(54, 15);
            this.lblQuantityImport.TabIndex = 0;
            this.lblQuantityImport.Text = "Quantity";
            // 
            // lblNameImport
            // 
            this.lblNameImport.AutoSize = true;
            this.lblNameImport.Location = new System.Drawing.Point(8, 18);
            this.lblNameImport.Name = "lblNameImport";
            this.lblNameImport.Size = new System.Drawing.Size(37, 15);
            this.lblNameImport.TabIndex = 0;
            this.lblNameImport.Text = "Name";
            // 
            // tabImport
            // 
            this.tabImport.Controls.Add(this.label10);
            this.tabImport.Controls.Add(this.btnSetImportReceiptID);
            this.tabImport.Controls.Add(this.lblQuit1);
            this.tabImport.Controls.Add(this.boxDistributorIDImport);
            this.tabImport.Controls.Add(this.ccbEmployeeIDImport);
            this.tabImport.Controls.Add(this.label5);
            this.tabImport.Controls.Add(this.txtImportReceiptID);
            this.tabImport.Controls.Add(this.groupBox4);
            this.tabImport.Controls.Add(this.boxDistributorID);
            this.tabImport.Controls.Add(this.panel1);
            this.tabImport.Controls.Add(this.lblImportReceiptID);
            this.tabImport.Controls.Add(this.boxNameImport);
            this.tabImport.Controls.Add(this.lblDateImport);
            this.tabImport.Controls.Add(this.dtpDateImport);
            this.tabImport.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabImport.Location = new System.Drawing.Point(4, 28);
            this.tabImport.Name = "tabImport";
            this.tabImport.Padding = new System.Windows.Forms.Padding(3);
            this.tabImport.Size = new System.Drawing.Size(991, 503);
            this.tabImport.TabIndex = 0;
            this.tabImport.Text = "Import";
            this.tabImport.UseVisualStyleBackColor = true;
            // 
            // btnSetImportReceiptID
            // 
            this.btnSetImportReceiptID.Location = new System.Drawing.Point(887, 7);
            this.btnSetImportReceiptID.Name = "btnSetImportReceiptID";
            this.btnSetImportReceiptID.Size = new System.Drawing.Size(60, 23);
            this.btnSetImportReceiptID.TabIndex = 13;
            this.btnSetImportReceiptID.Text = "Set";
            this.btnSetImportReceiptID.UseVisualStyleBackColor = true;
            this.btnSetImportReceiptID.Click += new System.EventHandler(this.btnSetImportReceiptID_Click);
            // 
            // lblQuit1
            // 
            this.lblQuit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuit1.AutoSize = true;
            this.lblQuit1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuit1.ForeColor = System.Drawing.Color.Red;
            this.lblQuit1.Location = new System.Drawing.Point(1080, 11);
            this.lblQuit1.Name = "lblQuit1";
            this.lblQuit1.Size = new System.Drawing.Size(30, 15);
            this.lblQuit1.TabIndex = 12;
            this.lblQuit1.Text = "Quit";
            this.lblQuit1.Click += new System.EventHandler(this.lblQuit1_Click);
            // 
            // boxDistributorIDImport
            // 
            this.boxDistributorIDImport.DataSource = this.tblDistributorBindingSource;
            this.boxDistributorIDImport.DisplayMember = "DistributorID";
            this.boxDistributorIDImport.FormattingEnabled = true;
            this.boxDistributorIDImport.Location = new System.Drawing.Point(552, 5);
            this.boxDistributorIDImport.Name = "boxDistributorIDImport";
            this.boxDistributorIDImport.Size = new System.Drawing.Size(108, 23);
            this.boxDistributorIDImport.TabIndex = 3;
            this.boxDistributorIDImport.ValueMember = "DistributorID";
            // 
            // tblDistributorBindingSource
            // 
            this.tblDistributorBindingSource.DataMember = "tblDistributor";
            this.tblDistributorBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // ccbEmployeeIDImport
            // 
            this.ccbEmployeeIDImport.DataSource = this.tblEmployeeBindingSource;
            this.ccbEmployeeIDImport.DisplayMember = "EmployeeID";
            this.ccbEmployeeIDImport.FormattingEnabled = true;
            this.ccbEmployeeIDImport.Location = new System.Drawing.Point(336, 4);
            this.ccbEmployeeIDImport.Name = "ccbEmployeeIDImport";
            this.ccbEmployeeIDImport.Size = new System.Drawing.Size(108, 23);
            this.ccbEmployeeIDImport.TabIndex = 2;
            this.ccbEmployeeIDImport.ValueMember = "EmployeeID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Employee ID";
            // 
            // txtImportReceiptID
            // 
            this.txtImportReceiptID.Location = new System.Drawing.Point(787, 6);
            this.txtImportReceiptID.Name = "txtImportReceiptID";
            this.txtImportReceiptID.Size = new System.Drawing.Size(94, 22);
            this.txtImportReceiptID.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvProduct);
            this.groupBox4.Location = new System.Drawing.Point(0, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(991, 289);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Product list";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clReceiptID,
            this.clProductID,
            this.clName,
            this.clQuantity,
            this.clPrice,
            this.clTotalPrice});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(3, 18);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(985, 268);
            this.dgvProduct.TabIndex = 14;
            // 
            // clReceiptID
            // 
            this.clReceiptID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clReceiptID.HeaderText = "Receipt ID";
            this.clReceiptID.Name = "clReceiptID";
            this.clReceiptID.ReadOnly = true;
            this.clReceiptID.Width = 88;
            // 
            // clProductID
            // 
            this.clProductID.HeaderText = "Product ID";
            this.clProductID.Name = "clProductID";
            this.clProductID.ReadOnly = true;
            // 
            // clName
            // 
            this.clName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clName.HeaderText = "Name";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            // 
            // clQuantity
            // 
            this.clQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clQuantity.HeaderText = "Quantity";
            this.clQuantity.Name = "clQuantity";
            this.clQuantity.ReadOnly = true;
            // 
            // clPrice
            // 
            this.clPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clPrice.HeaderText = "Price";
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            // 
            // clTotalPrice
            // 
            this.clTotalPrice.HeaderText = "Total Price";
            this.clTotalPrice.Name = "clTotalPrice";
            this.clTotalPrice.ReadOnly = true;
            // 
            // boxDistributorID
            // 
            this.boxDistributorID.AutoSize = true;
            this.boxDistributorID.Location = new System.Drawing.Point(465, 11);
            this.boxDistributorID.Name = "boxDistributorID";
            this.boxDistributorID.Size = new System.Drawing.Size(81, 15);
            this.boxDistributorID.TabIndex = 10;
            this.boxDistributorID.Text = "Distributor ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTotalImport);
            this.panel1.Controls.Add(this.btnCreateImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 39);
            this.panel1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(958, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "USD";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(759, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total:";
            // 
            // txtTotalImport
            // 
            this.txtTotalImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalImport.Location = new System.Drawing.Point(804, 5);
            this.txtTotalImport.Name = "txtTotalImport";
            this.txtTotalImport.Size = new System.Drawing.Size(148, 22);
            this.txtTotalImport.TabIndex = 16;
            // 
            // btnCreateImport
            // 
            this.btnCreateImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCreateImport.Location = new System.Drawing.Point(470, 8);
            this.btnCreateImport.Name = "btnCreateImport";
            this.btnCreateImport.Size = new System.Drawing.Size(75, 23);
            this.btnCreateImport.TabIndex = 15;
            this.btnCreateImport.Text = "Create";
            this.btnCreateImport.UseVisualStyleBackColor = true;
            this.btnCreateImport.Click += new System.EventHandler(this.btnCreateImport_Click_1);
            // 
            // lblImportReceiptID
            // 
            this.lblImportReceiptID.AutoSize = true;
            this.lblImportReceiptID.Location = new System.Drawing.Point(683, 12);
            this.lblImportReceiptID.Name = "lblImportReceiptID";
            this.lblImportReceiptID.Size = new System.Drawing.Size(101, 15);
            this.lblImportReceiptID.TabIndex = 10;
            this.lblImportReceiptID.Text = "Import Receipt ID";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabImport);
            this.tabControl.Controls.Add(this.tabExport);
            this.tabControl.Controls.Add(this.tabStatistic);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(999, 535);
            this.tabControl.TabIndex = 2;
            // 
            // tblExportReceiptTableAdapter
            // 
            this.tblExportReceiptTableAdapter.ClearBeforeFill = true;
            // 
            // tblStoreBuyTableAdapter
            // 
            this.tblStoreBuyTableAdapter.ClearBeforeFill = true;
            // 
            // tblEmployeeTableAdapter
            // 
            this.tblEmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // tblDistributorTableAdapter
            // 
            this.tblDistributorTableAdapter.ClearBeforeFill = true;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(955, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Quit";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(105, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(940, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "USD";
            // 
            // txtStoreExportID
            // 
            this.txtStoreExportID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblExportReceiptBindingSource, "StoreID", true));
            this.txtStoreExportID.Location = new System.Drawing.Point(480, 11);
            this.txtStoreExportID.Name = "txtStoreExportID";
            this.txtStoreExportID.Size = new System.Drawing.Size(202, 22);
            this.txtStoreExportID.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 535);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxQuantityImport)).EndInit();
            this.tabExport.ResumeLayout(false);
            this.tabExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStoreBuyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExportReceiptBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabStatistic.ResumeLayout(false);
            this.tabStatistic.PerformLayout();
            this.Product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductStatis)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.boxNameImport.ResumeLayout(false);
            this.boxNameImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            this.tabImport.ResumeLayout(false);
            this.tabImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDistributorBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.NumericUpDown boxQuantityImport;
        private System.Windows.Forms.Label lblDateImport;
        private System.Windows.Forms.DateTimePicker dtpDateImport;
        private System.Windows.Forms.TabPage tabExport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrintExport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateExport;
        private System.Windows.Forms.Label lblDateExport;
        private System.Windows.Forms.TabPage tabStatistic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalPriceNumber;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblInOut;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox ccbMonthStatis;
        private System.Windows.Forms.ComboBox cbbYearStatis;
        private System.Windows.Forms.Label lblYearStatis;
        private System.Windows.Forms.Label lblMonthStatis;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.GroupBox boxNameImport;
        private System.Windows.Forms.Button btnDeleteProductImport;
        private System.Windows.Forms.Button btnAddProductmport;
        public System.Windows.Forms.ComboBox cbbImportName;
        private System.Windows.Forms.Label lblQuantityImport;
        private System.Windows.Forms.Label lblNameImport;
        private System.Windows.Forms.Button btnClearImportList;
        private System.Windows.Forms.TabPage tabImport;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateImport;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label lblProductIDImport;
        private System.Windows.Forms.Label lblQuantityWareHouse;
        private System.Windows.Forms.Label lblImportPrice;
        private System.Windows.Forms.TextBox txtProductIDImport;
        private System.Windows.Forms.TextBox txtQuantityWImport;
        private System.Windows.Forms.TextBox txtPriceImport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ccbEmployeeIDImport;
        private System.Windows.Forms.TextBox txtEmployeeNameImport;
        private System.Windows.Forms.Label lblEmployeeNameImport;
        private System.Windows.Forms.TextBox txtImportReceiptID;
        private System.Windows.Forms.Label lblImportReceiptID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalImport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblQuit1;
        private System.Windows.Forms.Label lblQuit2;
        private System.Windows.Forms.Label lblQuit3;
        private System.Windows.Forms.Label lblReceiptIDExport;
        private System.Windows.Forms.ComboBox cbbReceiptIDExport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDayOrder;
        private System.Windows.Forms.ComboBox txtShopMethod;
        private System.Windows.Forms.Label boxDistributorID;
        private System.Windows.Forms.ComboBox boxDistributorIDImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReceiptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotalPrice;
        private System.Windows.Forms.DataGridView dgvExport;
        private System.Windows.Forms.TextBox txtPayMethodExport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetImportReceiptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exportReceiptIDDataGridViewTextBoxColumn;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource tblExportReceiptBindingSource;
        private DataBaseDataSetTableAdapters.tblExportReceiptTableAdapter tblExportReceiptTableAdapter;
        private System.Windows.Forms.BindingSource tblStoreBuyBindingSource;
        private DataBaseDataSetTableAdapters.tblStoreBuyTableAdapter tblStoreBuyTableAdapter;
        private System.Windows.Forms.BindingSource tblEmployeeBindingSource;
        private DataBaseDataSetTableAdapters.tblEmployeeTableAdapter tblEmployeeTableAdapter;
        private System.Windows.Forms.BindingSource tblDistributorBindingSource;
        private DataBaseDataSetTableAdapters.tblDistributorTableAdapter tblDistributorTableAdapter;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private DataBaseDataSetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private System.Windows.Forms.GroupBox Product;
        private System.Windows.Forms.DataGridView dgvProductStatis;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalExport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStoreExportID;
    }
}

