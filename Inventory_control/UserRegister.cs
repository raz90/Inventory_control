﻿using System;
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
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventory_controlDataSet);

        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventory_controlDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.inventory_controlDataSet.user);

        }
    }
}
