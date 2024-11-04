using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            Application.Run(new LoginPage());
        }
    }

    public class PageObjects
    {

    }

    public class ConnectionObjects
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\DAN_Junkshop_Management_System\Dan Junkshop Management System\DanDB.mdf"";Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connectionString);
        public static SqlCommand cmd;
    }
}
