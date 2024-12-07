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
    public partial class frmEditPriceConfigItem : Form
    {
        private string itemClassName;
        private decimal plantPrice, profit;
        private bool classNameHasChanged, plantPriceHasChanged, profitHasChanged, saveIndicator, classNameExist;

        public frmEditPriceConfigItem()
        {
            InitializeComponent();
        }

        private void txtPlantPrice_TextChanged(object sender, EventArgs e)
        {
            if(txtPlantPrice.Text == plantPrice.ToString())
            {
                plantPriceHasChanged = false;
            }
            else
            {
                plantPriceHasChanged = true;
            }
            displayUpdateBtn();
        }

        private void txtPlantPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.FloatingNumbersOnly(sender, e);
        }

        private void txtProfit_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.FloatingNumbersOnly(sender, e);
        }

        private void txtProfit_TextChanged(object sender, EventArgs e)
        {
            if(txtProfit.Text == profit.ToString())
            {
                profitHasChanged = false;
            }
            else
            {
                profitHasChanged = true;
            }
            displayUpdateBtn();
        }

        private void txtProfit_Leave(object sender, EventArgs e)
        {
            if(txtProfit.Text == "")
            {
                txtProfit.Text = "0.00";
            }
        }

        private void txtPlantPrice_Leave(object sender, EventArgs e)
        {
            if(txtPlantPrice.Text == "")
            {
                txtPlantPrice.Text = "0.00";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(!classNameHasChanged && !plantPriceHasChanged && !profitHasChanged)
            {
                this.Close();
            }
            else
            {
                DialogResult cancelEdit = MessageBox.Show("Are you sure you want to cancel editing?" +
                    "\nAny unsaved progress will be lost!", "Item Class Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(cancelEdit == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
          

            if(txtItemClassname.Text == "" || Convert.ToDecimal(txtPlantPrice.Text) == 0 || Convert.ToDecimal(txtProfit.Text) == 0)
            {
                MessageBox.Show("Item class details was incomplete!" +
                    "\nPlease complete item class details to continue to update.", "Item Class Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                saveIndicator = false;
            }
            else
            {
                saveIndicator = true;
            }

            if (saveIndicator)
            {
                if (classNameHasChanged)
                {
                    txtItemClassname.Text = txtItemClassname.Text.Trim();

                    ConnectionObjects.conn.Open();

                    ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassName FROM ItemClass WHERE ItemClassName = @itemclassname", ConnectionObjects.conn);
                    ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassname", txtItemClassname.Text);
                    ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

                    if (ConnectionObjects.reader.Read())
                    {
                        MessageBox.Show("Item class was already existing!", "Item Class Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        classNameExist = true;
                    }
                    else
                    {
                        classNameExist = false;
                    }
                    ConnectionObjects.reader.Close();
                    ConnectionObjects.conn.Close();
                }
            }

            if(saveIndicator && !classNameExist)
            {
                DialogResult saveDialog = MessageBox.Show("Are you sure you want to update this item class?", "Item Class Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(saveDialog == DialogResult.Yes)
                {
                    ConnectionObjects.conn.Open();

                    ConnectionObjects.cmd = new SqlCommand("UPDATE ItemClass SET ItemClassName = @newitemclassname, ItemClassPlantPrice = @itemclassplantprice, " +
                        "ItemClassProfit = @itemclassprofit WHERE ItemClassname = @currentname", ConnectionObjects.conn);
                    ConnectionObjects.cmd.Parameters.AddWithValue("@currentname", itemClassName);
                    ConnectionObjects.cmd.Parameters.AddWithValue("@newitemclassname", txtItemClassname.Text);
                    ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassplantprice", Convert.ToDecimal(txtPlantPrice.Text));
                    ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassprofit", Convert.ToDecimal(txtProfit.Text));
                    ConnectionObjects.cmd.ExecuteNonQuery();

                    ConnectionObjects.conn.Close();

                    MessageBox.Show("Item class details has been successfully updated!", "Item Class Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
 
                
            }
        }

        private void txtItemClassname_TextChanged(object sender, EventArgs e)
        {
            if(txtItemClassname.Text == itemClassName)
            {
                classNameHasChanged = false;
            }
            else
            {
                classNameHasChanged = true;
            }
            displayUpdateBtn();
        }

        void displayUpdateBtn()
        {
            if(classNameHasChanged || plantPriceHasChanged || profitHasChanged)
            {
                btnUpdateItem.Visible = true;
            }
            else
            {
                btnUpdateItem.Visible = false;
            }
        }

        private void frmEditPriceConfigItem_Load(object sender, EventArgs e)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassName, ItemClassPlantPrice, ItemClassProfit FROM ItemClass " +
                "WHERE ItemClassName = @classname", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@classname", PageObjects.priceConfiguration.ItemClassName);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if(ConnectionObjects.reader.Read())
            {
                itemClassName = ConnectionObjects.reader.GetString(0);
                plantPrice = ConnectionObjects.reader.GetDecimal(1);
                profit = ConnectionObjects.reader.GetDecimal(2);

                txtItemClassname.Text = itemClassName;
                txtPlantPrice.Text = plantPrice.ToString();
                txtProfit.Text = profit.ToString();
            }

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            btnUpdateItem.Visible = false;
        }
    }
}
