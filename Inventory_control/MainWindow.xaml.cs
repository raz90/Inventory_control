﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;


namespace Inventory_control
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Login_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectSql = "Server=localhost;Port=3306;Database=inventory_control;uid=root;password=29554676";
                MySqlConnection conn = new MySqlConnection(connectSql);
                string pass= password_box.Password;

                //string querySelect = 
                MySqlCommand comd = new MySqlCommand("Select usertype from user where username ='" + this.username_box.Text + "'and password ='" +pass+ "';", conn);

                MySqlDataReader myReader;

                
                
                conn.Open();
                myReader = comd.ExecuteReader();
                int count = 0;

                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    username getUser = new username();
                    getUser.checkUsr =myReader["usertype"].ToString();
                    MessageBox.Show(getUser.checkUsr);
                    mainMenu page;
                    page = new mainMenu();

                    page.ShowDialog();

                    this.Close();

                }
                
                else
                {
                    MessageBox.Show("wrong username and password");
                    conn.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
