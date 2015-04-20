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
    public partial class CompanyRegister : Form
    {
        public CompanyRegister()
        {
            InitializeComponent();
        }

        private void companydataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companydataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventory_controlDataSet);

        }

        private void CompanyRegister_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'inventory_controlDataSet.companydata' table. You can move, or remove it, as needed.
            this.companydataTableAdapter.Fill(this.inventory_controlDataSet.companydata);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRegister reg;
            reg = new UserRegister();
            reg.Show();
        }
    }
}
