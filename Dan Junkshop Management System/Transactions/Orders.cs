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
            index = PageObjects.newBuyTransaction.OrderNamesArray.IndexOf(this.Tag);
            Console.WriteLine(this.Tag);

           if(txtScale.Text != "")
            {                
                PageObjects.newBuyTransaction.TotalCost -= Convert.ToDecimal(txtSubtotal.Text);
                txtSubtotal.Text = (Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtScale.Text)).ToString();
                PageObjects.newBuyTransaction.TotalCost += Convert.ToDecimal(txtSubtotal.Text);
                PageObjects.newBuyTransaction.TotalCostLabel.Text = PageObjects.newBuyTransaction.TotalCost.ToString();
                PageObjects.newBuyTransaction.ScaleArray.RemoveAt(index);
                PageObjects.newBuyTransaction.ScaleArray.Insert(index, Convert.ToDecimal(txtScale.Text));
            }
            else if (txtScale.Text == "" || txtScale.Text == "0.00")
            {
                PageObjects.newBuyTransaction.TotalCost -= Convert.ToDecimal(txtSubtotal.Text);
                txtSubtotal.Text = "0.00";
                PageObjects.newBuyTransaction.TotalCost += Convert.ToDecimal(txtSubtotal.Text);
                PageObjects.newBuyTransaction.TotalCostLabel.Text = PageObjects.newBuyTransaction.TotalCost.ToString();
                PageObjects.newBuyTransaction.ScaleArray.RemoveAt(index);
                PageObjects.newBuyTransaction.ScaleArray.Insert(index, 0);
            }
        }

        private void txtScale_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.FloatingNumbersOnly(sender, e);
        }

        private void txtScale_Leave(object sender, EventArgs e)
        {
            if(txtScale.Text == "")
            {
                txtScale.Text = "0.00";            }
        }
    }
}
