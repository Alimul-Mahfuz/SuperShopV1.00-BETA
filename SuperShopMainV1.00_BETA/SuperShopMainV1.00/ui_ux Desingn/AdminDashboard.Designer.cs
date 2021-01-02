namespace SuperShopMainV1._00
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.AdminDashboardPanel = new System.Windows.Forms.Panel();
            this.Reportadd = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.RemonveProduct = new System.Windows.Forms.Button();
            this.Inventory = new System.Windows.Forms.Button();
            this.admindashboarlogo = new System.Windows.Forms.PictureBox();
            this.AdminAddproductpanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reatilprice = new System.Windows.Forms.Label();
            this.RetailPricebox = new System.Windows.Forms.TextBox();
            this.adqty = new System.Windows.Forms.Label();
            this.addproductqtybox = new System.Windows.Forms.TextBox();
            this.addedbuttoninventory = new System.Windows.Forms.Button();
            this.purchasepricelabel = new System.Windows.Forms.Label();
            this.Priceadmin = new System.Windows.Forms.TextBox();
            this.ProductCata = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.CustomerNameTextboxSales = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.searchinventory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRODUCTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATAGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUYINGPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sELLINGPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNITIALSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superShopMSDBDataSet = new SuperShopMainV1._00.SuperShopMSDBDataSet();
            this.pRODUCTTableAdapter = new SuperShopMainV1._00.SuperShopMSDBDataSetTableAdapters.PRODUCTTableAdapter();
            this.superShopMSDBDataSet1 = new SuperShopMainV1._00.SuperShopMSDBDataSet1();
            this.pRODUCTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter1 = new SuperShopMainV1._00.SuperShopMSDBDataSet1TableAdapters.PRODUCTTableAdapter();
            this.AdminDashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admindashboarlogo)).BeginInit();
            this.AdminAddproductpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopMSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopMSDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminDashboardPanel
            // 
            this.AdminDashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.AdminDashboardPanel.Controls.Add(this.Reportadd);
            this.AdminDashboardPanel.Controls.Add(this.logoutbutton);
            this.AdminDashboardPanel.Controls.Add(this.RemonveProduct);
            this.AdminDashboardPanel.Controls.Add(this.Inventory);
            this.AdminDashboardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdminDashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminDashboardPanel.Name = "AdminDashboardPanel";
            this.AdminDashboardPanel.Size = new System.Drawing.Size(177, 697);
            this.AdminDashboardPanel.TabIndex = 2;
            // 
            // Reportadd
            // 
            this.Reportadd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Reportadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.Reportadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportadd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Reportadd.Location = new System.Drawing.Point(12, 165);
            this.Reportadd.Name = "Reportadd";
            this.Reportadd.Size = new System.Drawing.Size(150, 47);
            this.Reportadd.TabIndex = 3;
            this.Reportadd.Text = "Reports";
            this.Reportadd.UseVisualStyleBackColor = true;
            this.Reportadd.Click += new System.EventHandler(this.Reports_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logoutbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbutton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logoutbutton.Location = new System.Drawing.Point(12, 621);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(150, 40);
            this.logoutbutton.TabIndex = 2;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // RemonveProduct
            // 
            this.RemonveProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RemonveProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.RemonveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemonveProduct.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemonveProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RemonveProduct.Location = new System.Drawing.Point(12, 101);
            this.RemonveProduct.Name = "RemonveProduct";
            this.RemonveProduct.Size = new System.Drawing.Size(150, 47);
            this.RemonveProduct.TabIndex = 1;
            this.RemonveProduct.Text = "Delete Product";
            this.RemonveProduct.UseVisualStyleBackColor = true;
            this.RemonveProduct.Click += new System.EventHandler(this.RemonveProduct_Click);
            // 
            // Inventory
            // 
            this.Inventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Inventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Inventory.Location = new System.Drawing.Point(12, 39);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(150, 47);
            this.Inventory.TabIndex = 0;
            this.Inventory.Text = "Add Products";
            this.Inventory.UseVisualStyleBackColor = true;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // admindashboarlogo
            // 
            this.admindashboarlogo.BackColor = System.Drawing.Color.Transparent;
            this.admindashboarlogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.admindashboarlogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.admindashboarlogo.Image = global::SuperShopMainV1._00.Properties.Resources.shoplogo1;
            this.admindashboarlogo.Location = new System.Drawing.Point(177, 0);
            this.admindashboarlogo.Name = "admindashboarlogo";
            this.admindashboarlogo.Size = new System.Drawing.Size(675, 105);
            this.admindashboarlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.admindashboarlogo.TabIndex = 3;
            this.admindashboarlogo.TabStop = false;
            // 
            // AdminAddproductpanel
            // 
            this.AdminAddproductpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminAddproductpanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.AdminAddproductpanel.Controls.Add(this.comboBox1);
            this.AdminAddproductpanel.Controls.Add(this.reatilprice);
            this.AdminAddproductpanel.Controls.Add(this.RetailPricebox);
            this.AdminAddproductpanel.Controls.Add(this.adqty);
            this.AdminAddproductpanel.Controls.Add(this.addproductqtybox);
            this.AdminAddproductpanel.Controls.Add(this.addedbuttoninventory);
            this.AdminAddproductpanel.Controls.Add(this.purchasepricelabel);
            this.AdminAddproductpanel.Controls.Add(this.Priceadmin);
            this.AdminAddproductpanel.Controls.Add(this.ProductCata);
            this.AdminAddproductpanel.Controls.Add(this.ProductName);
            this.AdminAddproductpanel.Controls.Add(this.CustomerNameTextboxSales);
            this.AdminAddproductpanel.Location = new System.Drawing.Point(183, 111);
            this.AdminAddproductpanel.Name = "AdminAddproductpanel";
            this.AdminAddproductpanel.Size = new System.Drawing.Size(657, 173);
            this.AdminAddproductpanel.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GROCERY",
            "FRUITS",
            "COSMETICS",
            "SPICIES",
            "DAIRY",
            "DRINKS",
            "TOILETRIES"});
            this.comboBox1.Location = new System.Drawing.Point(123, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // reatilprice
            // 
            this.reatilprice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reatilprice.AutoSize = true;
            this.reatilprice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reatilprice.Location = new System.Drawing.Point(11, 130);
            this.reatilprice.Name = "reatilprice";
            this.reatilprice.Size = new System.Drawing.Size(75, 15);
            this.reatilprice.TabIndex = 24;
            this.reatilprice.Text = "Retail Price:";
            // 
            // RetailPricebox
            // 
            this.RetailPricebox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RetailPricebox.Location = new System.Drawing.Point(123, 128);
            this.RetailPricebox.Name = "RetailPricebox";
            this.RetailPricebox.Size = new System.Drawing.Size(274, 20);
            this.RetailPricebox.TabIndex = 23;
            // 
            // adqty
            // 
            this.adqty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.adqty.AutoSize = true;
            this.adqty.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adqty.Location = new System.Drawing.Point(11, 104);
            this.adqty.Name = "adqty";
            this.adqty.Size = new System.Drawing.Size(32, 15);
            this.adqty.TabIndex = 20;
            this.adqty.Text = "Qyt:";
            this.adqty.Click += new System.EventHandler(this.Phone_Click);
            // 
            // addproductqtybox
            // 
            this.addproductqtybox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addproductqtybox.Location = new System.Drawing.Point(123, 102);
            this.addproductqtybox.Name = "addproductqtybox";
            this.addproductqtybox.Size = new System.Drawing.Size(274, 20);
            this.addproductqtybox.TabIndex = 19;
            // 
            // addedbuttoninventory
            // 
            this.addedbuttoninventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addedbuttoninventory.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addedbuttoninventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addedbuttoninventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addedbuttoninventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addedbuttoninventory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedbuttoninventory.ForeColor = System.Drawing.Color.Black;
            this.addedbuttoninventory.Location = new System.Drawing.Point(504, 49);
            this.addedbuttoninventory.Name = "addedbuttoninventory";
            this.addedbuttoninventory.Size = new System.Drawing.Size(130, 48);
            this.addedbuttoninventory.TabIndex = 17;
            this.addedbuttoninventory.Text = "Add Inventory";
            this.addedbuttoninventory.UseVisualStyleBackColor = false;
            this.addedbuttoninventory.Click += new System.EventHandler(this.addedbuttoninventory_Click);
            // 
            // purchasepricelabel
            // 
            this.purchasepricelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.purchasepricelabel.AutoSize = true;
            this.purchasepricelabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasepricelabel.Location = new System.Drawing.Point(11, 78);
            this.purchasepricelabel.Name = "purchasepricelabel";
            this.purchasepricelabel.Size = new System.Drawing.Size(81, 15);
            this.purchasepricelabel.TabIndex = 14;
            this.purchasepricelabel.Text = "BuyingPrice:";
            // 
            // Priceadmin
            // 
            this.Priceadmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Priceadmin.Location = new System.Drawing.Point(123, 76);
            this.Priceadmin.Name = "Priceadmin";
            this.Priceadmin.Size = new System.Drawing.Size(274, 20);
            this.Priceadmin.TabIndex = 13;
            // 
            // ProductCata
            // 
            this.ProductCata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductCata.AutoSize = true;
            this.ProductCata.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCata.Location = new System.Drawing.Point(11, 52);
            this.ProductCata.Name = "ProductCata";
            this.ProductCata.Size = new System.Drawing.Size(65, 15);
            this.ProductCata.TabIndex = 4;
            this.ProductCata.Text = "Catagory:";
            // 
            // ProductName
            // 
            this.ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(11, 26);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(96, 15);
            this.ProductName.TabIndex = 2;
            this.ProductName.Text = "Product Name;";
            // 
            // CustomerNameTextboxSales
            // 
            this.CustomerNameTextboxSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomerNameTextboxSales.Location = new System.Drawing.Point(123, 24);
            this.CustomerNameTextboxSales.Name = "CustomerNameTextboxSales";
            this.CustomerNameTextboxSales.Size = new System.Drawing.Size(274, 20);
            this.CustomerNameTextboxSales.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.searchinventory);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Location = new System.Drawing.Point(183, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 115);
            this.panel1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "GROCERY",
            "FRUITS",
            "COSMETICS",
            "SPICIES",
            "DAIRY",
            "DRINKS",
            "TOILETRIES"});
            this.comboBox2.Location = new System.Drawing.Point(123, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(274, 21);
            this.comboBox2.TabIndex = 25;
            // 
            // searchinventory
            // 
            this.searchinventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchinventory.BackColor = System.Drawing.Color.PaleTurquoise;
            this.searchinventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchinventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchinventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchinventory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchinventory.ForeColor = System.Drawing.Color.Black;
            this.searchinventory.Location = new System.Drawing.Point(504, 26);
            this.searchinventory.Name = "searchinventory";
            this.searchinventory.Size = new System.Drawing.Size(130, 48);
            this.searchinventory.TabIndex = 17;
            this.searchinventory.Text = "Search Inventory";
            this.searchinventory.UseVisualStyleBackColor = false;
            this.searchinventory.Click += new System.EventHandler(this.searchinventory_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Catagory:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Product Name;";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox4.Location = new System.Drawing.Point(123, 24);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(274, 20);
            this.textBox4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRODUCTIDDataGridViewTextBoxColumn,
            this.pRODUCTNAMEDataGridViewTextBoxColumn,
            this.cATAGORYDataGridViewTextBoxColumn,
            this.bUYINGPRICEDataGridViewTextBoxColumn,
            this.sELLINGPRICEDataGridViewTextBoxColumn,
            this.iNITIALSTOCKDataGridViewTextBoxColumn,
            this.sOLDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(183, 411);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(657, 272);
            this.dataGridView1.TabIndex = 6;
            // 
            // pRODUCTIDDataGridViewTextBoxColumn
            // 
            this.pRODUCTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_ID";
            this.pRODUCTIDDataGridViewTextBoxColumn.HeaderText = "PRODUCT_ID";
            this.pRODUCTIDDataGridViewTextBoxColumn.Name = "pRODUCTIDDataGridViewTextBoxColumn";
            this.pRODUCTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUCTNAMEDataGridViewTextBoxColumn
            // 
            this.pRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_NAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCT_NAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Name = "pRODUCTNAMEDataGridViewTextBoxColumn";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cATAGORYDataGridViewTextBoxColumn
            // 
            this.cATAGORYDataGridViewTextBoxColumn.DataPropertyName = "CATAGORY";
            this.cATAGORYDataGridViewTextBoxColumn.HeaderText = "CATAGORY";
            this.cATAGORYDataGridViewTextBoxColumn.Name = "cATAGORYDataGridViewTextBoxColumn";
            this.cATAGORYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bUYINGPRICEDataGridViewTextBoxColumn
            // 
            this.bUYINGPRICEDataGridViewTextBoxColumn.DataPropertyName = "BUYING_PRICE";
            this.bUYINGPRICEDataGridViewTextBoxColumn.HeaderText = "BUYING_PRICE";
            this.bUYINGPRICEDataGridViewTextBoxColumn.Name = "bUYINGPRICEDataGridViewTextBoxColumn";
            this.bUYINGPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sELLINGPRICEDataGridViewTextBoxColumn
            // 
            this.sELLINGPRICEDataGridViewTextBoxColumn.DataPropertyName = "SELLING_PRICE";
            this.sELLINGPRICEDataGridViewTextBoxColumn.HeaderText = "SELLING_PRICE";
            this.sELLINGPRICEDataGridViewTextBoxColumn.Name = "sELLINGPRICEDataGridViewTextBoxColumn";
            this.sELLINGPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNITIALSTOCKDataGridViewTextBoxColumn
            // 
            this.iNITIALSTOCKDataGridViewTextBoxColumn.DataPropertyName = "INITIAL_STOCK";
            this.iNITIALSTOCKDataGridViewTextBoxColumn.HeaderText = "INITIAL_STOCK";
            this.iNITIALSTOCKDataGridViewTextBoxColumn.Name = "iNITIALSTOCKDataGridViewTextBoxColumn";
            this.iNITIALSTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sOLDDataGridViewTextBoxColumn
            // 
            this.sOLDDataGridViewTextBoxColumn.DataPropertyName = "SOLD";
            this.sOLDDataGridViewTextBoxColumn.HeaderText = "SOLD";
            this.sOLDDataGridViewTextBoxColumn.Name = "sOLDDataGridViewTextBoxColumn";
            this.sOLDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.superShopMSDBDataSet;
            // 
            // superShopMSDBDataSet
            // 
            this.superShopMSDBDataSet.DataSetName = "SuperShopMSDBDataSet";
            this.superShopMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // superShopMSDBDataSet1
            // 
            this.superShopMSDBDataSet1.DataSetName = "SuperShopMSDBDataSet1";
            this.superShopMSDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTBindingSource1
            // 
            this.pRODUCTBindingSource1.DataMember = "PRODUCT";
            this.pRODUCTBindingSource1.DataSource = this.superShopMSDBDataSet1;
            // 
            // pRODUCTTableAdapter1
            // 
            this.pRODUCTTableAdapter1.ClearBeforeFill = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperShopMainV1._00.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(852, 697);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminAddproductpanel);
            this.Controls.Add(this.admindashboarlogo);
            this.Controls.Add(this.AdminDashboardPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(868, 736);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.AdminDashboardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.admindashboarlogo)).EndInit();
            this.AdminAddproductpanel.ResumeLayout(false);
            this.AdminAddproductpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopMSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopMSDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminDashboardPanel;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Button RemonveProduct;
        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.PictureBox admindashboarlogo;
        private System.Windows.Forms.Panel AdminAddproductpanel;
        private System.Windows.Forms.Label adqty;
        private System.Windows.Forms.TextBox addproductqtybox;
        private System.Windows.Forms.Button addedbuttoninventory;
        private System.Windows.Forms.Label purchasepricelabel;
        private System.Windows.Forms.TextBox Priceadmin;
        private System.Windows.Forms.Label ProductCata;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.TextBox CustomerNameTextboxSales;
        private System.Windows.Forms.Button Reportadd;
        private System.Windows.Forms.Label reatilprice;
        private System.Windows.Forms.TextBox RetailPricebox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button searchinventory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SuperShopMSDBDataSet superShopMSDBDataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private SuperShopMSDBDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATAGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUYINGPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sELLINGPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNITIALSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLDDataGridViewTextBoxColumn;
        private SuperShopMSDBDataSet1 superShopMSDBDataSet1;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource1;
        private SuperShopMSDBDataSet1TableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter1;
    }
}