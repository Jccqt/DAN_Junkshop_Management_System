using Dan_Junkshop_Management_System.Employees;
using Dan_Junkshop_Management_System.Inventories;
using Dan_Junkshop_Management_System.Transactions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(LoginPage.GetLoginInstance());
        }
    }

    public class Queries
    {
        public static EmployeeCRUD EmployeeQuery = new EmployeeCRUD();
        public static SellableCRUD SellableQuery = new SellableCRUD();
        public static TransactionCRUD TransactionQuery = new TransactionCRUD();
    }

    public class PageObjects
    {
        // Homepage Objects
        public static Homepage homepage;
        public static DashboardPanel dashboard;
        public static Sales_Reports sales_Reports;
        public static Inventory inventory;
        public static PriceConfiguration priceConfiguration;
        public static Employee employee;
        public static Delivery delivery;
        public static Partners partners;
        public static Transaction transaction;

        // Employee Objects
        public static frmEditEmployee editEmployee;
        public static frmAddingEmployee addEmployee;

        // Transaction Objects
        public static frmNewTransaction newBuyTransaction;

        // Inventory Objects
        public static frmAddingSellableItems addSellableItem;
        public static frmEditingSellableItems editSellableItem;

        // Partner Objects
        public static frmAddingPartner addPartner;

        // Price Config Objects
        public static frmAddItemPriceConfig addItemPrice;
    }

    public class ConnectionObjects
    {
        // SQL Objects
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + @"\DanDB.mdf;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connectionString);
        public static SqlCommand cmd;
        public static SqlDataReader reader;
        public static DataTable dataTable;
    }
    public class FormAnimation
    {

        public static void ShowFocus(Form form)
        {
            // will set and create a background to help show a focus for message dialogs
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Opacity = .80;
            form.BackColor = Color.Black;
            form.Size = new Size(1280, 800);

            if (PageObjects.homepage.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            else
            {
                form.WindowState = FormWindowState.Normal;
            }
            
            form.Owner = PageObjects.homepage;
            form.ShowInTaskbar = false;
            form.Show();
        }
    }

    public class InputValidation
    {
        public static void CharactersOnly(object sender, KeyPressEventArgs e)
        {
            // will only allow characters on textboxes
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void WholeNumbersOnly(object sender, KeyPressEventArgs e)
        {
            // will only allow whole numbers on textboxes
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void FloatingNumbersOnly(object sender, KeyPressEventArgs e)
        {
            // will only allow whole numbers and dot on textboxes
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // will only allow one dot on textboxes
            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
