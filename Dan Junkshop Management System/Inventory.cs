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
    public partial class Inventory : UserControl
    {
        public Inventory()
        {
            InitializeComponent();

            // will set the size and position of the components
            this.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;

            // will set the default item type when the Inventory page was initilized
            cbType.Text = "Scraps";
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbType.Text == "Scraps")
            {
                btnSwitchStatus.Checked = true;
                lblTitle.Text = "Available Scraps";
            }
            else
            {
                btnSwitchStatus.Checked = true;
                lblTitle.Text = "Available Sellable Junks";
            }
        }

        private void btnSwitchStatus_CheckedChanged(object sender, EventArgs e)
        {
            if(cbType.Text == "Scraps" && !btnSwitchStatus.Checked)
            {
                lblTitle.Text = "Not Available Scraps";
            }
            else if (cbType.Text == "Scraps" && btnSwitchStatus.Checked)
            {
                lblTitle.Text = "Available Scraps";
            }
            else if(cbType.Text == "Sellable" && !btnSwitchStatus.Checked)
            {
                lblTitle.Text = "Not Available Sellable Junks";
            }
            else
            {
                lblTitle.Text = "Available Sellable Junks";
            }
        }
    }
}
