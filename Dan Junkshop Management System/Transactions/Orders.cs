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
    public partial class Orders : UserControl
    {
        int index;
        public Orders()
        {
            InitializeComponent();
        }

        private void txtScale_TextChanged(object sender, EventArgs e)
        {
            // will get the index of this user control from orders arraylist
            index = PageObjects.newBuyTransaction.OrderNamesArray.IndexOf(this.Tag);

           if(txtScale.Text != "")
            {   
                txtSubtotal.Text = PageObjects.newBuyTransaction.SubTotalArray[index].ToString();

                PageObjects.newBuyTransaction.TotalCost -= Convert.ToDecimal(txtSubtotal.Text); // will subtract the subtotal of this order to the total cost
                txtSubtotal.Text = (Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtScale.Text)).ToString(); // will set the new subtotal based on new scale
                PageObjects.newBuyTransaction.TotalCost += Convert.ToDecimal(txtSubtotal.Text); // will add the new subtotal to the total cost
                PageObjects.newBuyTransaction.TotalCostLabel.Text = PageObjects.newBuyTransaction.TotalCost.ToString(); // will change the total cost label
                
                // will remove and update the scale of this order on array list
                PageObjects.newBuyTransaction.ScaleArray.RemoveAt(index);
                PageObjects.newBuyTransaction.ScaleArray.Insert(index, Convert.ToDecimal(txtScale.Text));
            }
            else if (txtScale.Text == "" || txtScale.Text == "0.00")
            {
                // same process on first condition
                PageObjects.newBuyTransaction.TotalCost -= Convert.ToDecimal(txtSubtotal.Text);
                txtSubtotal.Text = "0.00"; // will set subtotal to 0.00
                PageObjects.newBuyTransaction.TotalCost += Convert.ToDecimal(txtSubtotal.Text);
                PageObjects.newBuyTransaction.TotalCostLabel.Text = PageObjects.newBuyTransaction.TotalCost.ToString();
                PageObjects.newBuyTransaction.ScaleArray.RemoveAt(index);
                PageObjects.newBuyTransaction.ScaleArray.Insert(index, 0);
            }

            PageObjects.newBuyTransaction.SubTotalArray.RemoveAt(index);
            PageObjects.newBuyTransaction.SubTotalArray.Insert(index, Convert.ToDecimal(txtSubtotal.Text));
        }

        private void txtScale_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.FloatingNumbersOnly(sender, e);
        }

        private void txtScale_Leave(object sender, EventArgs e)
        {
            if(txtScale.Text == "")
            {
                txtScale.Text = "0.00";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            PageObjects.newBuyTransaction.TotalCost -= Convert.ToDecimal(txtSubtotal.Text);
            PageObjects.newBuyTransaction.TotalCostLabel.Text = PageObjects.newBuyTransaction.TotalCost.ToString();
           
            index = PageObjects.newBuyTransaction.OrderNamesArray.IndexOf(this.Tag);
            PageObjects.newBuyTransaction.PriceArray.RemoveAt(index);
            PageObjects.newBuyTransaction.OriginalPriceArray.RemoveAt(index);
            PageObjects.newBuyTransaction.ScaleArray.RemoveAt(index);
            PageObjects.newBuyTransaction.SubTotalArray.RemoveAt(index);
            PageObjects.newBuyTransaction.OrderNamesArray.RemoveAt(index);

            PageObjects.newBuyTransaction.ItemCountLabel.Text = PageObjects.newBuyTransaction.OrderNamesArray.Count.ToString();
            this.Dispose();
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            index = PageObjects.newBuyTransaction.OrderNamesArray.IndexOf(this.Tag);

            if (txtPrice.Text == "")
            {
                txtPrice.Text = PageObjects.newBuyTransaction.OriginalPriceArray[index].ToString();
            }
        }
    }
}
