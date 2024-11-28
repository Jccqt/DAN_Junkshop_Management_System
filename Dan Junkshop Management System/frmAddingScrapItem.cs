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
using System.Collections;

namespace Dan_Junkshop_Management_System
{
    public partial class frmAddingScrapItem : Form
    {
        bool SaveIndicator;
        bool ItemAlreadyExisting;
        int ItemCount;
        public frmAddingScrapItem()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Check Message Consistency : Exit Add Dialog
            // will prompt a warning message if the user close the adding item window
            DialogResult exitAddItem = MessageBox.Show("Are you sure you want to cancel the adding of scrap item?"
                                        + "\nAny unsaved progress will be lost!", "Cancel add", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(exitAddItem == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Check Message Consistency : Clear information
            DialogResult clearItemInfo = MessageBox.Show("Are you sure you want to clear item information?", "Clear item information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(clearItemInfo == DialogResult.Yes)
            {
                clearScrapItemDetails();
            }
        }

        #region Input validation for textboxes
        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.CharactersOnly(sender, e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.WholeNumbersOnly(sender, e);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.FloatingNumbersOnly(sender, e);
        }
        #endregion
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ConnectionObjects.conn.Open();

            // will check if the scrap item details is complete
            if (txtItemName.Text == "" || cbCondition.SelectedIndex == -1 || txtQuantity.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Scrap tem details was incomplete!" +
                    "\nPlease complete the scrap item details.", "Scrap Item Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                SaveIndicator = false;
            }
            else
            {
                SaveIndicator = true;
            }

            if (SaveIndicator)
            {
                txtItemName.Text = txtItemName.Text.ToString().Trim();

                // will check if the scrap item with specified condition was already existing
                ConnectionObjects.cmd = new SqlCommand("SELECT ScrapName, ScrapCondition FROM ScrapItems WHERE ScrapName = @scrapname AND ScrapCondition = @scrapcondition", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@scrapname", txtItemName.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@scrapcondition", cbCondition.Text);
                ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

                if (ConnectionObjects.reader.Read())
                {
                    MessageBox.Show($"This scrap item with {cbCondition.Text} condition was already existing!",
                         "Scrap Item Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    ItemAlreadyExisting = true;
                }
                else
                {
                    ItemAlreadyExisting = false;
                }

                ConnectionObjects.reader.Close();

                if (SaveIndicator && !ItemAlreadyExisting)
                {
                    ItemCount = 1000;
                    SaveIndicator = false;

                    // will count the total number of scrap items
                    ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(ScrapID) FROM ScrapItems WHERE Status = 1", ConnectionObjects.conn);
                    ItemCount += Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());

                    // will insert the scrap item details to the database
                    ConnectionObjects.cmd = new SqlCommand("INSERT INTO ScrapItems VALUES(@scrapid, @scrapname, @scrapcondition, " +
                        "@scrapquantity, @scrapprice, @status)", ConnectionObjects.conn);
                    ConnectionObjects.cmd.Parameters.AddWithValue("@scrapid", $"SCRAP{ItemCount + 1}");
                    ConnectionObjects.cmd.Parameters.AddWithValue("@scrapname", txtItemName.Text);
                    ConnectionObjects.cmd.Parameters.AddWithValue("@scrapcondition", cbCondition.Text);
                    ConnectionObjects.cmd.Parameters.AddWithValue("@scrapquantity", Convert.ToInt32(txtQuantity.Text));
                    ConnectionObjects.cmd.Parameters.AddWithValue("@scrapprice", Convert.ToDouble(txtPrice.Text));
                    ConnectionObjects.cmd.Parameters.AddWithValue("@status", 1);
                    ConnectionObjects.cmd.ExecuteNonQuery();

                    clearScrapItemDetails();
                    MessageBox.Show("Scrap item has been successfully added!", "Scrap Item Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            ConnectionObjects.conn.Close();
        }

        private void frmAddingItem_Load(object sender, EventArgs e)
        {
            
        }

        void clearScrapItemDetails()
        {
            // will clear item information
            txtItemName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            cbCondition.SelectedIndex = -1;
        }

        private void cbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCondition.Text == "Good")
            {
                txtPrice.Enabled = true;
            }
            else
            {
                txtPrice.Enabled = false;
                txtPrice.Text = "0.00";
            }
        }
    }
}
