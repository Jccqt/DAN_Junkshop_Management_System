using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            Application.Run(new Homepage());
        }
    }

    public class HomepageObjects
    {
        // Homepage Objects
        public static Dashboard dashboard = new Dashboard();
        public static Sales_Reports sales_Reports = new Sales_Reports();
        public static Inventory inventory = new Inventory();
        public static PriceConfiguration priceConfiguration = new PriceConfiguration();
        public static NewTransaction newTransaction = new NewTransaction();
    }

    public class ConnectionObjects
    {
        // SQL Objects
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + @"\DanDB.mdf;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connectionString);
        public static SqlCommand cmd;
    }
}
