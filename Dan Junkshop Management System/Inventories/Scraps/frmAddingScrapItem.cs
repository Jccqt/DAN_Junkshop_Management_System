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
using Dan_Junkshop_Management_System.Inventories.Scraps;

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
            ScrapDetails scrapDetails = new ScrapDetails
            {
                ScrapName = txtScrapName.Text,
                ScrapCondition = cbCondition.Text,
                ScrapQuantity = Convert.ToInt32(txtQuantity.Text),
                ScrapPrice = Convert.ToDecimal(txtPrice.Text)
            };

            if(Queries.ScrapQuery.ItemDetailsChecker(scrapDetails) && !Queries.ScrapQuery.ItemExistChecker(scrapDetails))
            {
                var localDate = DateTime.Now.ToString("yyyy-MM-dd");

                Queries.ScrapQuery.GetItemIDCount();
                Queries.ScrapQuery.AddItem(scrapDetails);

                clearScrapItemDetails();
                MessageBox.Show("Scrap item has been successfully added!", "Scrap Item Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scrapDetails = null;
                this.Close();
            }
                  
        }

        private void frmAddingItem_Load(object sender, EventArgs e)
        {
            
        }

        void clearScrapItemDetails()
        {
            // will clear item information
            txtScrapName.Clear();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Check Message Consistency : Clear textboxes for adding scrap items
            DialogResult clearItemInfo = MessageBox.Show("Are you sure you want to clear item information?", "Clear item information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (clearItemInfo == DialogResult.Yes)
            {
                clearScrapItemDetails();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Check Message Consistency : Cancel adding scrap items
            // will prompt a warning message if the user close the adding item window
            DialogResult exitAddItem = MessageBox.Show("Are you sure you want to cancel the adding of scrap item?"
                                        + "\nAny unsaved progress will be lost!", "Cancel add", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (exitAddItem == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
