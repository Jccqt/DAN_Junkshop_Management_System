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
using Dan_Junkshop_Management_System.Employees;
using System.Runtime.Remoting.Messaging;

namespace Dan_Junkshop_Management_System
{
    public partial class frmEditEmployee : Form
    {
        static EmployeeDetails EmployeeDetails;
        private bool firstNameChanged, lastNameChanged, middleNameChanged, genderChanged, birthdateChanged,
            contactChanged, addressChanged, usernameChanged, passwordChanged, statusChanged, needCancel, nameExist, accExist;
        private int empIDCount, accIDCount;
        private string firstName, lastName, middleName, gender, birthdate, contact, address, username, password, status;
        public frmEditEmployee()
        {
            InitializeComponent();
            EmployeeDetails = new EmployeeDetails();
        }

        private void frmEditEmployee_Load(object sender, EventArgs e)
        {
            Queries.EmployeeQuery.GetEmployee(EmployeeDetails);

            firstName = EmployeeDetails.FirstName;
            lastName = EmployeeDetails.LastName;
            middleName = EmployeeDetails.MiddleName;
            gender = EmployeeDetails.Gender;
            birthdate = EmployeeDetails.Birthdate;
            contact = EmployeeDetails.Contact;
            address = EmployeeDetails.Address;
            username = EmployeeDetails.Username;
            password = EmployeeDetails.Password;


            cbPosition.Text = EmployeeDetails.Position;
            txtFirstName.Text = EmployeeDetails.FirstName;
            txtLastName.Text = EmployeeDetails.LastName;
            txtMiddleInitial.Text = EmployeeDetails.MiddleName;
            cbGender.Text = EmployeeDetails.Gender;
            dtBirthDate.Value = Convert.ToDateTime(EmployeeDetails.Birthdate);
            txtContact.Text = EmployeeDetails.Contact;
            txtAddress.Text = EmployeeDetails.Address;
            txtUsername.Text = EmployeeDetails.Username;
            txtPassword.Text = EmployeeDetails.Password;

            if (EmployeeDetails.Status == "Active")
            {
                status = "Active";
                btnSwitchStatus.Checked = true;
                lblStatus.Text = "Active";
            }
            else
            {
                status = "Inactive";
                btnSwitchStatus.Checked = false;
                lblStatus.Text = "Inactive";
            }

            // will set the maximun date to 18 years old and above for dtBirthDate picker 
            // and will not show the dates that is below 18 years old
            dtBirthDate.MaxDate = Queries.EmployeeQuery.GetLegalAge();

            btnRestoreOriginal.Visible = false;
            btnUpdate.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (needCancel)
            {
                // will prompt a cancel warning if there's any changes in employee details
                DialogResult cancelEdit = MessageBox.Show("Are you sure you want to cancel editing this employee?" +
                "\nAny unsaved changes will be lost!", "Employee Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (cancelEdit == DialogResult.Yes)
                {
                    EmployeeDetails = null;
                    this.Close();
                }
            }
            else
            {
                // will proceed to cancel directly if there's no changes in employee details
                EmployeeDetails = null;
                this.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult updateEmp = MessageBox.Show("Are you sure you want to update details for this employee?",
                "Employee Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (updateEmp == DialogResult.Yes)
            {
                EmployeeDetails.FirstName = txtFirstName.Text;
                EmployeeDetails.LastName = txtLastName.Text;
                EmployeeDetails.MiddleName = txtMiddleInitial.Text;
                EmployeeDetails.Contact = txtContact.Text;
                EmployeeDetails.Birthdate = dtBirthDate.Value.ToString("yyyy-MM-dd");
                EmployeeDetails.Gender = cbGender.Text;
                EmployeeDetails.Username = txtUsername.Text;
                EmployeeDetails.Password = txtPassword.Text;
                EmployeeDetails.Address = txtAddress.Text;

                // will check if the employee details are complete
                // will check if both employee name and username was already existing
                if (firstNameChanged || lastNameChanged || middleNameChanged)
                {
                    nameExist = Queries.EmployeeQuery.EmployeeExistChecker(EmployeeDetails);
                }
                else
                {
                    nameExist = false;
                }

                if (usernameChanged)
                {
                    accExist = Queries.EmployeeQuery.AccExistChecker(EmployeeDetails);
                }
                else
                {
                    accExist = false;
                }

                // will proceed to updating employee details if both the employee name and username was not existing
                if (Queries.EmployeeQuery.EmployeeDetailsChecker(EmployeeDetails) && !nameExist && !accExist)
                {
                    Queries.EmployeeQuery.UpdateEmployee(EmployeeDetails);
                    Queries.EmployeeQuery.UpdateCredential(EmployeeDetails);

                    MessageBox.Show("Employee details has been successfully updated!", "Employee Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EmployeeDetails = null;
                    this.Close();
                }
            }
        }

        #region Functions to display button
        void displayButton()
        {
            if(firstNameChanged || lastNameChanged || middleNameChanged || genderChanged || birthdateChanged || 
                contactChanged || addressChanged || usernameChanged || passwordChanged || statusChanged)
            {
                needCancel = true;
                btnUpdate.Visible = true;
                btnRestoreOriginal.Visible = true;
            }
            else
            {
                needCancel = false;
                btnUpdate.Visible = false;
                btnRestoreOriginal.Visible = false;
            }
        }
        private void dtBirthDate_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = Queries.EmployeeQuery.GetAge(dtBirthDate.Value).ToString();

            if(dtBirthDate.Value.ToString("yyyy-MM-dd") == birthdate)
            {
                birthdateChanged = false;
            }
            else
            {
                birthdateChanged = true;
            }
            displayButton();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if(txtFirstName.Text == firstName)
            {
                firstNameChanged = false;
            }
            else
            {
                firstNameChanged = true;
            }
            displayButton();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if(txtLastName.Text == lastName)
            {
                lastNameChanged = false;
            }
            else
            {
                lastNameChanged = true;
            }
            displayButton();
        }
        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (txtContact.Text == contact)
            {
                contactChanged = false;
            }
            else
            {
                contactChanged = true;
            }
            displayButton();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == password)
            {
                passwordChanged = false;
            }
            else
            {
                passwordChanged = true;
            }
            displayButton();
        }

        private void btnSwitchStatus_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Active")
            {
                lblStatus.Text = "Inactive";
                btnSwitchStatus.Checked = false;
            }
            else
            {
                lblStatus.Text = "Active";
                btnSwitchStatus.Checked = true;
            }
            displayButton();
        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {
            if (lblStatus.Text == status)
            {
                statusChanged = false;
            }
            else
            {
                statusChanged = true;
            }
            displayButton();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == address)
            {
                addressChanged = false;
            }
            else
            {
                addressChanged = true;
            }
            displayButton();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.Text == gender)
            {
                genderChanged = false;
            }
            else
            {
                genderChanged = true;
            }
            displayButton();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == username)
            {
                usernameChanged = false;
            }
            else
            {
                usernameChanged = true;
            }
            displayButton();
        }

        private void txtMiddleInitial_TextChanged(object sender, EventArgs e)
        {
            if (txtMiddleInitial.Text == middleName)
            {
                middleNameChanged = false;
            }
            else
            {
                middleNameChanged = true;
            }
            displayButton();
        }
        #endregion
    }
}
