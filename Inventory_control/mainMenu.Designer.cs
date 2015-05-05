namespace Inventory_control
{
    partial class mainMenu
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
            System.Windows.Forms.Label idcustomerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            System.Windows.Forms.Label customerNameLabel1;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label telNoLabel;
            System.Windows.Forms.Label fax_noLabel;
            System.Windows.Forms.Label companyNameLabel;
            this.MenuTab = new System.Windows.Forms.TabControl();
            this.SalesTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SalesOrderTab = new System.Windows.Forms.TabPage();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idcustomerComboBox = new System.Windows.Forms.ComboBox();
            this.sales_orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sales_orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sales_orderDataGridView = new System.Windows.Forms.DataGridView();
            this.PickingTab = new System.Windows.Forms.TabPage();
            this.PackingTab = new System.Windows.Forms.TabPage();
            this.ShippingTab = new System.Windows.Forms.TabPage();
            this.PurchaseTab = new System.Windows.Forms.TabPage();
            this.BillsTab = new System.Windows.Forms.TabPage();
            this.PayableTab = new System.Windows.Forms.TabPage();
            this.FinancialTab = new System.Windows.Forms.TabPage();
            this.RegisterCusto = new System.Windows.Forms.TabPage();
            this.RegisterCustom = new System.Windows.Forms.Button();
            this.SettingTab = new System.Windows.Forms.TabPage();
            this.HelpTab = new System.Windows.Forms.TabPage();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sales_orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sales_orderTableAdapter = new Inventory_control.inventory_controlDataSetTableAdapters.sales_orderTableAdapter();
            this.tableAdapterManager = new Inventory_control.inventory_controlDataSetTableAdapters.TableAdapterManager();
            this.productTableAdapter = new Inventory_control.inventory_controlDataSetTableAdapters.productTableAdapter();
            this.customerTableAdapter = new Inventory_control.inventory_controlDataSetTableAdapters.customerTableAdapter();
            this.inventory_controlDataSet1 = new Inventory_control.inventory_controlDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerNameTextBox1 = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.telNoTextBox = new System.Windows.Forms.TextBox();
            this.fax_noTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.regProduct = new System.Windows.Forms.Button();
            this.fRProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sales_orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            idcustomerLabel = new System.Windows.Forms.Label();
            customerNameLabel1 = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            telNoLabel = new System.Windows.Forms.Label();
            fax_noLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            this.MenuTab.SuspendLayout();
            this.SalesTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SalesOrderTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_orderBindingNavigator)).BeginInit();
            this.sales_orderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_orderDataGridView)).BeginInit();
            this.RegisterCusto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_controlDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idcustomerLabel
            // 
            idcustomerLabel.AutoSize = true;
            idcustomerLabel.Location = new System.Drawing.Point(38, 37);
            idcustomerLabel.Name = "idcustomerLabel";
            idcustomerLabel.Size = new System.Drawing.Size(108, 24);
            idcustomerLabel.TabIndex = 13;
            idcustomerLabel.Text = "idcustomer:";
            // 
            // MenuTab
            // 
            this.MenuTab.Controls.Add(this.SalesTab);
            this.MenuTab.Controls.Add(this.PurchaseTab);
            this.MenuTab.Controls.Add(this.BillsTab);
            this.MenuTab.Controls.Add(this.PayableTab);
            this.MenuTab.Controls.Add(this.FinancialTab);
            this.MenuTab.Controls.Add(this.RegisterCusto);
            this.MenuTab.Controls.Add(this.SettingTab);
            this.MenuTab.Controls.Add(this.HelpTab);
            this.MenuTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTab.Location = new System.Drawing.Point(13, 13);
            this.MenuTab.Name = "MenuTab";
            this.MenuTab.SelectedIndex = 0;
            this.MenuTab.Size = new System.Drawing.Size(1239, 723);
            this.MenuTab.TabIndex = 0;
            // 
            // SalesTab
            // 
            this.SalesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SalesTab.Controls.Add(this.tabControl1);
            this.SalesTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SalesTab.Location = new System.Drawing.Point(4, 33);
            this.SalesTab.Name = "SalesTab";
            this.SalesTab.Padding = new System.Windows.Forms.Padding(3);
            this.SalesTab.Size = new System.Drawing.Size(1231, 686);
            this.SalesTab.TabIndex = 0;
            this.SalesTab.Text = "Sales";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SalesOrderTab);
            this.tabControl1.Controls.Add(this.PickingTab);
            this.tabControl1.Controls.Add(this.PackingTab);
            this.tabControl1.Controls.Add(this.ShippingTab);
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1218, 673);
            this.tabControl1.TabIndex = 0;
            // 
            // SalesOrderTab
            // 
            this.SalesOrderTab.AutoScroll = true;
            this.SalesOrderTab.Controls.Add(this.Refresh_button);
            this.SalesOrderTab.Controls.Add(this.panel1);
            this.SalesOrderTab.Controls.Add(this.sales_orderBindingNavigator);
            this.SalesOrderTab.Controls.Add(this.sales_orderDataGridView);
            this.SalesOrderTab.Location = new System.Drawing.Point(4, 33);
            this.SalesOrderTab.Name = "SalesOrderTab";
            this.SalesOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.SalesOrderTab.Size = new System.Drawing.Size(1210, 636);
            this.SalesOrderTab.TabIndex = 0;
            this.SalesOrderTab.Text = "Sales Order";
            this.SalesOrderTab.UseVisualStyleBackColor = true;
            // 
            // Refresh_button
            // 
            this.Refresh_button.Location = new System.Drawing.Point(760, 134);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(93, 41);
            this.Refresh_button.TabIndex = 4;
            this.Refresh_button.Text = "Refresh";
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(companyNameLabel);
            this.panel1.Controls.Add(this.companyNameTextBox);
            this.panel1.Controls.Add(fax_noLabel);
            this.panel1.Controls.Add(this.fax_noTextBox);
            this.panel1.Controls.Add(telNoLabel);
            this.panel1.Controls.Add(this.telNoTextBox);
            this.panel1.Controls.Add(addressLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(customerNameLabel1);
            this.panel1.Controls.Add(this.customerNameTextBox1);
            this.panel1.Controls.Add(idcustomerLabel);
            this.panel1.Controls.Add(this.idcustomerComboBox);
            this.panel1.Location = new System.Drawing.Point(30, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 409);
            this.panel1.TabIndex = 3;
            // 
            // idcustomerComboBox
            // 
            this.idcustomerComboBox.DataSource = this.customerBindingSource1;
            this.idcustomerComboBox.DisplayMember = "idcustomer";
            this.idcustomerComboBox.FormattingEnabled = true;
            this.idcustomerComboBox.Location = new System.Drawing.Point(192, 29);
            this.idcustomerComboBox.Name = "idcustomerComboBox";
            this.idcustomerComboBox.Size = new System.Drawing.Size(121, 32);
            this.idcustomerComboBox.TabIndex = 14;
            this.idcustomerComboBox.ValueMember = "idcustomer";
            // 
            // sales_orderBindingNavigator
            // 
            this.sales_orderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sales_orderBindingNavigator.BindingSource = this.sales_orderBindingSource;
            this.sales_orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sales_orderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sales_orderBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.sales_orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sales_orderBindingNavigatorSaveItem});
            this.sales_orderBindingNavigator.Location = new System.Drawing.Point(30, 21);
            this.sales_orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sales_orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sales_orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sales_orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sales_orderBindingNavigator.Name = "sales_orderBindingNavigator";
            this.sales_orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sales_orderBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.sales_orderBindingNavigator.TabIndex = 1;
            this.sales_orderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sales_orderBindingNavigatorSaveItem
            // 
            this.sales_orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sales_orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sales_orderBindingNavigatorSaveItem.Image")));
            this.sales_orderBindingNavigatorSaveItem.Name = "sales_orderBindingNavigatorSaveItem";
            this.sales_orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sales_orderBindingNavigatorSaveItem.Text = "Save Data";
            this.sales_orderBindingNavigatorSaveItem.Click += new System.EventHandler(this.sales_orderBindingNavigatorSaveItem_Click);
            // 
            // sales_orderDataGridView
            // 
            this.sales_orderDataGridView.AutoGenerateColumns = false;
            this.sales_orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sales_orderDataGridView.DataSource = this.sales_orderBindingSource;
            this.sales_orderDataGridView.Location = new System.Drawing.Point(30, 49);
            this.sales_orderDataGridView.Name = "sales_orderDataGridView";
            this.sales_orderDataGridView.Size = new System.Drawing.Size(593, 154);
            this.sales_orderDataGridView.TabIndex = 0;
            // 
            // PickingTab
            // 
            this.PickingTab.Location = new System.Drawing.Point(4, 33);
            this.PickingTab.Name = "PickingTab";
            this.PickingTab.Padding = new System.Windows.Forms.Padding(3);
            this.PickingTab.Size = new System.Drawing.Size(1210, 636);
            this.PickingTab.TabIndex = 1;
            this.PickingTab.Text = "Picking";
            this.PickingTab.UseVisualStyleBackColor = true;
            // 
            // PackingTab
            // 
            this.PackingTab.Location = new System.Drawing.Point(4, 33);
            this.PackingTab.Name = "PackingTab";
            this.PackingTab.Padding = new System.Windows.Forms.Padding(3);
            this.PackingTab.Size = new System.Drawing.Size(1210, 636);
            this.PackingTab.TabIndex = 2;
            this.PackingTab.Text = "Packing";
            this.PackingTab.UseVisualStyleBackColor = true;
            // 
            // ShippingTab
            // 
            this.ShippingTab.Location = new System.Drawing.Point(4, 33);
            this.ShippingTab.Name = "ShippingTab";
            this.ShippingTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShippingTab.Size = new System.Drawing.Size(1210, 636);
            this.ShippingTab.TabIndex = 3;
            this.ShippingTab.Text = "Shipping";
            this.ShippingTab.UseVisualStyleBackColor = true;
            // 
            // PurchaseTab
            // 
            this.PurchaseTab.Location = new System.Drawing.Point(4, 33);
            this.PurchaseTab.Name = "PurchaseTab";
            this.PurchaseTab.Padding = new System.Windows.Forms.Padding(3);
            this.PurchaseTab.Size = new System.Drawing.Size(1231, 686);
            this.PurchaseTab.TabIndex = 1;
            this.PurchaseTab.Text = "Purchase";
            this.PurchaseTab.UseVisualStyleBackColor = true;
            // 
            // BillsTab
            // 
            this.BillsTab.Location = new System.Drawing.Point(4, 33);
            this.BillsTab.Name = "BillsTab";
            this.BillsTab.Padding = new System.Windows.Forms.Padding(3);
            this.BillsTab.Size = new System.Drawing.Size(1231, 686);
            this.BillsTab.TabIndex = 2;
            this.BillsTab.Text = "Bills";
            this.BillsTab.UseVisualStyleBackColor = true;
            // 
            // PayableTab
            // 
            this.PayableTab.Location = new System.Drawing.Point(4, 33);
            this.PayableTab.Name = "PayableTab";
            this.PayableTab.Padding = new System.Windows.Forms.Padding(3);
            this.PayableTab.Size = new System.Drawing.Size(1231, 686);
            this.PayableTab.TabIndex = 3;
            this.PayableTab.Text = "Payable";
            this.PayableTab.UseVisualStyleBackColor = true;
            // 
            // FinancialTab
            // 
            this.FinancialTab.Location = new System.Drawing.Point(4, 33);
            this.FinancialTab.Name = "FinancialTab";
            this.FinancialTab.Padding = new System.Windows.Forms.Padding(3);
            this.FinancialTab.Size = new System.Drawing.Size(1231, 686);
            this.FinancialTab.TabIndex = 4;
            this.FinancialTab.Text = "Financial";
            this.FinancialTab.UseVisualStyleBackColor = true;
            // 
            // RegisterCusto
            // 
            this.RegisterCusto.Controls.Add(this.regProduct);
            this.RegisterCusto.Controls.Add(this.RegisterCustom);
            this.RegisterCusto.Location = new System.Drawing.Point(4, 33);
            this.RegisterCusto.Name = "RegisterCusto";
            this.RegisterCusto.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterCusto.Size = new System.Drawing.Size(1231, 686);
            this.RegisterCusto.TabIndex = 5;
            this.RegisterCusto.Text = "Register";
            this.RegisterCusto.UseVisualStyleBackColor = true;
            // 
            // RegisterCustom
            // 
            this.RegisterCustom.Location = new System.Drawing.Point(96, 51);
            this.RegisterCustom.Name = "RegisterCustom";
            this.RegisterCustom.Size = new System.Drawing.Size(121, 58);
            this.RegisterCustom.TabIndex = 0;
            this.RegisterCustom.Text = "Register Customer";
            this.RegisterCustom.UseVisualStyleBackColor = true;
            this.RegisterCustom.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingTab
            // 
            this.SettingTab.Location = new System.Drawing.Point(4, 33);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingTab.Size = new System.Drawing.Size(1231, 686);
            this.SettingTab.TabIndex = 6;
            this.SettingTab.Text = "Setting";
            this.SettingTab.UseVisualStyleBackColor = true;
            // 
            // HelpTab
            // 
            this.HelpTab.Location = new System.Drawing.Point(4, 33);
            this.HelpTab.Name = "HelpTab";
            this.HelpTab.Padding = new System.Windows.Forms.Padding(3);
            this.HelpTab.Size = new System.Drawing.Size(1231, 686);
            this.HelpTab.TabIndex = 7;
            this.HelpTab.Text = "Help";
            this.HelpTab.UseVisualStyleBackColor = true;
            // 
            // sales_orderTableAdapter
            // 
            this.sales_orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bill_receivedTableAdapter = null;
            this.tableAdapterManager.companydataTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.expensemaintenanceTableAdapter = null;
            this.tableAdapterManager.financialTableAdapter = null;
            this.tableAdapterManager.packingTableAdapter = null;
            this.tableAdapterManager.payableTableAdapter = null;
            this.tableAdapterManager.pickingTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.purchase_orderTableAdapter = null;
            this.tableAdapterManager.sales_orderTableAdapter = this.sales_orderTableAdapter;
            this.tableAdapterManager.shippingTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Inventory_control.inventory_controlDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // inventory_controlDataSet1
            // 
            this.inventory_controlDataSet1.DataSetName = "inventory_controlDataSet";
            this.inventory_controlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "customer";
            this.customerBindingSource1.DataSource = this.inventory_controlDataSet1;
            // 
            // customerNameLabel1
            // 
            customerNameLabel1.AutoSize = true;
            customerNameLabel1.Location = new System.Drawing.Point(38, 75);
            customerNameLabel1.Name = "customerNameLabel1";
            customerNameLabel1.Size = new System.Drawing.Size(152, 24);
            customerNameLabel1.TabIndex = 15;
            customerNameLabel1.Text = "Customer Name:";
            // 
            // customerNameTextBox1
            // 
            this.customerNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource1, "CustomerName", true));
            this.customerNameTextBox1.Location = new System.Drawing.Point(192, 70);
            this.customerNameTextBox1.Name = "customerNameTextBox1";
            this.customerNameTextBox1.Size = new System.Drawing.Size(204, 29);
            this.customerNameTextBox1.TabIndex = 16;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(544, 34);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(82, 24);
            addressLabel.TabIndex = 16;
            addressLabel.Text = "address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource1, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(632, 31);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(389, 29);
            this.addressTextBox.TabIndex = 17;
            // 
            // telNoLabel
            // 
            telNoLabel.AutoSize = true;
            telNoLabel.Location = new System.Drawing.Point(38, 120);
            telNoLabel.Name = "telNoLabel";
            telNoLabel.Size = new System.Drawing.Size(64, 24);
            telNoLabel.TabIndex = 17;
            telNoLabel.Text = "tel No:";
            // 
            // telNoTextBox
            // 
            this.telNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource1, "telNo", true));
            this.telNoTextBox.Location = new System.Drawing.Point(192, 117);
            this.telNoTextBox.Name = "telNoTextBox";
            this.telNoTextBox.Size = new System.Drawing.Size(204, 29);
            this.telNoTextBox.TabIndex = 18;
            // 
            // fax_noLabel
            // 
            fax_noLabel.AutoSize = true;
            fax_noLabel.Location = new System.Drawing.Point(544, 85);
            fax_noLabel.Name = "fax_noLabel";
            fax_noLabel.Size = new System.Drawing.Size(66, 24);
            fax_noLabel.TabIndex = 18;
            fax_noLabel.Text = "fax no:";
            // 
            // fax_noTextBox
            // 
            this.fax_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource1, "fax_no", true));
            this.fax_noTextBox.Location = new System.Drawing.Point(632, 82);
            this.fax_noTextBox.Name = "fax_noTextBox";
            this.fax_noTextBox.Size = new System.Drawing.Size(296, 29);
            this.fax_noTextBox.TabIndex = 19;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(461, 122);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(149, 24);
            companyNameLabel.TabIndex = 19;
            companyNameLabel.Text = "company Name:";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource1, "companyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(632, 122);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(296, 29);
            this.companyNameTextBox.TabIndex = 20;
            // 
            // regProduct
            // 
            this.regProduct.Location = new System.Drawing.Point(245, 51);
            this.regProduct.Name = "regProduct";
            this.regProduct.Size = new System.Drawing.Size(123, 58);
            this.regProduct.TabIndex = 1;
            this.regProduct.Text = "Register Product";
            this.regProduct.UseVisualStyleBackColor = true;
            this.regProduct.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fRProductBindingSource
            // 
            this.fRProductBindingSource.DataSource = this.productBindingSource;
            // 
            // sales_orderBindingSource1
            // 
            this.sales_orderBindingSource1.DataMember = "sales_order";
            this.sales_orderBindingSource1.DataSource = this.inventory_controlDataSet1;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "product";
            this.productBindingSource1.DataSource = this.inventory_controlDataSet1;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1264, 748);
            this.Controls.Add(this.MenuTab);
            this.Name = "mainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.MenuTab.ResumeLayout(false);
            this.SalesTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.SalesOrderTab.ResumeLayout(false);
            this.SalesOrderTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_orderBindingNavigator)).EndInit();
            this.sales_orderBindingNavigator.ResumeLayout(false);
            this.sales_orderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_orderDataGridView)).EndInit();
            this.RegisterCusto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_controlDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MenuTab;
        private System.Windows.Forms.TabPage SalesTab;
        private System.Windows.Forms.TabPage PurchaseTab;
        private System.Windows.Forms.TabPage BillsTab;
        private System.Windows.Forms.TabPage PayableTab;
        private System.Windows.Forms.TabPage FinancialTab;
        private System.Windows.Forms.TabPage RegisterCusto;
        private System.Windows.Forms.TabPage SettingTab;
        private System.Windows.Forms.TabPage HelpTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SalesOrderTab;
        private System.Windows.Forms.TabPage PickingTab;
        private System.Windows.Forms.TabPage PackingTab;
        private System.Windows.Forms.TabPage ShippingTab;
        private System.Windows.Forms.BindingSource sales_orderBindingSource;
        private inventory_controlDataSetTableAdapters.sales_orderTableAdapter sales_orderTableAdapter;
        private inventory_controlDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sales_orderBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sales_orderBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sales_orderDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private inventory_controlDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private inventory_controlDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.ComboBox idcustomerComboBox;
        private System.Windows.Forms.Button RegisterCustom;
        private System.Windows.Forms.Button Refresh_button;
        private inventory_controlDataSet inventory_controlDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.TextBox customerNameTextBox1;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox fax_noTextBox;
        private System.Windows.Forms.TextBox telNoTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button regProduct;
        private System.Windows.Forms.BindingSource fRProductBindingSource;
        private System.Windows.Forms.BindingSource sales_orderBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource1;
    }
}