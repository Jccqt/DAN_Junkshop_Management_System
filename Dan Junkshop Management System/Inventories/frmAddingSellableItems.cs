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
    public partial class frmAddingSellableItems : Form
    {
        int itemCount;
        string itemClass;

        public frmAddingSellableItems()
        {
            InitializeComponent();
        }

        private void frmAddingSellableItems_Load(object sender, EventArgs e)
        {
            Queries.SellableQuery.GetItemClasses(cbClass); // will load all ItemClass and insert it to cbClass collection
        }


        void clearSellableItemDetails()
        {
            // will clear sellable item details
            txtSellableName.Clear();
            txtPrice.Clear();
            cbClass.SelectedIndex = -1;
            txtScale.Clear();
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbClass.SelectedIndex == -1)
            {
                txtPrice.Text = "0.00";
            }
            else
            {
                txtPrice.Text = Queries.SellableQuery.GetItemPrice(cbClass.Text).ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Check Message Consistency: Cancel adding sellable items
            DialogResult exitAddItem = MessageBox.Show("Are you sure you want to cancel adding sellable item?" +
                "\nAny unsaved progress will be lost!", "Sellable Item Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (exitAddItem == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Check Message Consistency: Clear textboxes for adding sellable items
            DialogResult clearInfo = MessageBox.Show("Are you sure you want to clear item information?" +
                "\nAny unsaved progress will be lost!", "Sellable Item Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (clearInfo == DialogResult.Yes)
            {
                clearSellableItemDetails();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            SellableDetails details = new SellableDetails
            {
                SellableName = txtSellableName.Text,
                ItemClassName = cbClass.Text,
                SellableQuantity = Convert.ToDecimal(txtScale.Text)
            };
            
            if(Queries.SellableQuery.ItemDetailsChecker(details) && !Queries.SellableQuery.ItemExistChecker(cbClass.Text))
            {
                Queries.SellableQuery.GetItemIDCount();
                Queries.SellableQuery.GetClassID(details.ItemClassName);
                Queries.SellableQuery.AddItem(details);

                clearSellableItemDetails();

                MessageBox.Show("Sellable item has been successfully added!", "Sellable Item Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                details = null;
                this.Close();
            }
        }

        private void txtScale_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
