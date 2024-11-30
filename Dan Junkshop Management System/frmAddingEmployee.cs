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
    public partial class frmAddingEmployee : Form
    {

        static DialogResult SaveEmployee;
        static int EmpIdCount, AccIdCount;
        static bool SaveIndicator, EmpAlreadyExisting, AccAlreadyExisting;
        public frmAddingEmployee()
        {
            InitializeComponent();
            txtContact.MaxLength = 11;
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
            ConnectionObjects.conn.Open();

            // will check if the employee details are complete
            if (txtFirstName.Text.Equals("") || txtLastName.Text.Equals("") || txtMiddleInitial.Text.Equals("") || txtContact.Text.Equals("") ||
               cbPosition.SelectedIndex == -1 || cbGender.SelectedIndex == -1 || txtUsername.Text.Equals("") || txtPassword.Text.Equals("") || txtAddress.Text.Equals("") || txtAge.Text.Equals(""))
            {
                SaveIndicator = false;
                MessageBox.Show("Employee details was incomplete!" +
                    "\nPlease complete the employee details to save", "Employee Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SaveEmployee = MessageBox.Show("Do you want to save employee details?", "Employee Notification",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if(SaveEmployee == DialogResult.Yes)
                {
                    SaveIndicator = true;
                }
            }

            // will check if both employee name and username was already existing
            if (SaveIndicator)
            {
                // will check if the employee name was already existing
                ConnectionObjects.cmd = new SqlCommand("SELECT FirstName, LastName, MiddleName FROM Employees" +
                    " WHERE FirstName = @firstname AND LastName = @lastname AND MiddleName = @middlename", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@middlename", txtMiddleInitial.Text);
                ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

                if (ConnectionObjects.reader.Read())
                {
                    if($"{ConnectionObjects.reader.GetString(0).ToUpper()} {ConnectionObjects.reader.GetString(2).ToUpper()}" +
                        $" {ConnectionObjects.reader.GetString(1).ToUpper()}" == $"{txtFirstName.Text.ToUpper()}" +
                        $" {txtMiddleInitial.Text.ToUpper()} {txtLastName.Text.ToUpper()}")
                    {
                        MessageBox.Show("Employee was already existing!", "Employee Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        EmpAlreadyExisting = true;
                    }
                }
                else
                {
                    EmpAlreadyExisting = false;
                }
                ConnectionObjects.reader.Close();

                // will check if the username was already existing
                ConnectionObjects.cmd = new SqlCommand("SELECT Username FROM Credentials WHERE Username = @username", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

                if (ConnectionObjects.reader.Read())
                {
                    MessageBox.Show("Employee username was already existing! Please use another username", "Employee Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    AccAlreadyExisting = true;
                }
                else
                {
                    AccAlreadyExisting = false;
                }

                ConnectionObjects.reader.Close();
            }

            // will proceed to saving employee details if both the employee name and username was not existing
            if (SaveIndicator && !EmpAlreadyExisting && !AccAlreadyExisting)
            {
                var localDate = DateTime.Now.ToString("yyyy-MM-dd");
                EmpIdCount = 1000;
                AccIdCount = 1000;
                SaveIndicator = false;

                ConnectionObjects.cmd = new SqlCommand($"SELECT COUNT(EmpID) FROM Employees WHERE Position = '{cbPosition.Text}' ", ConnectionObjects.conn);
                EmpIdCount += Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());

                ConnectionObjects.cmd = new SqlCommand("INSERT INTO Employees VALUES (@EmpID, @Position, @FirstName, @LastName, " +
                                        "@MiddleName, @Age, @Contact, @Address, @HireDate, @Status)", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@EmpID", $"{cbPosition.Text.ToUpper()}{EmpIdCount + 1}");
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

                ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(UserID) FROM Credentials", ConnectionObjects.conn);
                AccIdCount += Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());

                ConnectionObjects.cmd = new SqlCommand("INSERT INTO Credentials VALUES (@userid, @username, @password, @empID)", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@userid", $"USER{AccIdCount + 1}");
                ConnectionObjects.cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@empID", $"{cbPosition.Text.ToUpper()}{EmpIdCount + 1}");
                ConnectionObjects.cmd.ExecuteNonQuery();

                ClearDetails();
                MessageBox.Show("Employee has been successfully added!", "Employee Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            ConnectionObjects.conn.Close();
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

        #region textboxes input validation
        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.WholeNumbersOnly(sender, e);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.CharactersOnly(sender, e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.CharactersOnly(sender, e);
        }

        private void txtMiddleInitial_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.CharactersOnly(sender, e);
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.WholeNumbersOnly(sender, e);
        }

        #endregion
    }
}
