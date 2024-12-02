using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Dan_Junkshop_Management_System
{
    public partial class Inventory : UserControl
    {
        private bool isCollapsed, isSearching;
        private int rowIndex, status;
        private ArrayList itemNames = new ArrayList();

        public Inventory()
        {
            InitializeComponent();

            // will set the size and position of the components
            this.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            
            // will remove the border of datagridview header
            gridViewInventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        public string ItemName { get { return itemNames[rowIndex].ToString(); } }
        public ComboBox ItemTypes { get { return cbType; } }
        public ArrayList ItemNameArray { get { return itemNames; } }
        public DataGridView InventoryGrid { get { return gridViewInventory; } }
        public string SearchBox { get { return txtSearchBox.Text; } }

        private void Inventory_Load(object sender, EventArgs e)
        {
            cbType.Text = "Available Sellable Items";
            btnAddItem.Visible = true;

            Queries.SellableQuery.DisplayItems(1, isSearching);
            Queries.SellableQuery.GetItemClasses();
            cbType.Text = "All";
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
              btnSwitchStatus.Checked = true;
              lblTitle.Text = "Available Sellable Items";
              Queries.SellableQuery.DisplayItems(1, isSearching);
        }

        private void btnSwitchStatus_CheckedChanged(object sender, EventArgs e)
        {
            if(btnSwitchStatus.Checked)
            {
                btnAddItem.Visible = false;
                lblTitle.Text = "Not Available Sellable Items";
                Queries.SellableQuery.DisplayItems(0, isSearching);
            }
            else
            {
                btnAddItem.Visible = true;
                lblTitle.Text = "Available Sellable Items";
                Queries.SellableQuery.DisplayItems(1, isSearching);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using (PageObjects.addSellableItem = new frmAddingSellableItems())
            {
                using (Form form = new Form())
                {
                    FormAnimation.ShowFocus(form);
                    PageObjects.addSellableItem.Owner = form;
                    PageObjects.addSellableItem.ShowDialog();
                    form.Close();
                    Queries.SellableQuery.DisplayItems(1, isSearching);
                }
            }

            GC.Collect(); // optimization purposes
        }

        private void txtSearchBox_Leave(object sender, EventArgs e)
        {
            // will leave search mode when the user leave the search box and the search box is empty
            if(txtSearchBox.Text == "")
            {
                isSearching = false;
                txtSearchBox.Text = "Search item name";
                txtSearchBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtSearchBox_Enter(object sender, EventArgs e)
        {
            // will enter search mode when the user click the search box
            if (txtSearchBox.Text == "Search item name")
            {
                isSearching = true;
                txtSearchBox.Text = "";
                txtSearchBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void gridViewInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridViewInventory.CurrentCell.ColumnIndex == 4)
            {
                rowIndex = gridViewInventory.CurrentCell.RowIndex;

                using (PageObjects.editSellableItem = new frmEditingSellableItems())
                {
                    using (Form form = new Form())
                    {
                        FormAnimation.ShowFocus(form);
                        PageObjects.editSellableItem.Owner = form;
                        PageObjects.editSellableItem.ShowDialog();
                        form.Close();

                        if (btnSwitchStatus.Checked)
                        {
                            Queries.SellableQuery.DisplayItems(1, isSearching);
                        }
                        else
                        {
                            Queries.SellableQuery.DisplayItems(0, isSearching);
                        }
                    }
                }
            }
            GC.Collect(); // optimization purposes
        }

        private void gridViewInventory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                gridViewInventory.Cursor = Cursors.Hand;
            }
        }

        private void gridViewInventory_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                gridViewInventory.Cursor = Cursors.Default;
            }
        }


        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (cbType.Text == "Sellable" && !btnSwitchStatus.Checked)
            {
                Queries.SellableQuery.DisplayItems(0, isSearching);
            }
            else
            {
                Queries.SellableQuery.DisplayItems(1, isSearching);
            }
        }

    }
}
