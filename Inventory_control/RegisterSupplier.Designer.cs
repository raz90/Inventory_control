namespace Inventory_control
{
    partial class RegisterSupplier
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
            System.Windows.Forms.Label idSupplierLabel;
            System.Windows.Forms.Label supplierNameLabel;
            System.Windows.Forms.Label supp_company_nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label tel_noLabel;
            System.Windows.Forms.Label fax_noLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterSupplier));
            this.supplierBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.supplierBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idSupplierTextBox = new System.Windows.Forms.TextBox();
            this.supplierNameTextBox = new System.Windows.Forms.TextBox();
            this.supp_company_nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.tel_noTextBox = new System.Windows.Forms.TextBox();
            this.fax_noTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.supplierDataGridView = new System.Windows.Forms.DataGridView();
            this.searchByIdToolStrip = new System.Windows.Forms.ToolStrip();
            this.paraIdSuppToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.paraIdSuppToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchByIdToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventory_controlDataSet = new Inventory_control.inventory_controlDataSet();
            this.supplierTableAdapter = new Inventory_control.inventory_controlDataSetTableAdapters.supplierTableAdapter();
            this.tableAdapterManager = new Inventory_control.inventory_controlDataSetTableAdapters.TableAdapterManager();
            idSupplierLabel = new System.Windows.Forms.Label();
            supplierNameLabel = new System.Windows.Forms.Label();
            supp_company_nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            tel_noLabel = new System.Windows.Forms.Label();
            fax_noLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingNavigator)).BeginInit();
            this.supplierBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
            this.searchByIdToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_controlDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idSupplierLabel
            // 
            idSupplierLabel.AutoSize = true;
            idSupplierLabel.Location = new System.Drawing.Point(48, 84);
            idSupplierLabel.Name = "idSupplierLabel";
            idSupplierLabel.Size = new System.Drawing.Size(59, 13);
            idSupplierLabel.TabIndex = 1;
            idSupplierLabel.Text = "id Supplier:";
            // 
            // supplierNameLabel
            // 
            supplierNameLabel.AutoSize = true;
            supplierNameLabel.Location = new System.Drawing.Point(48, 110);
            supplierNameLabel.Name = "supplierNameLabel";
            supplierNameLabel.Size = new System.Drawing.Size(77, 13);
            supplierNameLabel.TabIndex = 3;
            supplierNameLabel.Text = "supplier Name:";
            // 
            // supp_company_nameLabel
            // 
            supp_company_nameLabel.AutoSize = true;
            supp_company_nameLabel.Location = new System.Drawing.Point(48, 136);
            supp_company_nameLabel.Name = "supp_company_nameLabel";
            supp_company_nameLabel.Size = new System.Drawing.Size(110, 13);
            supp_company_nameLabel.TabIndex = 5;
            supp_company_nameLabel.Text = "Supp company name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(48, 162);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(47, 13);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "address:";
            // 
            // tel_noLabel
            // 
            tel_noLabel.AutoSize = true;
            tel_noLabel.Location = new System.Drawing.Point(48, 188);
            tel_noLabel.Name = "tel_noLabel";
            tel_noLabel.Size = new System.Drawing.Size(36, 13);
            tel_noLabel.TabIndex = 9;
            tel_noLabel.Text = "tel no:";
            // 
            // fax_noLabel
            // 
            fax_noLabel.AutoSize = true;
            fax_noLabel.Location = new System.Drawing.Point(48, 214);
            fax_noLabel.Name = "fax_noLabel";
            fax_noLabel.Size = new System.Drawing.Size(39, 13);
            fax_noLabel.TabIndex = 11;
            fax_noLabel.Text = "fax no:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(48, 240);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // supplierBindingNavigator
            // 
            this.supplierBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.supplierBindingNavigator.BindingSource = this.supplierBindingSource;
            this.supplierBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.supplierBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.supplierBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.supplierBindingNavigatorSaveItem});
            this.supplierBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.supplierBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.supplierBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.supplierBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.supplierBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.supplierBindingNavigator.Name = "supplierBindingNavigator";
            this.supplierBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.supplierBindingNavigator.Size = new System.Drawing.Size(872, 25);
            this.supplierBindingNavigator.TabIndex = 0;
            this.supplierBindingNavigator.Text = "bindingNavigator1";
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
            // supplierBindingNavigatorSaveItem
            // 
            this.supplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.supplierBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("supplierBindingNavigatorSaveItem.Image")));
            this.supplierBindingNavigatorSaveItem.Name = "supplierBindingNavigatorSaveItem";
            this.supplierBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.supplierBindingNavigatorSaveItem.Text = "Save Data";
            this.supplierBindingNavigatorSaveItem.Click += new System.EventHandler(this.supplierBindingNavigatorSaveItem_Click);
            // 
            // idSupplierTextBox
            // 
            this.idSupplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "idSupplier", true));
            this.idSupplierTextBox.Location = new System.Drawing.Point(164, 81);
            this.idSupplierTextBox.Name = "idSupplierTextBox";
            this.idSupplierTextBox.Size = new System.Drawing.Size(100, 20);
            this.idSupplierTextBox.TabIndex = 2;
            // 
            // supplierNameTextBox
            // 
            this.supplierNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplierName", true));
            this.supplierNameTextBox.Location = new System.Drawing.Point(164, 107);
            this.supplierNameTextBox.Name = "supplierNameTextBox";
            this.supplierNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.supplierNameTextBox.TabIndex = 4;
            // 
            // supp_company_nameTextBox
            // 
            this.supp_company_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Supp_company_name", true));
            this.supp_company_nameTextBox.Location = new System.Drawing.Point(164, 133);
            this.supp_company_nameTextBox.Name = "supp_company_nameTextBox";
            this.supp_company_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.supp_company_nameTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(164, 159);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // tel_noTextBox
            // 
            this.tel_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "tel_no", true));
            this.tel_noTextBox.Location = new System.Drawing.Point(164, 185);
            this.tel_noTextBox.Name = "tel_noTextBox";
            this.tel_noTextBox.Size = new System.Drawing.Size(100, 20);
            this.tel_noTextBox.TabIndex = 10;
            // 
            // fax_noTextBox
            // 
            this.fax_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "fax_no", true));
            this.fax_noTextBox.Location = new System.Drawing.Point(164, 211);
            this.fax_noTextBox.Name = "fax_noTextBox";
            this.fax_noTextBox.Size = new System.Drawing.Size(100, 20);
            this.fax_noTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(164, 237);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 14;
            // 
            // supplierDataGridView
            // 
            this.supplierDataGridView.AutoGenerateColumns = false;
            this.supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.supplierDataGridView.DataSource = this.supplierBindingSource;
            this.supplierDataGridView.Location = new System.Drawing.Point(292, 90);
            this.supplierDataGridView.Name = "supplierDataGridView";
            this.supplierDataGridView.Size = new System.Drawing.Size(557, 220);
            this.supplierDataGridView.TabIndex = 15;
            // 
            // searchByIdToolStrip
            // 
            this.searchByIdToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraIdSuppToolStripLabel,
            this.paraIdSuppToolStripTextBox,
            this.searchByIdToolStripButton});
            this.searchByIdToolStrip.Location = new System.Drawing.Point(0, 25);
            this.searchByIdToolStrip.Name = "searchByIdToolStrip";
            this.searchByIdToolStrip.Size = new System.Drawing.Size(872, 25);
            this.searchByIdToolStrip.TabIndex = 20;
            this.searchByIdToolStrip.Text = "searchByIdToolStrip";
            // 
            // paraIdSuppToolStripLabel
            // 
            this.paraIdSuppToolStripLabel.Name = "paraIdSuppToolStripLabel";
            this.paraIdSuppToolStripLabel.Size = new System.Drawing.Size(75, 22);
            this.paraIdSuppToolStripLabel.Text = "Search by ID ";
            // 
            // paraIdSuppToolStripTextBox
            // 
            this.paraIdSuppToolStripTextBox.Name = "paraIdSuppToolStripTextBox";
            this.paraIdSuppToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchByIdToolStripButton
            // 
            this.searchByIdToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchByIdToolStripButton.Name = "searchByIdToolStripButton";
            this.searchByIdToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.searchByIdToolStripButton.Text = "Search";
            this.searchByIdToolStripButton.Click += new System.EventHandler(this.searchByIdToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idSupplier";
            this.dataGridViewTextBoxColumn1.HeaderText = "idSupplier";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "supplierName";
            this.dataGridViewTextBoxColumn2.HeaderText = "supplierName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Supp_company_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Supp_company_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn4.HeaderText = "address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tel_no";
            this.dataGridViewTextBoxColumn5.HeaderText = "tel_no";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fax_no";
            this.dataGridViewTextBoxColumn6.HeaderText = "fax_no";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn7.HeaderText = "Email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.inventory_controlDataSet;
            // 
            // inventory_controlDataSet
            // 
            this.inventory_controlDataSet.DataSetName = "inventory_controlDataSet";
            this.inventory_controlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.sales_orderTableAdapter = null;
            this.tableAdapterManager.shippingTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager.UpdateOrder = Inventory_control.inventory_controlDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // RegisterSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 422);
            this.Controls.Add(this.searchByIdToolStrip);
            this.Controls.Add(this.supplierDataGridView);
            this.Controls.Add(idSupplierLabel);
            this.Controls.Add(this.idSupplierTextBox);
            this.Controls.Add(supplierNameLabel);
            this.Controls.Add(this.supplierNameTextBox);
            this.Controls.Add(supp_company_nameLabel);
            this.Controls.Add(this.supp_company_nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(tel_noLabel);
            this.Controls.Add(this.tel_noTextBox);
            this.Controls.Add(fax_noLabel);
            this.Controls.Add(this.fax_noTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.supplierBindingNavigator);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "idSupplier", true));
            this.Name = "RegisterSupplier";
            this.Text = "RegisterSupplier";
            this.Load += new System.EventHandler(this.RegisterSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingNavigator)).EndInit();
            this.supplierBindingNavigator.ResumeLayout(false);
            this.supplierBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
            this.searchByIdToolStrip.ResumeLayout(false);
            this.searchByIdToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_controlDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private inventory_controlDataSet inventory_controlDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private inventory_controlDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private inventory_controlDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator supplierBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton supplierBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idSupplierTextBox;
        private System.Windows.Forms.TextBox supplierNameTextBox;
        private System.Windows.Forms.TextBox supp_company_nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox tel_noTextBox;
        private System.Windows.Forms.TextBox fax_noTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DataGridView supplierDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStrip searchByIdToolStrip;
        private System.Windows.Forms.ToolStripLabel paraIdSuppToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox paraIdSuppToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchByIdToolStripButton;
    }
}