using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System
{
    public partial class frmAddNewEmployee : Form
    {

        static DialogResult saveEmployee;
        static int empIdCount;

        public frmAddNewEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult employeeExit = MessageBox.Show("Are you sure you want to cancel adding employee?"
                                            + "\nAny unsaved changes cannot be recovered!", "Cancel Adding Employee", 
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(employeeExit == DialogResult.Yes)
            {
                this.Close(); // will exit the page for adding employee
            }
        }

        private void frmAddNewEmployee_Load(object sender, EventArgs e)
        {
            // will set the maximun date to 18 years old and above for dtBirthDate picker 
            // and will not show the dates that is below 18 years old
            ConnectionObjects.conn.Open();

            var localDate = DateTime.Now.ToString("yyyy-MM-dd");

            ConnectionObjects.cmd = new SqlCommand("SELECT DATEADD(year, -18, @currentDate)", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@currentDate", localDate);
            var legalAge = Convert.ToDateTime(ConnectionObjects.cmd.ExecuteScalar());

            ConnectionObjects.conn.Close();

            dtBirthDate.MaxDate = legalAge;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult clearEmployee = MessageBox.Show("Are you sure you want to clear employee details?",
                                                        "Clear Details", MessageBoxButtons.YesNo, 
                                                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(clearEmployee == DialogResult.Yes)
            {
                ClearDetails(); // will clear employee details
            }
        }

        void ClearDetails()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleInitial.Clear();
            txtContact.Clear();
            cbPosition.SelectedIndex = -1;
            dtBirthDate.Value = dtBirthDate.MaxDate;
            cbGender.SelectedIndex = -1;
            txtUsername.Clear();
            txtPassword.Clear();
            txtAddress.Clear();
            txtAge.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals("") || txtLastName.Text.Equals("") || txtMiddleInitial.Text.Equals("") || txtContact.Text.Equals("") ||
               cbPosition.SelectedIndex == -1 || cbGender.SelectedIndex == -1 || txtUsername.Text.Equals("") || txtPassword.Text.Equals("") || txtAddress.Text.Equals("") || txtAge.Text.Equals(""))
            {
                MessageBox.Show("Please fill the empty details before saving", "Empty details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                saveEmployee = MessageBox.Show("Do you want to save employee details?", "Save Employee",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (saveEmployee == DialogResult.Yes)
            {
                var localDate = DateTime.Now.ToString("yyyy-MM-dd");
                empIdCount = 1000;

                ConnectionObjects.conn.Open();

                ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(EmpID) FROM Employees", ConnectionObjects.conn);
                empIdCount += Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());

                ConnectionObjects.cmd = new SqlCommand("INSERT INTO Employees VALUES (@EmpID, @Position, @FirstName, @LastName, " +
                                        "@MiddleName, @Age, @Contact, @Address, @HireDate, @Status)", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@EmpID", $"{cbPosition.Text.ToUpper()}{empIdCount + 1}");
                ConnectionObjects.cmd.Parameters.AddWithValue("@Position", cbPosition.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@MiddleName", txtMiddleInitial.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text));
                ConnectionObjects.cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@HireDate", localDate);
                ConnectionObjects.cmd.Parameters.AddWithValue("@Status", 1);
                ConnectionObjects.cmd.ExecuteNonQuery();

                ConnectionObjects.cmd = new SqlCommand("SELECT EmpID FROM Employees WHERE EmpID = @empID", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@empID", $"{cbPosition.Text.ToUpper()}{empIdCount + 1}");
                string employeeID = ConnectionObjects.cmd.ExecuteScalar().ToString();

                ConnectionObjects.cmd = new SqlCommand("INSERT INTO Credentials VALUES (@username, @password, @empID)", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@empID", $"{cbPosition.Text.ToUpper()}{empIdCount + 1}");
                ConnectionObjects.cmd.ExecuteNonQuery();

                ConnectionObjects.conn.Close();

                ClearDetails();
                MessageBox.Show("Employee has been successfully added!", "Employee Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomepageObjects.employee.Dispose();
                HomepageObjects.employee = new Employee();
                HomepageObjects.homepage.ContentsPanel.Controls.Add(HomepageObjects.employee);

                
            }
        }

        private void dtBirthDate_ValueChanged(object sender, EventArgs e)
        {
            var localDate = DateTime.Now.ToString("yyyy-MM-dd");

            ConnectionObjects.conn.Open();

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
