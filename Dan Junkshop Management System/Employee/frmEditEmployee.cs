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
        private string birthdateHolder;

        public frmEditEmployee()
        {
            InitializeComponent();
        }

        private void frmEditEmployee_Load(object sender, EventArgs e)
        {
            ConnectionObjects.conn.Open();

            var localDate = DateTime.Now.ToString("yyyy-MM-dd");

            ConnectionObjects.cmd = new SqlCommand("SELECT E.FirstName, E.LastName, E.MiddleName, E.Gender, E.Birthdate, " +
                "E.Contact, E.Address, E.Status, C.Username, C.Password, E.Position FROM Employees E JOIN Credentials C " +
                "ON E.EmpID = C.EmpID WHERE E.EmpID = @empid", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@empid", PageObjects.employee.EmployeeID);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read())
            {
                // TODO: Finish edit employee functions
                txtFirstName.Text = ConnectionObjects.reader.GetString(0);
                txtLastName.Text = ConnectionObjects.reader.GetString(1);
                txtMiddleInitial.Text = ConnectionObjects.reader.GetString(2);
                cbGender.Text = ConnectionObjects.reader.GetString(3);
                birthdateHolder = ConnectionObjects.reader.GetDateTime(4).ToString("yyyy-MM-dd");
                txtContact.Text = ConnectionObjects.reader.GetString(5);
                txtAddress.Text = ConnectionObjects.reader.GetString(6);

                if(ConnectionObjects.reader.GetInt32(7) == 1)
                {
                    btnSwitchStatus.Checked = true;
                }
                else
                {
                    btnSwitchStatus.Checked = false;
                }

                txtUsername.Text = ConnectionObjects.reader.GetString(8);
                txtPassword.Text = ConnectionObjects.reader.GetString(9);
                cbPosition.Text = ConnectionObjects.reader.GetString(10);
            }
            ConnectionObjects.reader.Close();

            ConnectionObjects.cmd = new SqlCommand("SELECT DATEADD(year, -18, @birthdate)", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@birthdate", localDate);
            var legalAge = Convert.ToDateTime(ConnectionObjects.cmd.ExecuteScalar());
            ConnectionObjects.conn.Close();

            dtBirthDate.MaxDate = legalAge;
            dtBirthDate.Value = Convert.ToDateTime(birthdateHolder);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtBirthDate_ValueChanged(object sender, EventArgs e)
        {
            ConnectionObjects.conn.Open();

            var localDate = DateTime.Now.ToString("yyyy-MM-dd");

            // will get the total months of age based on the birth date
            ConnectionObjects.cmd = new SqlCommand("SELECT DATEDIFF(month, @birthDate, @currentDate)", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@birthDate", Convert.ToDateTime(dtBirthDate.Value.Date.ToString("yyyy-MM-dd")));
            ConnectionObjects.cmd.Parameters.AddWithValue("@currentDate", localDate);
            int yearDifferent = Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());
            yearDifferent /= 12;

            txtAge.Text = yearDifferent.ToString();

            ConnectionObjects.conn.Close();
        }
    }
}
