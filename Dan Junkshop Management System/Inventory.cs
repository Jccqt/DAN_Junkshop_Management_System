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

namespace Dan_Junkshop_Management_System
{
    public partial class Inventory : UserControl
    {
        public bool IsCollapsed;
        public Inventory()
        {
            InitializeComponent();

            // will set the size and position of the components
            this.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            
            // will remove the border of datagridview header
            gridViewInventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            cbType.Text = "Scraps";
            btnAddItem.Visible = true;

            showScrapItems();
        }

        void showScrapItems()
        {
            ConnectionObjects.dataTable = new DataTable();
            ConnectionObjects.dataTable.Columns.Add("Scrap name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Condition", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Price/qty", typeof(double));
            ConnectionObjects.dataTable.Columns.Add("Quantity", typeof(int));
            ConnectionObjects.dataTable.Columns.Add("Edit", typeof(Image));

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ScrapName, ScrapCondition, ScrapQuantity, ScrapPrice FROM ScrapItems WHERE Status = 1", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while(ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0),
                    ConnectionObjects.reader.GetString(1), ConnectionObjects.reader.GetInt32(2), ConnectionObjects.reader.GetValue(3), 
                    Dan_Junkshop_Management_System.Properties.Resources.icon_park_solid_edit);
            }
            gridViewInventory.DataSource = ConnectionObjects.dataTable;

            gridViewInventory.AutoResizeColumn(4, DataGridViewAutoSizeColumnMode.AllCells);

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }

        void showSellableItems()
        {
            ConnectionObjects.dataTable = new DataTable();
            ConnectionObjects.dataTable.Columns.Add("Sellable Item Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Class", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Price/kilo", typeof(double));
            ConnectionObjects.dataTable.Columns.Add("Quantity", typeof(double));
            ConnectionObjects.dataTable.Columns.Add("Edit", typeof(Image));

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableName, I.ItemClassName, I.ItemClassPrice, S.SellableQuantity " +
                "FROM SellableItems S JOIN ItemClass I ON S.ItemClassID = I.ItemClassID", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while (ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0), ConnectionObjects.reader.GetString(1),
                    ConnectionObjects.reader.GetValue(2), ConnectionObjects.reader.GetValue(3), Dan_Junkshop_Management_System.Properties.Resources.icon_park_solid_edit);
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
                showScrapItems();
            }
            else
            {
                btnSwitchStatus.Checked = true;
                lblTitle.Text = "Available Sellable Items";
                showSellableItems();
            }
        }

        private void btnSwitchStatus_CheckedChanged(object sender, EventArgs e)
        {
            if(cbType.Text == "Scraps" && !btnSwitchStatus.Checked)
            {
                btnAddItem.Visible = false;
                lblTitle.Text = "Not Available Scraps";
            }
            else if (cbType.Text == "Scraps" && btnSwitchStatus.Checked)
            {
                btnAddItem.Visible = true;
                lblTitle.Text = "Available Scraps";
            }
            else if(cbType.Text == "Sellable" && !btnSwitchStatus.Checked)
            {
                btnAddItem.Visible = false;
                lblTitle.Text = "Not Available Sellable Junks";
            }
            else
            {
                btnAddItem.Visible = true;
                lblTitle.Text = "Available Sellable Junks";
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
                        showScrapItems();
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
                    }
                }
            }

            GC.Collect();
        }

        
    }
}
