using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Dan_Junkshop_Management_System.Inventories
{
    public class SellableCRUD
    {
        private decimal itemPrice;
        private bool detailsComplete, itemExist;
        private int idCount;
        private string classID;
        public void DisplayItems(int status, bool isSearching)
        {
            PageObjects.inventory.ItemNameArray.Clear();

            ConnectionObjects.dataTable = new DataTable();
            ConnectionObjects.dataTable.Columns.Add("ID", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Sellable Item Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Class", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Price/kg", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Total scale (kg)", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Plant price (Total)", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Edit", typeof(Image));

            ConnectionObjects.conn.Open();

            if (isSearching)
            {
                // if search mode is on, sellable items will be displayed based on search box input
                ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableID, S.SellableName, I.ItemClassName, I.ItemClassPlantPrice, S.SellableQuantity " +
                "FROM SellableItems S JOIN ItemClass I ON S.ItemClassID = I.ItemClassID " +
                $"WHERE S.SellableName LIKE '%{PageObjects.inventory.SearchBox}%' OR S.SellableID LIKE '%{PageObjects.inventory.SearchBox}%' AND Status = @status ORDER BY SellableID", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@status", status);
            }
            else
            {
                // if search mode is off, all sellable items will be displayed
                ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableID, S.SellableName, I.ItemClassName, I.ItemClassPlantPrice, S.SellableQuantity " +
                "FROM SellableItems S JOIN ItemClass I ON S.ItemClassID = I.ItemClassID WHERE Status = @status", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@status", status);
            }

            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while (ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0), ConnectionObjects.reader.GetString(1), ConnectionObjects.reader.GetString(2),
                    "PHP " + ConnectionObjects.reader.GetDecimal(3) , ConnectionObjects.reader.GetValue(4) + "kg",
                    "PHP " + (ConnectionObjects.reader.GetDecimal(3) * ConnectionObjects.reader.GetDecimal(4)),
                    Dan_Junkshop_Management_System.Properties.Resources.icon_park_solid_edit);

                PageObjects.inventory.ItemNameArray.Add(ConnectionObjects.reader.GetString(1));

            }

            PageObjects.inventory.InventoryGrid.DataSource = ConnectionObjects.dataTable;

            PageObjects.inventory.InventoryGrid.AutoResizeColumn(6, DataGridViewAutoSizeColumnMode.AllCells);

            foreach(DataGridViewColumn column in PageObjects.inventory.InventoryGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }

        public void GetItemToEdit(SellableDetails details)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableName, I.ItemClassName, S.SellableQuantity, S.Status " +
                "FROM SellableItems S JOIN ItemClass I ON S.ItemClassID = I.ItemClassID WHERE SellableName = @sellablename", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@sellablename", PageObjects.inventory.ItemName);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read())
            {
                details.SellableName = ConnectionObjects.reader.GetString(0);
                details.ItemClassName = ConnectionObjects.reader.GetString(1);
                details.SellableQuantity = ConnectionObjects.reader.GetDecimal(2);
                
                if(ConnectionObjects.reader.GetInt32(3) == 1)
                {
                    details.Status = "Active";
                }
                else
                {
                    details.Status = "Inactive";
                }
            }

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
        }
        public void GetItemClasses(ComboBox cbClass)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassName FROM ItemClass", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            cbClass.Items.Clear();

            while (ConnectionObjects.reader.Read())
            {
                cbClass.Items.Add(ConnectionObjects.reader.GetString(0));
            }
            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
        }
        public decimal GetItemPrice(string className)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassPlantPrice FROM ItemClass WHERE ItemClassName = @itemclassname", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassname", className);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read())
            {
                itemPrice = (ConnectionObjects.reader.GetDecimal(0));
            }
            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            return itemPrice;
        }
        public bool ItemDetailsChecker(SellableDetails details)
        {
            if(details.SellableName == "" || details.ItemClassName == "")
            {
                MessageBox.Show("Item details was incomplete!" +
                    "\nPlease complete the item details to save", "Sellable Item Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                detailsComplete = false;
            }
            else
            {
                detailsComplete = true;
            }
            return detailsComplete;
        }
        
        public bool ItemExistChecker(string itemName)
        {
            ConnectionObjects.conn.Open();
            ConnectionObjects.cmd = new SqlCommand("SELECT SellableName FROM SellableItems WHERE SellableName = @sellablename", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@sellablename", itemName);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read())
            {
                MessageBox.Show("Sellable item was already existing!", "Sellable Item Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                itemExist = true;
            }
            else
            {
                itemExist = false;
            }
            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            return itemExist;
        }
        public void GetItemIDCount()
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(SellableID) FROM SellableItems WHERE Status = 1", ConnectionObjects.conn);
            idCount = Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());
            ConnectionObjects.conn.Close();
        }
        public void GetClassID(string className)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassID FROM ItemClass WHERE ItemClassName = @itemclassname", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassname", className);
            classID = ConnectionObjects.cmd.ExecuteScalar().ToString();

            ConnectionObjects.conn.Close();
        }
        public void AddItem(SellableDetails details)
        {
            idCount += 1000;

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("INSERT INTO SellableItems VALUES(@sellableid, @sellablename, @itemclassid, @sellablequantity, @status)", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@sellableid", $"SCRAP{idCount + 1}");
            ConnectionObjects.cmd.Parameters.AddWithValue("@sellablename", details.SellableName);
            ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassid", classID);
            ConnectionObjects.cmd.Parameters.AddWithValue("@sellablequantity", Convert.ToDecimal(details.SellableQuantity));
            ConnectionObjects.cmd.Parameters.AddWithValue("@status", 1);
            ConnectionObjects.cmd.ExecuteNonQuery();

            ConnectionObjects.conn.Close();
        }

        public void UpdateItem(SellableDetails details)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("UPDATE SellableItems SET SellableName = @sellablename, ItemClassID = @itemclassid, " +
                "SellableQuantity = @sellablequantity, Status = @status", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@sellablename", details.SellableName);
            ConnectionObjects.cmd.Parameters.AddWithValue("@itemclassid", classID);
            ConnectionObjects.cmd.Parameters.AddWithValue("@sellablequantity", details.SellableQuantity);

            if(details.Status == "Active")
            {
                ConnectionObjects.cmd.Parameters.AddWithValue("@status", 1);
            }
            else
            {
                ConnectionObjects.cmd.Parameters.AddWithValue("@status", 0);
            }

            ConnectionObjects.cmd.ExecuteNonQuery();

            ConnectionObjects.conn.Close();
        }
    }
}
