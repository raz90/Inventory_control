using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Inventory_control
{
    /// <summary>
    /// Interaction logic for mainPage.xaml
    /// </summary>
    public partial class mainPage : Window
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Inventory_control.inventory_controlDataSet inventory_controlDataSet = ((Inventory_control.inventory_controlDataSet)(this.FindResource("inventory_controlDataSet")));
            // Load data into the table supplier. You can modify this code as needed.
            Inventory_control.inventory_controlDataSetTableAdapters.supplierTableAdapter inventory_controlDataSetsupplierTableAdapter = new Inventory_control.inventory_controlDataSetTableAdapters.supplierTableAdapter();
            inventory_controlDataSetsupplierTableAdapter.Fill(inventory_controlDataSet.supplier);
            System.Windows.Data.CollectionViewSource supplierViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("supplierViewSource")));
            supplierViewSource.View.MoveCurrentToFirst();
        }

        private void Supp_register_Click(object sender, RoutedEventArgs e)
        {
            RegisterSupplier suppReg;
            suppReg = new RegisterSupplier();
            suppReg.Show();
        }
    }
}
