using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dan_Junkshop_Management_System.Transactions
{
    public class TransactionCRUD
    {
        public void DisplayItems(int status)
        {
            PageObjects.newBuyTransaction.ItemNamesArray.Clear();

            ConnectionObjects.dataTable = new DataTable();
            ConnectionObjects.dataTable.Columns.Add("Sellable Item Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Class", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Price/kg", typeof(double));
            ConnectionObjects.dataTable.Columns.Add("Add", typeof(Image));

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableName, I.ItemClassName, I.ItemClassPlantPrice, I.ItemClassCapital " +
                "FROM SellableItems S JOIN ItemClass I ON S.ItemClassID = I.ItemClassID WHERE Status = @status", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@status", status);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while (ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0), ConnectionObjects.reader.GetString(1),
                    (ConnectionObjects.reader.GetDecimal(2) + ConnectionObjects.reader.GetDecimal(3)),
                    Dan_Junkshop_Management_System.Properties.Resources.add);

                PageObjects.newBuyTransaction.ItemNamesArray.Add(ConnectionObjects.reader.GetString(0));

            }

            PageObjects.newBuyTransaction.ItemsGrid.DataSource = ConnectionObjects.dataTable;

            PageObjects.newBuyTransaction.ItemsGrid.AutoResizeColumn(3, DataGridViewAutoSizeColumnMode.AllCells);

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }
        public void AddItemToOrders(string itemName)
        {
            PageObjects.newBuyTransaction.OrderNamesArray.Clear();

            ConnectionObjects.dataTable = new DataTable();
            ConnectionObjects.dataTable.Columns.Add("Sellable Item Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Class", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Price/kg", typeof(double));
            ConnectionObjects.dataTable.Columns.Add("Remove", typeof(Image));

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableName, I.ItemClassName, I.ItemClassPlantPrice, I.ItemClassCapital " +
                "FROM SellableItems S JOIN ItemClass I ON S.ItemClassID = I.ItemClassID WHERE SellableName = @sellablename", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@sellablename", itemName);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if(ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0), ConnectionObjects.reader.GetString(1),
                    (ConnectionObjects.reader.GetDecimal(2) + ConnectionObjects.reader.GetDecimal(3)),
                    Dan_Junkshop_Management_System.Properties.Resources.remove);
            }

            PageObjects.newBuyTransaction.OrdersGrid.DataSource = ConnectionObjects.dataTable;

            PageObjects.newBuyTransaction.OrdersGrid.AutoResizeColumn(3, DataGridViewAutoSizeColumnMode.AllCells);

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }
    }
}
