namespace Inventory_control
{
    partial class CompanyRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyRegister));
            System.Windows.Forms.Label idCompanyDataLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label telephoneNoLabel;
            System.Windows.Forms.Label faxNoLabel;
            System.Windows.Forms.Label emailLabel;
            this.inventory_controlDataSet = new Inventory_control.inventory_controlDataSet();
            this.companydataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companydataTableAdapter = new Inventory_control.inventory_controlDataSetTableAdapters.companydataTableAdapter();
            this.tableAdapterManager = new Inventory_control.inventory_controlDataSetTableAdapters.TableAdapterManager();
            this.companydataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.companydataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idCompanyDataTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.telephoneNoTextBox = new System.Windows.Forms.TextBox();
            this.faxNoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.RegisterUser = new System.Windows.Forms.Button();
            idCompanyDataLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            telephoneNoLabel = new System.Windows.Forms.Label();
            faxNoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_controlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companydataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companydataBindingNavigator)).BeginInit();
            this.companydataBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventory_controlDataSet
            // 
            this.inventory_controlDataSet.DataSetName = "inventory_controlDataSet";
            this.inventory_controlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companydataBindingSource
            // 
            this.companydataBindingSource.DataMember = "companydata";
            this.companydataBindingSource.DataSource = this.inventory_controlDataSet;
            // 
            // companydataTableAdapter
            // 
            this.companydataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bill_receivedTableAdapter = null;
            this.tableAdapterManager.companydataTableAdapter = this.companydataTableAdapter;
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
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Inventory_control.inventory_controlDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // companydataBindingNavigator
            // 
            this.companydataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.companydataBindingNavigator.BindingSource = this.companydataBindingSource;
            this.companydataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.companydataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.companydataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.companydataBindingNavigatorSaveItem});
            this.companydataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.companydataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.companydataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.companydataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.companydataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.companydataBindingNavigator.Name = "companydataBindingNavigator";
            this.companydataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.companydataBindingNavigator.Size = new System.Drawing.Size(449, 25);
            this.companydataBindingNavigator.TabIndex = 0;
            this.companydataBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // companydataBindingNavigatorSaveItem
            // 
            this.companydataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.companydataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("companydataBindingNavigatorSaveItem.Image")));
            this.companydataBindingNavigatorSaveItem.Name = "companydataBindingNavigatorSaveItem";
            this.companydataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.companydataBindingNavigatorSaveItem.Text = "Save Data";
            this.companydataBindingNavigatorSaveItem.Click += new System.EventHandler(this.companydataBindingNavigatorSaveItem_Click);
            // 
            // idCompanyDataLabel
            // 
            idCompanyDataLabel.AutoSize = true;
            idCompanyDataLabel.Location = new System.Drawing.Point(48, 90);
            idCompanyDataLabel.Name = "idCompanyDataLabel";
            idCompanyDataLabel.Size = new System.Drawing.Size(91, 13);
            idCompanyDataLabel.TabIndex = 1;
            idCompanyDataLabel.Text = "id Company Data:";
            // 
            // idCompanyDataTextBox
            // 
            this.idCompanyDataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companydataBindingSource, "idCompanyData", true));
            this.idCompanyDataTextBox.Location = new System.Drawing.Point(145, 87);
            this.idCompanyDataTextBox.Name = "idCompanyDataTextBox";
            this.idCompanyDataTextBox.Size = new System.Drawing.Size(217, 20);
            this.idCompanyDataTextBox.TabIndex = 2;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(48, 116);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(85, 13);
            companyNameLabel.TabIndex = 3;
            companyNameLabel.Text = "Company Name:";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companydataBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(145, 113);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(217, 20);
            this.companyNameTextBox.TabIndex = 4;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(48, 142);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(47, 13);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companydataBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(145, 139);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(217, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // telephoneNoLabel
            // 
            telephoneNoLabel.AutoSize = true;
            telephoneNoLabel.Location = new System.Drawing.Point(48, 168);
            telephoneNoLabel.Name = "telephoneNoLabel";
            telephoneNoLabel.Size = new System.Drawing.Size(74, 13);
            telephoneNoLabel.TabIndex = 7;
            telephoneNoLabel.Text = "telephone No:";
            // 
            // telephoneNoTextBox
            // 
            this.telephoneNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companydataBindingSource, "telephoneNo", true));
            this.telephoneNoTextBox.Location = new System.Drawing.Point(145, 165);
            this.telephoneNoTextBox.Name = "telephoneNoTextBox";
            this.telephoneNoTextBox.Size = new System.Drawing.Size(217, 20);
            this.telephoneNoTextBox.TabIndex = 8;
            // 
            // faxNoLabel
            // 
            faxNoLabel.AutoSize = true;
            faxNoLabel.Location = new System.Drawing.Point(48, 194);
            faxNoLabel.Name = "faxNoLabel";
            faxNoLabel.Size = new System.Drawing.Size(44, 13);
            faxNoLabel.TabIndex = 9;
            faxNoLabel.Text = "Fax No:";
            // 
            // faxNoTextBox
            // 
            this.faxNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companydataBindingSource, "FaxNo", true));
            this.faxNoTextBox.Location = new System.Drawing.Point(145, 191);
            this.faxNoTextBox.Name = "faxNoTextBox";
            this.faxNoTextBox.Size = new System.Drawing.Size(217, 20);
            this.faxNoTextBox.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(48, 220);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companydataBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(145, 217);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(217, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // RegisterUser
            // 
            this.RegisterUser.Location = new System.Drawing.Point(145, 262);
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.Size = new System.Drawing.Size(100, 23);
            this.RegisterUser.TabIndex = 13;
            this.RegisterUser.Text = "Register User";
            this.RegisterUser.UseVisualStyleBackColor = true;
            this.RegisterUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // CompanyRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 322);
            this.Controls.Add(this.RegisterUser);
            this.Controls.Add(idCompanyDataLabel);
            this.Controls.Add(this.idCompanyDataTextBox);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(telephoneNoLabel);
            this.Controls.Add(this.telephoneNoTextBox);
            this.Controls.Add(faxNoLabel);
            this.Controls.Add(this.faxNoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.companydataBindingNavigator);
            this.Name = "CompanyRegister";
            this.Text = "CompanyRegister";
            this.Load += new System.EventHandler(this.CompanyRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventory_controlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companydataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companydataBindingNavigator)).EndInit();
            this.companydataBindingNavigator.ResumeLayout(false);
            this.companydataBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private inventory_controlDataSet inventory_controlDataSet;
        private System.Windows.Forms.BindingSource companydataBindingSource;
        private inventory_controlDataSetTableAdapters.companydataTableAdapter companydataTableAdapter;
        private inventory_controlDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator companydataBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton companydataBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idCompanyDataTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox telephoneNoTextBox;
        private System.Windows.Forms.TextBox faxNoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button RegisterUser;
    }
}