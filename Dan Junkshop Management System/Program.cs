using System;
using System.Collections.Generic;
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

    public class HomepageObjects
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
        public static NewTransaction newTransaction;
    }

    public class ConnectionObjects
    {
        // SQL Objects
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + @"\DanDB.mdf;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connectionString);
        public static SqlCommand cmd;
        public static SqlDataReader reader;
    }
    public class FormAnimation
    {
        public static Form formBackground;

        public static void ShowFocus()
        {
            formBackground = new Form();

            // will set a background to show a focus for message dialogs
            formBackground.StartPosition = FormStartPosition.CenterScreen;
            formBackground.FormBorderStyle = FormBorderStyle.None;
            formBackground.Opacity = .80;
            formBackground.BackColor = Color.Black;

            if(HomepageObjects.homepage.WindowState == FormWindowState.Maximized)
            {
                formBackground.WindowState = FormWindowState.Maximized;
            }
            else
            {
                formBackground.WindowState = FormWindowState.Normal;
            }
            
            formBackground.Size = new Size(1280, 800);
            formBackground.ShowInTaskbar = false;
            formBackground.TopMost = true;
            formBackground.Show();
        }
    }
}
