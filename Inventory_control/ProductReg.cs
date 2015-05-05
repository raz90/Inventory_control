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
    public partial class ProductReg : Form
    {
        public ProductReg()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventory_controlDataSet);

        }

        private void ProductReg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventory_controlDataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.inventory_controlDataSet.supplier);
            // TODO: This line of code loads data into the 'inventory_controlDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.inventory_controlDataSet.product);

        }
    }
}
