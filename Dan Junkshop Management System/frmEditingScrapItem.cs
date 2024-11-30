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
    public partial class frmEditingScrapItem : Form
    {
        private string scrapName, condition, price, quantity, status;
        private bool scrapNameChanged, conditionChanged, priceChanged, quantityChanged, statusChanged;

        public frmEditingScrapItem()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Check Message Consistency: Cancel editing scrap item
            DialogResult cancelEdit = MessageBox.Show("Are you sure you want to cancel editing this scrap item?" +
                "\nAny unsaved progress will be lost!", "Scrap Item Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(cancelEdit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSwitchStatus_Click(object sender, EventArgs e)
        {
            if(lblStatus.Text == "Active")
            {
                btnSwitchStatus.Checked = false;
                lblStatus.Text = "Inactive";
            }
            else
            {
                btnSwitchStatus.Checked = true;
                lblStatus.Text = "Active";
            }
        }

        #region Input Validation
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.FloatingNumbersOnly(sender, e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.WholeNumbersOnly(sender, e);
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check Message Consistency: Save Edit for Scrap Item
            DialogResult saveUpdate = MessageBox.Show("Are you sure you want to save changes?", "Scrap Item Notification",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(saveUpdate == DialogResult.Yes)
            {
                ConnectionObjects.conn.Open();

                ConnectionObjects.cmd = new SqlCommand("UPDATE ScrapItems SET ScrapName = @newscrapname, ScrapCondition = @scrapcondition, " +
                    "ScrapQuantity = @scrapquantity, ScrapPrice = @scrapprice, Status = @status WHERE ScrapName = @currentscrapname", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@newscrapname", txtScrapName.Text.ToString().Trim());
                ConnectionObjects.cmd.Parameters.AddWithValue("@scrapcondition", cbCondition.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@scrapquantity", Convert.ToInt32(txtQuantity.Text));
                ConnectionObjects.cmd.Parameters.AddWithValue("@scrapprice", Convert.ToDouble(txtPrice.Text));
                
                if(lblStatus.Text == "Active")
                {
                    ConnectionObjects.cmd.Parameters.AddWithValue("@status", 1);
                }
                else
                {
                    ConnectionObjects.cmd.Parameters.AddWithValue("@status", 0);
                }
                
                ConnectionObjects.cmd.Parameters.AddWithValue("@currentscrapname", PageObjects.inventory.ItemName);
                ConnectionObjects.cmd.ExecuteNonQuery();

                ConnectionObjects.conn.Close();

                MessageBox.Show("Scrap item details has been updated successfully!", "Scrap Item Notification");
                this.Close();
            }
        }

        private void frmEditingScrapItem_Load(object sender, EventArgs e)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ScrapName, ScrapCondition, ScrapQuantity, ScrapPrice, Status FROM ScrapItems " +
                "WHERE ScrapName = @scrapname", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@scrapname", PageObjects.inventory.ItemName);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read())
            {
                scrapName = ConnectionObjects.reader.GetString(0);
                condition = ConnectionObjects.reader.GetString(1);
                quantity = ConnectionObjects.reader.GetInt32(2).ToString();
                price = ConnectionObjects.reader.GetValue(3).ToString();

                

                if(ConnectionObjects.reader.GetInt32(4) == 1)
                {
                    btnSwitchStatus.Checked = true;
                    status = "Active";
                }
                else
                {
                    btnSwitchStatus.Checked = false;
                    status = "Inactive";
                }

                txtScrapName.Text = scrapName;
                cbCondition.Text = condition;
                txtPrice.Text = price;
                txtQuantity.Text = quantity;
                lblStatus.Text = status;
            }

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            btnUpdate.Visible = false;
        }

        #region scrap details changed
        void displayUpdateBtn()
        {
            if (scrapNameChanged || conditionChanged || priceChanged || quantityChanged || statusChanged)
            {
                btnUpdate.Visible = true;
            }
            else
            {
                btnUpdate.Visible = false;
            }
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.ToUpper() == quantity.ToUpper())
            {
                quantityChanged = false;
            }
            else
            {
                quantityChanged = true;
            }
            displayUpdateBtn();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text.ToUpper() == price.ToUpper())
            {
                priceChanged = false;
            }
            else
            {
                priceChanged = true;
            }
            displayUpdateBtn();
        }

        private void cbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCondition.Text == condition)
            {
                conditionChanged = false;
            }
            else
            {
                conditionChanged = true;
            }
            displayUpdateBtn();
        }

        private void txtScrapName_TextChanged(object sender, EventArgs e)
        {
            txtScrapName.Text = txtScrapName.Text.ToString().TrimStart();
            if (txtScrapName.Text == scrapName)
            {
                scrapNameChanged = false;
            }
            else
            {
                scrapNameChanged = true;
            }
            displayUpdateBtn();
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
            displayUpdateBtn();
        }
        #endregion
    }
}
