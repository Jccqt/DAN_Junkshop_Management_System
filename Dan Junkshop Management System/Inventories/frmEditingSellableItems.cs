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
using Dan_Junkshop_Management_System.Inventories;

namespace Dan_Junkshop_Management_System
{
    public partial class frmEditingSellableItems : Form
    {
        SellableDetails ItemDetails;
        private string itemName, sellableName, className, status;
        private bool sellableNameChanged, classNameChanged, scaleQuantityChanged, statusChanged, sellableNameExist;
        private decimal scaleQuantity;

        public frmEditingSellableItems()
        {
            InitializeComponent();
            ItemDetails = new SellableDetails();
        }

        private void frmEditingSellableItems_Load(object sender, EventArgs e)
        {
            Queries.SellableQuery.GetItemToEdit(ItemDetails);
            Queries.SellableQuery.GetItemClasses(cbClass);

            sellableName = ItemDetails.SellableName;
            className = ItemDetails.ItemClassName;
            scaleQuantity = ItemDetails.SellableQuantity;

            txtSellableName.Text = ItemDetails.SellableName;
            cbClass.Text = ItemDetails.ItemClassName;
            txtPrice.Text = Queries.SellableQuery.GetItemPrice(ItemDetails.ItemClassName).ToString();
            txtScale.Text = ItemDetails.SellableQuantity.ToString();
            
            if(ItemDetails.Status == "Active")
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

            btnUpdate.Visible = false;
            btnRestoreOriginal.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult updateItem = MessageBox.Show("Are you sure you want to update this item?", "Sellable Item Notification", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(updateItem == DialogResult.Yes)
            {
                if(Convert.ToDecimal(txtScale.Text) == 0)
                {
                    txtScale.Text = "0.00";
                }

                ItemDetails.SellableName = txtSellableName.Text;
                ItemDetails.ItemClassName = cbClass.Text;
                ItemDetails.SellableQuantity = Convert.ToDecimal(txtScale.Text);
                ItemDetails.Status = lblStatus.Text;

                if (sellableNameChanged)
                {
                    sellableNameExist = Queries.SellableQuery.ItemExistChecker(ItemDetails.SellableName);
                }

                if(Queries.SellableQuery.ItemDetailsChecker(ItemDetails) && !sellableNameExist)
                {
                    Queries.SellableQuery.GetClassID(ItemDetails.ItemClassName);
                    Queries.SellableQuery.UpdateItem(ItemDetails);

                    MessageBox.Show("Sellable item details has been successfully updated!", "Sellable Items Notification", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void txtScale_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.FloatingNumbersOnly(sender, e);
        }

        private void btnRestoreOriginal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSwitchStatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Check Message Consistency: Cancel editing sellable item
            DialogResult cancelEdit = MessageBox.Show("Are you sure you want to cancel editing this sellable item?" +
                "\nAny unsaved progress will be lost!", "Sellable Item Notification", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(cancelEdit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #region Sellable item details changed
        void displayUpdateBtn()
        {
            if(sellableNameChanged || classNameChanged || scaleQuantityChanged || statusChanged)
            {
                btnUpdate.Visible = true;
                btnRestoreOriginal.Visible = true;
            }
            else
            {
                btnUpdate.Visible = false;
                btnRestoreOriginal.Visible = false;
            }
        }
        private void txtScale_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtScale.Text) == scaleQuantity)
            {
                scaleQuantityChanged = false;
            }
            else
            {
                scaleQuantityChanged = true;
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


        private void cbClass_TextChanged(object sender, EventArgs e)
        {
            if (cbClass.Text == className)
            {
                classNameChanged = false;
            }
            else
            {
                classNameChanged = true;
            }
            displayUpdateBtn();
        }

        private void txtSellableName_TextChanged(object sender, EventArgs e)
        {
            txtSellableName.Text = txtSellableName.Text.ToString().TrimStart();
            if (txtSellableName.Text == sellableName)
            {
                sellableNameChanged = false;
            }
            else
            {
                sellableNameChanged = true;
            }
            displayUpdateBtn();
        }
        #endregion
        private void btnSwitchStatus_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Active")
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
    }
}
