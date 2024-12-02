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
        private int rowIndex;
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
        public ArrayList ItemNameArray { get { return itemNames; } }
        public DataGridView InventoryGrid { get { return gridViewInventory; } }
        public string SearchBox { get { return txtSearchBox.Text; } }

        private void Inventory_Load(object sender, EventArgs e)
        {
            cbType.Text = "Scraps";
            btnAddItem.Visible = true;

            Queries.ScrapQuery.DisplayItems(1, isSearching);
        }

        void showSellableItems(int status)
        {
            // 1 on status = Active/Available
            // 0 on status = Inactive/Not Available
            itemNames.Clear();

            ConnectionObjects.dataTable = new DataTable();
            ConnectionObjects.dataTable.Columns.Add("Sellable Item Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Class", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Price/kg", typeof(double));
            ConnectionObjects.dataTable.Columns.Add("Total scale (kg)", typeof(double));
            ConnectionObjects.dataTable.Columns.Add("Edit", typeof(Image));

            ConnectionObjects.conn.Open();

            if (isSearching)
            {
                // if search mode is on, sellable items will be displayed based on search box input
                ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableName, I.ItemClassName, I.ItemClassPlantPrice, I.ItemClassCapital, S.SellableQuantity " +
                "FROM SellableItems S JOIN ItemClass I ON S.ItemClassID = I.ItemClassID " +
                $"WHERE S.SellableName LIKE '%{txtSearchBox.Text}%' AND Status = @status", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@status", status);
            }
            else
            {
                // if search mode is off, all sellable items will be displayed
                ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableName, I.ItemClassName, I.ItemClassPlantPrice, I.ItemClassCapital, S.SellableQuantity " +
                "FROM SellableItems S JOIN ItemClass I ON S.ItemClassID = I.ItemClassID WHERE Status = @status", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@status", status);
            }
           
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while (ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0), ConnectionObjects.reader.GetString(1),
                    (ConnectionObjects.reader.GetDecimal(2) + ConnectionObjects.reader.GetDecimal(3)), ConnectionObjects.reader.GetValue(4), 
                    Dan_Junkshop_Management_System.Properties.Resources.icon_park_solid_edit);

                itemNames.Add(ConnectionObjects.reader.GetString(0));
                
            }

            gridViewInventory.DataSource = ConnectionObjects.dataTable;

            gridViewInventory.AutoResizeColumn(4, DataGridViewAutoSizeColumnMode.AllCells);

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbType.Text == "Scraps")
            {
                btnSwitchStatus.Checked = true;
                lblTitle.Text = "Available Scraps";
                Queries.ScrapQuery.DisplayItems(1, isSearching);
            }
            else
            {
                btnSwitchStatus.Checked = true;
                lblTitle.Text = "Available Sellable Items";
                showSellableItems(1);
            }
        }

        private void btnSwitchStatus_CheckedChanged(object sender, EventArgs e)
        {
            if(cbType.Text == "Scraps" && !btnSwitchStatus.Checked)
            {
                btnAddItem.Visible = false;
                lblTitle.Text = "Not Available Scraps";
                Queries.ScrapQuery.DisplayItems(0, isSearching);
            }
            else if (cbType.Text == "Scraps" && btnSwitchStatus.Checked)
            {
                btnAddItem.Visible = true;
                lblTitle.Text = "Available Scraps";
                Queries.ScrapQuery.DisplayItems(1, isSearching);
            }
            else if(cbType.Text == "Sellable" && !btnSwitchStatus.Checked)
            {
                btnAddItem.Visible = false;
                lblTitle.Text = "Not Available Sellable Junks";
                showSellableItems(0);
            }
            else
            {
                btnAddItem.Visible = true;
                lblTitle.Text = "Available Sellable Junks";
                showSellableItems(1);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if(cbType.Text == "Scraps")
            {
                using(PageObjects.addScrapItem = new frmAddingScrapItem())
                {
                    using(Form form = new Form())
                    {
                        FormAnimation.ShowFocus(form); ;
                        PageObjects.addScrapItem.Owner = form;
                        PageObjects.addScrapItem.ShowDialog();
                        form.Close();
                        Queries.ScrapQuery.DisplayItems(1, isSearching);
                    }
                }
            }
            else
            {
                using(PageObjects.addSellableItem = new frmAddingSellableItems())
                {
                    using(Form form = new Form())
                    {
                        FormAnimation.ShowFocus(form);
                        PageObjects.addSellableItem.Owner = form;
                        PageObjects.addSellableItem.ShowDialog();
                        form.Close();
                        showSellableItems(1);
                    }
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

                if(cbType.Text == "Scraps")
                {
                    using(PageObjects.editScrapItem = new frmEditingScrapItem())
                    {
                        using(Form form = new Form())
                        {
                            FormAnimation.ShowFocus(form);
                            PageObjects.editScrapItem.Owner = form;
                            PageObjects.editScrapItem.ShowDialog();
                            form.Close();

                            if (btnSwitchStatus.Checked)
                            {
                                Queries.ScrapQuery.DisplayItems(1, isSearching);
                            }
                            else
                            {
                                Queries.ScrapQuery.DisplayItems(0, isSearching);
                            }
                        }
                    }
                }
                else
                {
                    using(PageObjects.editSellableItem = new frmEditingSellableItems())
                    {
                        using(Form form = new Form())
                        {
                            FormAnimation.ShowFocus(form);
                            PageObjects.editSellableItem.Owner = form;
                            PageObjects.editSellableItem.ShowDialog();
                            form.Close();

                            if (btnSwitchStatus.Checked)
                            {
                                showSellableItems(1);
                            }
                            else
                            {
                                showSellableItems(0);
                            }
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
            if (cbType.Text == "Scraps" && !btnSwitchStatus.Checked)
            {
                Queries.ScrapQuery.DisplayItems(0, isSearching);
            }
            else if (cbType.Text == "Scraps" && btnSwitchStatus.Checked)
            {
                Queries.ScrapQuery.DisplayItems(1, isSearching);
            }
            else if (cbType.Text == "Sellable" && !btnSwitchStatus.Checked)
            {
                showSellableItems(0);
            }
            else
            {
                showSellableItems(1);
            }
        }

    }
}
