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

namespace Dan_Junkshop_Management_System
{
    public partial class frmAddingScrapItem : Form
    {
        static bool SaveIndicator;
        static bool AlreadyExisting;
        static int ItemCount;
        public frmAddingScrapItem()
        {
            InitializeComponent();
        }

        private void btnCancelAddItem_Click(object sender, EventArgs e)
        {
            // will prompt a warning message if the user close the adding item window
            DialogResult exitAddItem = MessageBox.Show("Are you sure you want to cancel the adding of an item?"
                                        + "\nAny unsaved progress will be lost!", "Cancel add", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(exitAddItem == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult clearItemInfo = MessageBox.Show("Are you sure you want to clear item information?", "Clear item information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(clearItemInfo == DialogResult.Yes)
            {
                // will clear item information
                txtItemName.Clear();
                txtPrice.Clear();
                txtScale.Clear();
                cbClass.SelectedIndex = -1;
            }
        }

        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.CharactersOnly(sender, e);
        }

        private void txtScale_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.FloatingNumbersOnly(sender, e);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if(txtItemName.Text == "" || txtPrice.Text == "" || cbClass.SelectedIndex == -1 || txtScale.Text == "")
            {
                MessageBox.Show("Please fill the empty details before saving", "Empty details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SaveIndicator = false;
            }
            else
            {
                DialogResult saveItem = MessageBox.Show("Do you want to save item details?", "Save item", MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if(saveItem == DialogResult.Yes)
                {
                    SaveIndicator = true;
                }
                else
                {
                    SaveIndicator = false;
                }
            }

            if(SaveIndicator)
            {
                // will check if the item name is already existing
                ConnectionObjects.conn.Open();

                ConnectionObjects.cmd = new SqlCommand("SELECT ItemName FROM Items WHERE ItemName = @itemname", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@itemname", txtItemName.Text);
                
                if(ConnectionObjects.cmd.ExecuteScalar().ToString() == "")
                {
                    AlreadyExisting = false;
                }
                else
                {
                    AlreadyExisting = true;
                }

                ConnectionObjects.conn.Close();
            }

            if(SaveIndicator && AlreadyExisting)
            {
                MessageBox.Show("Item was already existing!", "Item already exists",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else if(SaveIndicator && !AlreadyExisting)
            {
                ItemCount = 1000;
                SaveIndicator = false;

                ConnectionObjects.conn.Open();

                ConnectionObjects.cmd = new SqlCommand($"SELECT COUNT(ItemID) FROM Items WHERE ItemID LIKE '{cbClass.Text.Substring(0, cbClass.Text.IndexOf(" "))}'");
                ItemCount += Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());

                ConnectionObjects.cmd = new SqlCommand("SELECT ClassID FROM Class WHERE ClassName = @classname", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@classname", cbClass.Text);
                string classID = ConnectionObjects.cmd.ExecuteScalar().ToString();

                ConnectionObjects.cmd = new SqlCommand("INSERT INTO Items VALUES(@itemid, @itemname, @classid, @itemtype, @itemquantity, @status)", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@itemid", $"{cbClass.Text.Substring(0, cbClass.Text.IndexOf(" "))}{ItemCount + 1}");
                ConnectionObjects.cmd.Parameters.AddWithValue("@itemname", txtItemName.Text);
                ConnectionObjects.cmd.Parameters.AddWithValue("@classid", classID);
                ConnectionObjects.cmd.Parameters.AddWithValue("@itemtype", "Scraps");
                ConnectionObjects.cmd.Parameters.AddWithValue("@itemquantity", Convert.ToDouble(txtScale.Text));
                ConnectionObjects.cmd.Parameters.AddWithValue("@status", 1);
                ConnectionObjects.cmd.ExecuteNonQuery();

                ConnectionObjects.conn.Close();
            }

        }

        private void frmAddingItem_Load(object sender, EventArgs e)
        {
            cbClass.Items.Clear();

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ClassName FROM Class", ConnectionObjects.conn);
            SqlDataReader itemTypeReader = ConnectionObjects.cmd.ExecuteReader();

            while (itemTypeReader.Read())
            {
                cbClass.Items.Add(itemTypeReader.GetString(0));
            }

            itemTypeReader.Close();
            ConnectionObjects.conn.Close();
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Clear();

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT Price FROM Class WHERE ClassName = @classname", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@classname", cbClass.Text);
            txtPrice.Text = ConnectionObjects.cmd.ExecuteScalar().ToString();

            ConnectionObjects.conn.Close();
        }
    }
}
