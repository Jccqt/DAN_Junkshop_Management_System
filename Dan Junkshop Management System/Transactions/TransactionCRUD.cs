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
using System.Collections;

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
            ConnectionObjects.dataTable.Columns.Add("Price/kg", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Add", typeof(Image));

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableName, I.ItemClassName, I.ItemClassPlantPrice, I.ItemClassCapital " +
                "FROM SellableItems S JOIN ItemClass I ON S.ItemClassID = I.ItemClassID WHERE Status = @status", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@status", status);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while (ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0), ConnectionObjects.reader.GetString(1),
                    "PHP " + (ConnectionObjects.reader.GetDecimal(2) + ConnectionObjects.reader.GetDecimal(3)),
                    Dan_Junkshop_Management_System.Properties.Resources.add);

                PageObjects.newBuyTransaction.ItemNamesArray.Add(ConnectionObjects.reader.GetString(0));

            }

            PageObjects.newBuyTransaction.ItemsGrid.DataSource = ConnectionObjects.dataTable;

            PageObjects.newBuyTransaction.ItemsGrid.AutoResizeColumn(3, DataGridViewAutoSizeColumnMode.AllCells);

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }
        public void DisplayOrders(ArrayList orderNames, bool isSupplier)
        {
            ConnectionObjects.dataTable = new DataTable();
            ConnectionObjects.dataTable.Columns.Add("Sellable Item Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Class", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Price/kg", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Scale (kg)", typeof(decimal));
            ConnectionObjects.dataTable.Columns.Add("Remove", typeof(Image));

            ConnectionObjects.conn.Open();

            for(int i = 0; i < orderNames.Count; i++)
            {
                ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableName, I.ItemClassName, I.ItemClassPlantPrice, I.ItemClassCapital " +
                "FROM SellableItems S JOIN ItemClass I ON S.ItemClassID = I.ItemClassID WHERE SellableName = @sellablename", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@sellablename", orderNames[i]);
                ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

                if (ConnectionObjects.reader.Read())
                {
                    ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0), ConnectionObjects.reader.GetString(1),
                        "PHP " + (ConnectionObjects.reader.GetDecimal(2) + ConnectionObjects.reader.GetDecimal(3)), 0,
                        Dan_Junkshop_Management_System.Properties.Resources.remove);
                }
                ConnectionObjects.reader.Close();
            }


            PageObjects.newBuyTransaction.OrdersGrid.DataSource = ConnectionObjects.dataTable;

            PageObjects.newBuyTransaction.OrdersGrid.AutoResizeColumn(4, DataGridViewAutoSizeColumnMode.AllCells);
            PageObjects.newBuyTransaction.OrdersGrid.Columns[0].ReadOnly = true;
            PageObjects.newBuyTransaction.OrdersGrid.Columns[1].ReadOnly = true;

            if (isSupplier)
            {
                PageObjects.newBuyTransaction.OrdersGrid.Columns[2].ReadOnly = false;
            }
            else
            {
                PageObjects.newBuyTransaction.OrdersGrid.Columns[2].ReadOnly = true;
            }

            PageObjects.newBuyTransaction.OrdersGrid.Columns[4].ReadOnly = true;
            PageObjects.newBuyTransaction.OrdersGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            

 

       
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }

    }
}
