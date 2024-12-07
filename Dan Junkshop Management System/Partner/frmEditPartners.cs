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
    public partial class frmEditPartners : Form
    {
        private string firstName, middleName, lastName, contact, address, status;

        private bool firstnameChanged, middlenameChanged, lastnameChanged, contactChanged, addressChanged, statusChanged;

        void DisplayUpdateButton()
        {
            if(firstnameChanged || middlenameChanged || lastnameChanged || contactChanged || addressChanged || statusChanged)
            {
                btnUpdate.Visible = true;
            }
            else
            {
                btnUpdate.Visible = false;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if(txtLastName.Text == lastName)
            {
                lastnameChanged = false;
            }
            else
            {
                lastnameChanged = true;
            }
            DisplayUpdateButton();
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            if(txtMiddleName.Text == middleName)
            {
                middlenameChanged = false;
            }
            else
            {
                middlenameChanged = true;
            }
            DisplayUpdateButton();
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if(txtContact.Text == contact)
            {
                contactChanged = false;
            }
            else
            {
                contactChanged = true;
            }
            DisplayUpdateButton();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if(txtAddress.Text == address)
            {
                addressChanged = false;
            }
            else
            {
                addressChanged = true;
            }
            DisplayUpdateButton();
        }

        private void btnSwitchStatus_Click(object sender, EventArgs e)
        {
            if(lblStatus.Text == "Active")
            {
                lblStatus.Text = "Inactive";
                statusChanged = false;
            }
            else
            {
                lblStatus.Text = "Active";
                statusChanged = true;
            }
            DisplayUpdateButton();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if(txtFirstName.Text == firstName)
            {
                firstnameChanged = false;
            }
            else
            {
                firstnameChanged = true;
            }
            DisplayUpdateButton();
        }

        public frmEditPartners()
        {
            InitializeComponent();
        }

        private void frmEditPartners_Load(object sender, EventArgs e)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT FirstName, LastName, MiddleName, Contact, Address, Status FROM Partners " +
                "WHERE PartnerID = @partnerid", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@partnerid", PageObjects.partners.PartnerID);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read())
            {
                firstName = ConnectionObjects.reader.GetString(0);
                lastName = ConnectionObjects.reader.GetString(1);
                middleName = ConnectionObjects.reader.GetString(2);
                contact = ConnectionObjects.reader.GetString(3);
                address = ConnectionObjects.reader.GetString(4);

                if(ConnectionObjects.reader.GetInt32(5) == 1)
                {
                    status = "Active";
                    lblStatus.Text = "Active";
                    btnSwitchStatus.Checked = true;

                }
                else
                {
                    status = "Inactive";
                    lblStatus.Text = "Inactive";
                    btnSwitchStatus.Checked = false;
                }

                txtFirstName.Text = firstName;
                txtLastName.Text = lastName;
                txtMiddleName.Text = middleName;
                txtContact.Text = contact;
                txtAddress.Text = address;
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
