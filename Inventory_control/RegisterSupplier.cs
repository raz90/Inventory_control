using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventory_control
{
    public partial class RegisterSupplier : Form
    {
        public RegisterSupplier()
        {
            InitializeComponent();
        }

        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventory_controlDataSet);

        }

        private void RegisterSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventory_controlDataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.inventory_controlDataSet.supplier);

        }

      
        

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.supplierTableAdapter.Fill(this.inventory_controlDataSet.supplier);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchByIdToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.supplierTableAdapter.searchById(this.inventory_controlDataSet.supplier, paraIdSuppToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       
    }
}
