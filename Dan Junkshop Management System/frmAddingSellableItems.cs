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
    public partial class frmAddingSellableItems : Form
    {
        bool saveIndicator, itemAlreadyExist;
        int itemCount;
        string itemClass;

        public frmAddingSellableItems()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Check Message Consistency: Exit Add Dialog
            DialogResult exitAddItem = MessageBox.Show("Are you sure you want to cancel adding sellable item?" +
                "\nAny unsaved progress will be lost!", "Sellable Item Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(exitAddItem == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmAddingSellableItems_Load(object sender, EventArgs e)
        {
            cbClass.Items.Clear();

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassName FROM ItemClass", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while(ConnectionObjects.reader.Read())
            {
                cbClass.Items.Add(ConnectionObjects.reader.GetString(0));
            }

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // TODO: Change btnClear to btnCancel
            DialogResult clearInfo = MessageBox.Show("Are you sure you want to clear item information?" +
                "\nAny unsaved progress will be lost!", "Sellable Item Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(clearInfo == DialogResult.Yes)
            {
                clearSellableItemDetails();
            }
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
                ConnectionObjects.conn.Open();

                ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassPrice FROM ItemClass WHERE ItemClassName = @itemclassname", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassname", cbClass.Text);
                txtPrice.Text = ConnectionObjects.cmd.ExecuteScalar().ToString();

                ConnectionObjects.conn.Close();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ConnectionObjects.conn.Open();

            if(txtSellableName.Text == "" || cbClass.SelectedIndex == -1 || txtPrice.Text == "" || txtScale.Text == "")
            {
                MessageBox.Show("Sellable item details was incomplete!" +
                    "\nPlease complete the sellable item details", "Sellable Item Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                saveIndicator = false;
            }
            else
            {
                saveIndicator = true;
            }

            if(saveIndicator)
            {
                txtSellableName.Text = txtSellableName.Text.ToString().Trim();

                ConnectionObjects.cmd = new SqlCommand("SELECT SellableName FROM SellableItems WHERE SellableName = @sellablename", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@sellablename", txtSellableName.Text);
                ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

                if (ConnectionObjects.reader.Read())
                {
                    MessageBox.Show("Sellable item was already existing!", "Sellable Item Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    itemAlreadyExist = true;
                }
                else
                {
                    itemAlreadyExist = false;
                }
                ConnectionObjects.reader.Close();
            }

            if(saveIndicator && !itemAlreadyExist)
            {
                itemCount = 1000;

                ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(SellableID) FROM SellableItems WHERE Status = 1", ConnectionObjects.conn);
                itemCount += Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());

                ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassID FROM ItemClass WHERE ItemClassName = @itemclassname", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassname", cbClass.Text);
                itemClass = ConnectionObjects.cmd.ExecuteScalar().ToString();

                ConnectionObjects.cmd = new SqlCommand("INSERT INTO SellableItems VALUES(@sellableid, @sellablename, @itemclassid, @sellablequantity, @status)", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@sellableid", $"SCRAP{itemCount + 1}");
                ConnectionObjects.cmd.Parameters.AddWithValue("@sellablename", txtSellableName.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassid", itemClass);
                ConnectionObjects.cmd.Parameters.AddWithValue("@sellablequantity", Convert.ToDouble(txtScale.Text));
                ConnectionObjects.cmd.Parameters.AddWithValue("@status", 1);
                ConnectionObjects.cmd.ExecuteNonQuery();

                clearSellableItemDetails();

                MessageBox.Show("Sellable item has been successfully added!", "Sellable Item Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ConnectionObjects.conn.Close();
        }
    }
}
