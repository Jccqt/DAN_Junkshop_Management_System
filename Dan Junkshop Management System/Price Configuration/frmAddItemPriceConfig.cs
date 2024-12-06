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
    public partial class frmAddItemPriceConfig : Form
    {
        bool saveIndicator, alreadyExisting;
        int idCount;
        public frmAddItemPriceConfig()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearDetails();
        }
        
        void clearDetails()
        {
            txtClassName.Clear();
            txtPlantPrice.Clear();
            txtCapital.Clear();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if(txtClassName.Text == "" || txtPlantPrice.Text == "" || txtCapital.Text == "" || txtScale.Text == "")
            {
                MessageBox.Show("Item class details is incomplete!" +
                    "\nPlease complete item class details to save", "Item Class Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                saveIndicator = false;
            }
            else
            {
                saveIndicator = true;
            }

            if (saveIndicator)
            {
                ConnectionObjects.conn.Open();

                ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassName FROM ItemClass WHERE ItemClassName = @itemclassname", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassname", txtClassName.Text);
                ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

                if(ConnectionObjects.reader.Read())
                {
                    MessageBox.Show("Item class was already existing!", "Item Class Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    alreadyExisting = true;
                }
                else
                {
                    alreadyExisting = false;
                }
                ConnectionObjects.reader.Close();
                ConnectionObjects.conn.Close();
            }

            if(saveIndicator && !alreadyExisting)
            {
                DialogResult saveItemClass = MessageBox.Show("Are you sure you want to save this item class?", "Item Class Notification",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(saveItemClass == DialogResult.Yes)
                {
                    idCount = 1000;
                    ConnectionObjects.conn.Open();

                    ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(ItemClassID) FROM ItemClass", ConnectionObjects.conn);
                    idCount += Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());

                    ConnectionObjects.cmd = new SqlCommand("INSERT INTO ItemClass VALUES(@itemclassid, @itemclassname, @itemclassplantprice, @itemclassprofit, @itemclassrequiredscale)", ConnectionObjects.conn);
                    ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassid", $"ITEMCLASS{idCount + 1}");
                    ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassname", txtClassName.Text);
                    ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassplantprice", Convert.ToDecimal(txtPlantPrice.Text));
                    ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassprofit", Convert.ToDecimal(txtCapital.Text));
                    ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassrequiredscale", Convert.ToDecimal(txtScale.Text));
                    ConnectionObjects.cmd.ExecuteNonQuery();

                    ConnectionObjects.conn.Close();

                    clearDetails();
                    MessageBox.Show("Item class has been successfully added!", "Item Class Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
