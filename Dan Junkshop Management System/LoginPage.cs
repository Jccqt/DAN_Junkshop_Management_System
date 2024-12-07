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
        private string username, password, empID;
        private bool IsLogin, IsPasswordVisible;

        private static LoginPage loginPage; // singleton object for LoginPage
        private LoginPage()
        {
            InitializeComponent();
            IsPasswordVisible = false;
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

        public string EmpID { get { return empID; } }

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

        private void LoginPage_Load(object sender, EventArgs e)
        {
            IsPasswordVisible = false;
            btnPasswordVisible.Image = Dan_Junkshop_Management_System.Properties.Resources.weui_eyes_off_filled;
            txtPassword.PasswordChar = '*';
        }

        private void btnPasswordVisible_Click(object sender, EventArgs e)
        {
            if (!IsPasswordVisible)
            {
                IsPasswordVisible = true;
                btnPasswordVisible.Image = Dan_Junkshop_Management_System.Properties.Resources.weui_eyes_on_filled;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                IsPasswordVisible = false;
                btnPasswordVisible.Image = Dan_Junkshop_Management_System.Properties.Resources.weui_eyes_off_filled;
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IsLogin = false;
            ConnectionObjects.conn.Open(); // will open sql connection

            // will select username, password from credentials table and status from employees table
            ConnectionObjects.cmd = new SqlCommand("SELECT C.Username, C.Password, C.EmpID, E.Position FROM " +
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
                    PageObjects.homepage = new Homepage();
                    PageObjects.homepage.EmpID = reader.GetString(2);
                    this.ShowInTaskbar = false;

                    if(reader.GetString(3) == "Cashier")
                    {
                        PageObjects.homepage.btnEmployee.Visible = false;
                        PageObjects.homepage.btnInventory.Visible = false;
                        PageObjects.homepage.btnPriceSetup.Visible = false;
                        PageObjects.homepage.btnPartners.Visible = false;
                        PageObjects.homepage.btnDelivery.Visible = false;
                        PageObjects.homepage.btnActivityLog.Visible = false;
                    }
                    else
                    {
                        PageObjects.homepage.btnEmployee.Visible = true;
                        PageObjects.homepage.btnInventory.Visible = true;
                        PageObjects.homepage.btnPriceSetup.Visible = true;
                        PageObjects.homepage.btnPartners.Visible = true;
                        PageObjects.homepage.btnDelivery.Visible = true;
                        PageObjects.homepage.btnActivityLog.Visible = true;
                    }

                    PageObjects.homepage.Show();
                    txtPassword.Clear();
                    reader.Close();
                    ConnectionObjects.conn.Close();
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
