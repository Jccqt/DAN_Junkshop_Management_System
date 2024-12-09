using Dan_Junkshop_Management_System.PickupItems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System
{
    public partial class frmAddPickUp : Form
    {
        public frmAddPickUp()
        {
            InitializeComponent();
        }

        private void frmAddPickUp_Load(object sender, EventArgs e)
        {
            lblPickupID.Text = $"PICKUP{Queries.PickupQuery.GetPickupIDCount()}";
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm tt");
            Queries.SellableQuery.GetItemList(cbSellableItems);
            Queries.PartnerQuery.GetPartnerList(cbPartners);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSellableItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtScaleQuantity.Text = "0.00";
            txtTotalOwned.Text = Queries.SellableQuery.GetTotalOwnedQuantity(cbSellableItems.Text).ToString();
            txtItemClass.Text = Queries.ItemClassQuery.GetClassName(cbSellableItems.Text).ToString();
            txtPlantPrice.Text = Queries.ItemClassQuery.GetPlantPrice(txtItemClass.Text).ToString();

            if (txtScaleQuantity.Text != "")
            {
                txtTotalAmount.Text = (Convert.ToDecimal(txtPlantPrice.Text) * Convert.ToDecimal(txtScaleQuantity.Text)).ToString();
            }
            else
            {
                txtTotalAmount.Text = "0.00";
            }
        }

        private void txtScaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if(cbSellableItems.Text != "" && txtScaleQuantity.Text != "")
            {
                txtTotalAmount.Text = (Convert.ToDecimal(txtPlantPrice.Text) * Convert.ToDecimal(txtScaleQuantity.Text)).ToString();
            }
            else
            {
                txtTotalAmount.Text = "0.00";
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if(txtScaleQuantity.Text == "")
            {
                txtScaleQuantity.Text = "0.00";
            }

            if(cbSellableItems.SelectedIndex == -1 || Convert.ToDecimal(txtScaleQuantity.Text) == 0 || cbPartners.SelectedIndex == -1)
            {
                MessageBox.Show("Pickup details was incomplete!" +
                    "\nPlease complete the pickup details to process", "Pickup Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToDecimal(txtTotalOwned.Text) < Convert.ToDecimal(txtScaleQuantity.Text))
            {
                MessageBox.Show("Cannot exceed the total owned scale quantity!", "Pickup Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PickupDetails pickupDetails = new PickupDetails
                {
                    PickupID = lblPickupID.Text,
                    SellableID = Queries.SellableQuery.GetSellableID(cbSellableItems.Text),
                    PartnerID = Queries.PartnerQuery.GetPartnerID(cbPartners.Text),
                    ScaleQuantity = Convert.ToDecimal(txtScaleQuantity.Text),
                    Amount = Convert.ToDecimal(txtTotalAmount.Text),
                };

                Queries.PickupQuery.ProcessPickup(pickupDetails);
                Queries.PickupQuery.DeductToInventory(pickupDetails);

                MessageBox.Show("Pickup has been successfully processed!", "Pickup Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void txtScaleQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.FloatingNumbersOnly(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult cancelPickup = MessageBox.Show("Are you sure you want to cancel the pickup?", "Pickup Notification",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(cancelPickup == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
