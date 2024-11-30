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
    public partial class frmAddingPartner : Form
    {
        private bool saveIndicator, alreadyExist;
        private int idCount;

        public frmAddingPartner()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDetails();
        }

        void ClearDetails()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleInitial.Clear();
            txtContact.Clear();
            txtAddress.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.WholeNumbersOnly(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConnectionObjects.conn.Open();

            if(txtFirstName.Text == "" ||  txtLastName.Text == "" || txtMiddleInitial.Text == "" 
                || txtContact.Text == "" || txtAddress.Text == "")
            {
                saveIndicator = false;
                MessageBox.Show("Partner details was incomplete!" +
                    "\nPlease complete the partner details to save", "Partner Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult saveDialog = MessageBox.Show("Do you want to save partner details?", "Partner Notification",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if(saveDialog == DialogResult.Yes)
                {
                    saveIndicator = true;
                }
            }

            if(saveIndicator)
            {
                txtFirstName.Text = txtFirstName.Text.Trim();
                txtLastName.Text = txtLastName.Text.Trim();
                txtMiddleInitial.Text = txtMiddleInitial.Text.Trim();

                ConnectionObjects.cmd = new SqlCommand("SELECT FirstName, LastName, MiddleName FROM Partners WHERE " +
                    "FirstName = @firstname AND LastName = @lastname AND MiddleName = @middlename", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text); 
                ConnectionObjects.cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@middlename", txtMiddleInitial.Text);
                ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

                if (ConnectionObjects.reader.Read())
                {
                    if($"{ConnectionObjects.reader.GetString(0).ToUpper()} {ConnectionObjects.reader.GetString(2).ToUpper()} " +
                        $"{ConnectionObjects.reader.GetString(1).ToUpper()}" == $"{txtFirstName.Text.ToUpper()} {txtMiddleInitial.Text.ToUpper()} {txtLastName.Text.ToUpper()}")
                    {
                        MessageBox.Show("Partner was already existing!", "Partner Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        alreadyExist = true;
                    }
                    else
                    {
                        alreadyExist = false;
                    }
                }
                ConnectionObjects.reader.Close();
            }

            if(saveIndicator && !alreadyExist)
            {
                saveIndicator = false;
                idCount = 1000;
                var localDate = DateTime.Now.ToString("yyyy-MM-dd");

                ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(PartnerID) FROM Partners", ConnectionObjects.conn);
                idCount += Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());

                ConnectionObjects.cmd = new SqlCommand("INSERT INTO Partners VALUES(@partnerid, @firstname, @lastname, @middlename, " +
                    "@contact, @address, @date, @status)", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@partnerid", $"PARTNER{idCount + 1}");
                ConnectionObjects.cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@middlename", txtMiddleInitial.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@date", localDate);
                ConnectionObjects.cmd.Parameters.AddWithValue("@status", 1);
                ConnectionObjects.cmd.ExecuteNonQuery();

                ClearDetails();
                MessageBox.Show("Partner details has been successfully saved!", "Partner Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ConnectionObjects.conn.Close();
        }
    }
}
