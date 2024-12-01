using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dan_Junkshop_Management_System
{
    public partial class frmEditEmployee : Form
    {
        public frmEditEmployee()
        {
            InitializeComponent();
        }

        private void frmEditEmployee_Load(object sender, EventArgs e)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT FirstName, LastName, MiddleName, Birthdate, Contact, Address, Status FROM " +
                "Employees WHERE EmpID = @empid", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@empid", PageObjects.employee.EmployeeID);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read())
            {
                // TODO: Finish edit employee functions
                txtFirstName.Text = ConnectionObjects.reader.GetString(0);
                txtLastName.Text = ConnectionObjects.reader.GetString(1);
                txtMiddleInitial.Text = ConnectionObjects.reader.GetString(2);
                dtBirthDate.Value = Convert.ToDateTime(ConnectionObjects.reader.GetDateTime(3).ToString("yyyy-MM-dd"));
                txtContact.Text = ConnectionObjects.reader.GetString(4);
                txtAddress.Text = ConnectionObjects.reader.GetString(5);

                if(ConnectionObjects.reader.GetInt32(6) == 1)
                {
                    btnSwitchStatus.Checked = true;
                }
                else
                {
                    btnSwitchStatus.Checked = false;
                }
            }
            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
