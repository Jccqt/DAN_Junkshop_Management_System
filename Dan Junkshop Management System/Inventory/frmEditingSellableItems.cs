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
    public partial class frmEditingSellableItems : Form
    {
        private string sellableName, className, price, scaleQuantity, status, newClassID;
        private bool sellableNameChanged, classNameChanged, scaleQuantityChanged, statusChanged;

        public frmEditingSellableItems()
        {
            InitializeComponent();
        }

        private void frmEditingSellableItems_Load(object sender, EventArgs e)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassName FROM ItemClass", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while (ConnectionObjects.reader.Read())
            {
                cbClass.Items.Add(ConnectionObjects.reader.GetString(0));
            }
            ConnectionObjects.reader.Close();

            ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableName, I.ItemClassname, I.ItemClassPlantPrice, I.ItemClassCapital, S.SellableQuantity, S.Status " +
                "FROM SellableItems S JOIN ItemClass I ON S.ItemClassID = I.ItemClassID WHERE S.SellableName = @sellablename", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@sellablename", PageObjects.inventory.ItemName);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read()){

                sellableName = ConnectionObjects.reader.GetString(0);
                className = ConnectionObjects.reader.GetString(1);
                price = (ConnectionObjects.reader.GetDecimal(2) + ConnectionObjects.reader.GetDecimal(3)).ToString();
                scaleQuantity = ConnectionObjects.reader.GetValue(4).ToString();

                if(ConnectionObjects.reader.GetInt32(5) == 1)
                {
                    btnSwitchStatus.Checked = true;
                    status = "Active";
                }
                else
                {
                    btnSwitchStatus.Checked = false;
                    status = "Inactive";
                }
            }

            txtSellableName.Text = sellableName;
            cbClass.Text = className;
            txtPrice.Text = price;
            txtScale.Text = scaleQuantity;
            lblStatus.Text = status;

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            btnUpdate.Visible = false;
            btnRestoreOriginal.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check Message Consistency: Save Edit for Sellable Item
            DialogResult saveEdit = MessageBox.Show("Are you sure you want to save changes?", "Sellable Item Notification",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (saveEdit == DialogResult.Yes)
            {
                ConnectionObjects.conn.Open();

                ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassID FROM ItemClass WHERE ItemClassName = @itemclassname", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassname", cbClass.Text);
                newClassID = ConnectionObjects.cmd.ExecuteScalar().ToString();

                ConnectionObjects.cmd = new SqlCommand("UPDATE SellableItems SET SellableName = @newsellablename, ItemClassID = @itemclassid, " +
                    "SellableQuantity = @sellablequantity, Status = @status WHERE SellableName = @currentsellablename", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@newsellablename", txtSellableName.Text.ToString().Trim());
                ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassid", newClassID);
                ConnectionObjects.cmd.Parameters.AddWithValue("@sellablequantity", Convert.ToDouble(txtScale.Text));
                ConnectionObjects.cmd.Parameters.AddWithValue("@currentsellablename", sellableName);

                if (lblStatus.Text == "Active")
                {
                    ConnectionObjects.cmd.Parameters.AddWithValue("@status", 1);
                }
                else
                {
                    ConnectionObjects.cmd.Parameters.AddWithValue("@status", 0);
                }
                ConnectionObjects.cmd.ExecuteNonQuery();

                // Check Message Consistency: Update Message for Edit Sellable Items
                MessageBox.Show("Sellable item details has been updated!", "Sellable Item Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConnectionObjects.conn.Close();
                this.Close();
            }
        }

        private void txtScale_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.FloatingNumbersOnly(sender, e);
        }

        private void btnRestoreOriginal_Click(object sender, EventArgs e)
        {
            // Check Message Consistency: Restore default for edit sellable items
            DialogResult restoreEdit = MessageBox.Show("Are you sure you want to restore original details?" +
                "\nAny unsaved changes will be lost!", "Sellable Item Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(restoreEdit == DialogResult.Yes)
            {
                txtSellableName.Text = sellableName;
                cbClass.Text = className;
                txtPrice.Text = price;
                txtScale.Text = scaleQuantity;
                lblStatus.Text = status;

                if(lblStatus.Text == "Active")
                {
                    btnSwitchStatus.Checked = true;
                }
                else
                {
                    btnSwitchStatus.Checked = false;
                }
            }
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
            if (txtScale.Text == scaleQuantity)
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
