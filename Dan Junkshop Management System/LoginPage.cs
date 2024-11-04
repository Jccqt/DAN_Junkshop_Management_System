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

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ConnectionObjects.conn.Open(); // will open sql connection

            // will select username, password from credentials table and status from employees table
            ConnectionObjects.cmd = new SqlCommand("SELECT Username, Password, Status FROM " +
                "Credentials C JOIN Employees E ON C.EmpID = E.EmpID WHERE Status = 1", ConnectionObjects.conn);
            SqlDataReader reader = ConnectionObjects.cmd.ExecuteReader();

            // will read all values inside the selected attributes on two tables and will stop when all values has been read
            while (reader.Read())
            {
                username = reader.GetValue(0).ToString(); // will assign the username value on username string
                password = reader.GetValue(1).ToString(); // will assign the password value on password string

                if(txtUsername.Text.Equals(username) &&  txtPassword.Text.Equals(password))
                {
                    MessageBox.Show("Login Successfully!");
                    using(Homepage homepage = new Homepage())
                    {
                        homepage.ShowDialog(); // will show the homepage window
                        this.Hide(); // will hide the login window
                        ConnectionObjects.conn.Close(); // will close the sql connection once the user login was successful
                        break; // will also break the while loop
                    }
                }
                else
                {
                    // will prompt an error message if the credentials was invalid
                    MessageBox.Show("Invalid credentials! Please try again.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            // will close the sql connection
            ConnectionObjects.conn.Close();
        }
    }
}
