using Dan_Junkshop_Management_System.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System
{
    public partial class frmAddingEmployee : Form
    {
        private int empIdCount, accIdCount;
        public frmAddingEmployee()
        {
            InitializeComponent();
            txtContact.MaxLength = 11;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult employeeExit = MessageBox.Show("Are you sure you want to cancel adding employee?"
                                            + "\nAny unsaved changes cannot be recovered!", "Employee Notification", 
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
            dtBirthDate.MaxDate = Queries.EmployeeQuery.GetLegalAge();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult clearEmployee = MessageBox.Show("Are you sure you want to clear employee details?",
                                                        "Employee Notification", MessageBoxButtons.YesNo, 
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
            txtMiddleName.Clear();
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
            DialogResult saveEmp = MessageBox.Show("Are you sure you want to save employee?", "Employee Notification",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(saveEmp == DialogResult.Yes)
            {
                txtFirstName.Text = txtFirstName.Text.Trim();
                txtLastName.Text = txtLastName.Text.Trim();
                txtMiddleName.Text = txtMiddleName.Text.Trim();
                txtUsername.Text = txtUsername.Text.Trim();
                txtPassword.Text = txtPassword.Text.Trim();

                EmployeeDetails details = new EmployeeDetails
                {
                    Position = cbPosition.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    MiddleName = txtMiddleName.Text,
                    Gender = cbGender.Text,
                    Birthdate = dtBirthDate.Value.ToString(),
                    Contact = txtContact.Text,
                    Address = txtAddress.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                };

                // will check if the employee details are complete
                // will check if both employee name and username was already existing
                // will proceed to saving employee details if both the employee name and username was not existing
                if (Queries.EmployeeQuery.EmployeeDetailsChecker(details) && !Queries.EmployeeQuery.EmployeeExistChecker(details) && !Queries.EmployeeQuery.AccExistChecker(details))
                {
                    var localDate = DateTime.Now.ToString("yyyy-MM-dd");
                    empIdCount = 1000;
                    accIdCount = 1000;

                    Queries.EmployeeQuery.GetEmpIDCount(details); // will get the current employee ID count
                    Queries.EmployeeQuery.GetAccIDCount(); // will get the current acc ID count
                    Queries.EmployeeQuery.AddEmployee(details);
                    Queries.EmployeeQuery.AddAccount(details);

                    ClearDetails();
                    details = null;
                    MessageBox.Show("Employee has been successfully added!", "Employee Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            
        }

        private void dtBirthDate_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = Queries.EmployeeQuery.GetAge(dtBirthDate.Value).ToString();
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
