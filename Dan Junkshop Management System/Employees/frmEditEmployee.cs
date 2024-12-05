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
        static EmployeeDetails Details;
        private bool firstNameChanged, lastNameChanged, middleNameChanged, genderChanged, birthdateChanged,
            contactChanged, addressChanged, usernameChanged, passwordChanged, statusChanged, needCancel, nameExist, accExist;
        private int empIDCount, accIDCount;
        public frmEditEmployee()
        {
            InitializeComponent();
            Details = new EmployeeDetails();
        }

        private void frmEditEmployee_Load(object sender, EventArgs e)
        {
            Queries.EmployeeQuery.GetEmployee(Details);

            cbPosition.Text = Details.Position;
            txtFirstName.Text = Details.FirstName;
            txtLastName.Text = Details.LastName;
            txtMiddleInitial.Text = Details.MiddleName;
            cbGender.Text = Details.Gender;
            dtBirthDate.Value = Convert.ToDateTime(Details.Birthdate);
            txtContact.Text = Details.Contact;
            txtAddress.Text = Details.Address;
            txtUsername.Text = Details.Username;
            txtPassword.Text = Details.Password;

            if (Details.Status == "Active")
            {
                btnSwitchStatus.Checked = true;
                lblStatus.Text = "Active";
            }
            else
            {
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
                    Details = null;
                    this.Close();
                }
            }
            else
            {
                // will proceed to cancel directly if there's no changes in employee details
                Details = null;
                this.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult updateEmp = MessageBox.Show("Are you sure you want to update details for this employee?",
                "Employee Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (updateEmp == DialogResult.Yes)
            {
                Details.FirstName = txtFirstName.Text;
                Details.LastName = txtLastName.Text;
                Details.MiddleName = txtMiddleInitial.Text;
                Details.Contact = txtContact.Text;
                Details.Birthdate = dtBirthDate.Value.ToString("yyyy-MM-dd");
                Details.Gender = cbGender.Text;
                Details.Username = txtUsername.Text;
                Details.Password = txtPassword.Text;
                Details.Address = txtAddress.Text;

                // will check if the employee details are complete
                // will check if both employee name and username was already existing
                if (firstNameChanged || lastNameChanged || middleNameChanged)
                {
                    nameExist = Queries.EmployeeQuery.EmployeeExistChecker(Details);
                }
                else
                {
                    nameExist = false;
                }

                if (usernameChanged)
                {
                    accExist = Queries.EmployeeQuery.AccExistChecker(Details);
                }
                else
                {
                    accExist = false;
                }

                // will proceed to updating employee details if both the employee name and username was not existing
                if (Queries.EmployeeQuery.EmployeeDetailsChecker(Details) && !nameExist && !accExist)
                {
                    Queries.EmployeeQuery.UpdateEmployee(Details);
                    Queries.EmployeeQuery.UpdateCredential(Details);

                    MessageBox.Show("Employee details has been successfully updated!", "Employee Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Details = null;
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

            if(dtBirthDate.Value.ToString("yyyy-MM-dd") == Details.Birthdate)
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
            if(txtFirstName.Text == Details.FirstName)
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
            if(txtLastName.Text == Details.LastName)
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
            if (txtContact.Text == Details.Contact)
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
            if (txtPassword.Text == Details.Password)
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
            if (lblStatus.Text == Details.Status)
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
            if (txtAddress.Text == Details.Address)
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
            if (cbGender.Text == Details.Gender)
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
            if (txtUsername.Text == Details.Username)
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
            if (txtMiddleInitial.Text == Details.MiddleName)
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
