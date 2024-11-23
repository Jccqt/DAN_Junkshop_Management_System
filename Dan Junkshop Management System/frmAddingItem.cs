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
    public partial class frmAddingItem : Form
    {
        public frmAddingItem()
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
                cbScaleType.SelectedIndex = -1;
                txtScale.Enabled = false;
            }
        }

        private void txtScale_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbScaleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbScaleType.Text == "Scallable")
            {
                txtScale.Enabled = true;
            }
            else
            {
                txtScale.Enabled = false;
                txtScale.Clear();
            }
        }

        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.CharactersOnly(sender, e);
        }
    }
}
