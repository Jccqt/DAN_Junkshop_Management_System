using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System
{
    public partial class LoginPage : Form
    {
        static string username, password;
        static bool IsLogin;
        private static LoginPage loginPage; // singleton object for LoginPage
        private LoginPage()
        {
            InitializeComponent();
        }

        // singleton method for loginpage
        public static LoginPage GetLoginInstance()
        {
            if(loginPage == null)
            {
                loginPage = new LoginPage();
            }

            return loginPage;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult exitDiag = MessageBox.Show("Are you sure you want to exit the application?",
                                                "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(exitDiag == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IsLogin = false;
            ConnectionObjects.conn.Open(); // will open sql connection

            // will select username, password from credentials table and status from employees table
            ConnectionObjects.cmd = new SqlCommand("SELECT Username, Password, Status FROM " +
                "Credentials C JOIN Employees E ON C.EmpID = E.EmpID WHERE Status = 1", ConnectionObjects.conn);
            SqlDataReader reader = ConnectionObjects.cmd.ExecuteReader();

            /* will read all values inside the selected attributes on two tables
             and will stop when all values has been read */
            while (reader.Read())
            {
                username = reader.GetValue(0).ToString(); // will assign the username value on username string
                password = reader.GetValue(1).ToString(); // will assign the password value on password string

                if(txtUsername.Text.Equals(username) &&  txtPassword.Text.Equals(password))
                {
                    MessageBox.Show("Login Successfully!", "Login Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomepageObjects.homepage = new Homepage();
                    this.ShowInTaskbar = false;
                    HomepageObjects.homepage.Show();
                    txtPassword.Clear();
                    this.Hide();
                    IsLogin = true;
                    break;

                }
                else
                {
                    IsLogin = false;
                }
            }

            if(IsLogin == false)
            {
                // will prompt an error message if the credentials was invalid
                MessageBox.Show("Invalid credentials! Please try again.", "Invalid Credentials",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            ConnectionObjects.conn.Close();
        }
    }
}
