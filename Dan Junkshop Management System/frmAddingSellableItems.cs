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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
            cbClass.SelectedIndex = -1;
            txtPrice.Clear();
            txtScale.Clear();
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassPrice FROM ItemClass WHERE ItemClassName = @itemclassname", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassname", cbClass.Text);
            txtPrice.Text = ConnectionObjects.cmd.ExecuteScalar().ToString();

            ConnectionObjects.conn.Close();
        }
    }
}
