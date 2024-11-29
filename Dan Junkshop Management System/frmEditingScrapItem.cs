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
        private string scrapName, condition, price, quantity;
        bool scrapNameChanged, conditionChanged, priceChanged, quantityChanged;

        public frmEditingScrapItem()
        {
            InitializeComponent();
        }

        void displayUpdateBtn()
        {
            // TODO: Fix conditions on update button
            if(scrapNameChanged ||  conditionChanged || priceChanged || quantityChanged)
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
            if (txtQuantity.Text == quantity)
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
            if (txtPrice.Text == price)
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

        private void frmEditingScrapItem_Load(object sender, EventArgs e)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ScrapName, ScrapCondition, ScrapQuantity, ScrapPrice, Status FROM ScrapItems " +
                "WHERE ScrapName = @scrapname", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@scrapname", PageObjects.inventory.ScrapName);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read())
            {
                txtScrapName.Text = ConnectionObjects.reader.GetString(0);
                cbCondition.Text = ConnectionObjects.reader.GetString(1);
                txtPrice.Text = ConnectionObjects.reader.GetInt32(2).ToString();
                txtQuantity.Text = ConnectionObjects.reader.GetValue(3).ToString();

                scrapName = txtScrapName.Text;
                condition = cbCondition.Text;
                price = txtPrice.Text;
                quantity = txtQuantity.Text;

                if(ConnectionObjects.reader.GetInt32(4) == 1)
                {
                    btnSwitchStatus.Checked = true;
                    lblStatus.Text = "Active";
                }
                else
                {
                    btnSwitchStatus.Checked = false;
                    lblStatus.Text = "False";
                }
            }

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            btnUpdate.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
