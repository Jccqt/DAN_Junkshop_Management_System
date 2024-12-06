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
        private int idCount;
        public void DisplayItems(int status)
        {
            PageObjects.newBuyTransaction.ItemNamesArray.Clear();

            ConnectionObjects.dataTable = new DataTable();
            ConnectionObjects.dataTable.Columns.Add("Sellable Item Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Class", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Price/kg", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Add", typeof(Image));

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableName, I.ItemClassName, I.ItemClassPlantPrice, I.ItemClassProfit " +
                "FROM SellableItems S JOIN ItemClass I ON S.ItemClassID = I.ItemClassID WHERE Status = @status", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@status", status);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while (ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0), ConnectionObjects.reader.GetString(1),
                    "PHP " + (ConnectionObjects.reader.GetDecimal(2) - ConnectionObjects.reader.GetDecimal(3)),
                    Dan_Junkshop_Management_System.Properties.Resources.add);

                PageObjects.newBuyTransaction.ItemNamesArray.Add(ConnectionObjects.reader.GetString(0));
            }

            PageObjects.newBuyTransaction.ItemsGrid.DataSource = ConnectionObjects.dataTable;

            PageObjects.newBuyTransaction.ItemsGrid.AutoResizeColumn(3, DataGridViewAutoSizeColumnMode.AllCells);

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }
      
        public void AddOrder(string itemName)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableName, I.ItemClassPlantPrice, I.ItemClassProfit FROM " +
                "SellableItems S JOIN ItemClass I ON S.ItemClassID = I.ItemClassID WHERE SellableName = @sellablename", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@sellablename", itemName);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if(ConnectionObjects.reader.Read())
            {
                PageObjects.newBuyTransaction.OrderNamesArray.Add(ConnectionObjects.reader.GetString(0));
                PageObjects.newBuyTransaction.PriceArray.Add(ConnectionObjects.reader.GetDecimal(1) - ConnectionObjects.reader.GetDecimal(2));
                PageObjects.newBuyTransaction.OriginalPriceArray.Add(ConnectionObjects.reader.GetDecimal(1) - ConnectionObjects.reader.GetDecimal(2));
                PageObjects.newBuyTransaction.ScaleArray.Add(0);
                PageObjects.newBuyTransaction.SubTotalArray.Add(0);
              
            }
            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
        }

        public void DisplayOrders(bool isSupplier)
        {
            PageObjects.newBuyTransaction.OrdersFLP.Controls.Clear();

            for(int i = 0; i < PageObjects.newBuyTransaction.OrderNamesArray.Count; i++)
            {
                Orders order = new Orders();

                order.Tag = PageObjects.newBuyTransaction.OrderNamesArray[i].ToString();
                order.txtItemName.Text = PageObjects.newBuyTransaction.OrderNamesArray[i].ToString();

                if (isSupplier)
                {
                    order.txtPrice.Enabled = true;
                    order.txtPrice.Text = PageObjects.newBuyTransaction.PriceArray[i].ToString();
                }
                else
                {
                    order.txtPrice.Enabled = false;
                    order.txtPrice.Text = PageObjects.newBuyTransaction.OriginalPriceArray[i].ToString();
                }
                
                order.txtScale.Text = PageObjects.newBuyTransaction.ScaleArray[i].ToString();

                PageObjects.newBuyTransaction.OrdersFLP.Controls.Add(order);
            }
        }

        public int GetTransactionIDCount()
        {
            idCount = 1000;
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(TransactionID) FROM Transactions", ConnectionObjects.conn);
            idCount += Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());

            ConnectionObjects.conn.Close();

            idCount += 1;
            return idCount;
        }

        public void ProcessTransaction(bool isSupplier)
        {
            var localDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm tt");

            ConnectionObjects.conn.Open();

            string items = @"{""Items"": [";

            for(int i = 0; i < PageObjects.newBuyTransaction.OrderNamesArray.Count; i++)
            {
                items = items + @"{""Item"":  """+ PageObjects.newBuyTransaction.OrderNamesArray[i] +@""", ""Scale"": "+ PageObjects.newBuyTransaction.ScaleArray[i] +@", ""Subtotal"": "+ PageObjects.newBuyTransaction.SubTotalArray[i] +"}";

                if(i != PageObjects.newBuyTransaction.OrderNamesArray.Count  - 1)
                {
                    items = items + ", ";
                }
            }
            items = items + "]}";

            ConnectionObjects.cmd = new SqlCommand("INSERT INTO Transactions VALUES (@transactid, @empid, @items, " +
                "@transactiontype, @transactionquantity, @transactionamount, @transactiondate)", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@transactid", PageObjects.newBuyTransaction.TransactionID.Text);
            ConnectionObjects.cmd.Parameters.AddWithValue("@empid", PageObjects.homepage.EmpID);
            ConnectionObjects.cmd.Parameters.AddWithValue("@items", items);

            if(isSupplier )
            {
                ConnectionObjects.cmd.Parameters.AddWithValue("@transactiontype", "Supplier");
            }
            else
            {
                ConnectionObjects.cmd.Parameters.AddWithValue("@transactiontype", "Walk-in");
            }

            ConnectionObjects.cmd.Parameters.AddWithValue("@transactionquantity", Convert.ToInt32(PageObjects.newBuyTransaction.ItemCountLabel.Text));
            ConnectionObjects.cmd.Parameters.AddWithValue("@transactionamount", PageObjects.newBuyTransaction.TotalCost);
            ConnectionObjects.cmd.Parameters.AddWithValue("@transactiondate", localDate);

            ConnectionObjects.cmd.ExecuteNonQuery();
            ConnectionObjects.conn.Close();

            MessageBox.Show("Items has been successfully processed!", "Transaction Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AddToInventory()
        {
            ConnectionObjects.conn.Open();

            for(int i = 0; i < PageObjects.newBuyTransaction.OrderNamesArray.Count; i++)
            {
                ConnectionObjects.cmd = new SqlCommand("BEGIN" +
                "\nBEGIN TRANSACTION" +
                "\n DECLARE @Quantity AS DECIMAL(18,2);" +
                "\n SET @Quantity = (SELECT SellableQuantity FROM SellableItems WHERE Sellablename = @sellablename)" +
                "\n SET @Quantity = @Quantity + @newquantity " +
                "\n UPDATE SellableItems SET SellableQuantity = @Quantity WHERE SellableName = @sellablename" +
                "\nCOMMIT" +
                "\nEND", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@sellablename", PageObjects.newBuyTransaction.OrderNamesArray[i]);
                ConnectionObjects.cmd.Parameters.AddWithValue("@newquantity", PageObjects.newBuyTransaction.ScaleArray[i]);
                ConnectionObjects.cmd.ExecuteNonQuery();
            }
            ConnectionObjects.conn.Close();
        }

        public void DisplayTransactions()
        {
            ConnectionObjects.dataTable = new DataTable();

            ConnectionObjects.dataTable.Columns.Add("TransactID", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("EmpID", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Type", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Quantity", typeof(int));
            ConnectionObjects.dataTable.Columns.Add("Amount", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Date", typeof(DateTime));
            ConnectionObjects.dataTable.Columns.Add("View", typeof(Image));

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT TransactionID, EmpID, TransactionType, TransactionQuantity, TransactionAmount, " +
                "TransactionDate FROM Transactions", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while(ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0), ConnectionObjects.reader.GetString(1),
                    ConnectionObjects.reader.GetString(2), ConnectionObjects.reader.GetInt32(3), "PHP " + ConnectionObjects.reader.GetDecimal(4),
                    ConnectionObjects.reader.GetValue(5), Dan_Junkshop_Management_System.Properties.Resources.overview); ;
            }

            PageObjects.transaction.TransactionGrid.DataSource = ConnectionObjects.dataTable;

            PageObjects.transaction.TransactionGrid.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells);
            PageObjects.transaction.TransactionGrid.AutoResizeColumn(6, DataGridViewAutoSizeColumnMode.AllCells);

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }

    }
}
