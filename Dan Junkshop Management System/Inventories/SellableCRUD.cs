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
        public void DisplayItems(int status, bool isSearching)
        {
            PageObjects.inventory.ItemNameArray.Clear();

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
                $"WHERE S.SellableName LIKE '%{PageObjects.inventory.SearchBox}%' AND Status = @status", ConnectionObjects.conn);
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

                PageObjects.inventory.ItemNameArray.Add(ConnectionObjects.reader.GetString(0));

            }

            PageObjects.inventory.InventoryGrid.DataSource = ConnectionObjects.dataTable;

            PageObjects.inventory.InventoryGrid.AutoResizeColumn(4, DataGridViewAutoSizeColumnMode.AllCells);

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }
        public void GetItemClasses()
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassName FROM ItemClass", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            PageObjects.inventory.ItemTypes.Items.Clear();
            PageObjects.inventory.ItemTypes.Items.Add("All");

            while (ConnectionObjects.reader.Read())
            {
                PageObjects.inventory.ItemTypes.Items.Add(ConnectionObjects.reader.GetString(0));
            }
            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
        }

    }
}
