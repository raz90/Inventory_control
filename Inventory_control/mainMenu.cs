using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_control
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
            /*
            if(getUser.checkUsr=="admin")
            {
                SettingTab.Hide();
            
            }
             */


        }

        private void sales_orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sales_orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventory_controlDataSet1);

        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventory_controlDataSet1.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.inventory_controlDataSet1.product);
            // TODO: This line of code loads data into the 'inventory_controlDataSet1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.inventory_controlDataSet1.customer);
            // TODO: This line of code loads data into the 'inventory_controlDataSet1.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.inventory_controlDataSet1.product);
            // TODO: This line of code loads data into the 'inventory_controlDataSet1.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.inventory_controlDataSet1.product);
            // TODO: This line of code loads data into the 'inventory_controlDataSet1.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.inventory_controlDataSet1.product);
            // TODO: This line of code loads data into the 'inventory_controlDataSet1.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.inventory_controlDataSet1.product);
            // TODO: This line of code loads data into the 'inventory_controlDataSet1.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.inventory_controlDataSet1.product);
            // TODO: This line of code loads data into the 'inventory_controlDataSet1.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.inventory_controlDataSet1.product);
            // TODO: This line of code loads data into the 'inventory_controlDataSet1.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.inventory_controlDataSet1.product);
            // TODO: This line of code loads data into the 'inventory_controlDataSet1.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.inventory_controlDataSet1.product);
            // TODO: This line of code loads data into the 'inventory_controlDataSet1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.inventory_controlDataSet1.customer);
            // TODO: This line of code loads data into the 'inventory_controlDataSet1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.inventory_controlDataSet1.customer);

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterCustomer reg;
            reg = new RegisterCustomer();
            reg.Show();
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            SalesOrderTab.Refresh();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter.Fill(this.inventory_controlDataSet1.customer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ProductReg reg;
            reg = new ProductReg();
            reg.Show();
        }

       

    }
}
