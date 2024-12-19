using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Dan_Junkshop_Management_System.Reports
{
    public class DashboardCRUD
    {
        public void DisplayReport1(int day, int month, int year, Label label)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT SUM(Amount) FROM Pickups WHERE DAY(date) = @day AND " +
                "MONTH(date) = @month AND YEAR(date) = @year GROUP BY date", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@day", day);
            ConnectionObjects.cmd.Parameters.AddWithValue("@month", month);
            ConnectionObjects.cmd.Parameters.AddWithValue("@year", year);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if(ConnectionObjects.reader.Read())
            {
                label.Text = ConnectionObjects.reader.GetDecimal(0).ToString();
            }
            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
        }

        public void DisplayReport2(int day, int month, int year, Label label)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(TransactionID) FROM Transactions WHERE DAY(TransactionDate) = @day AND " +
                "MONTH(TransactionDate) = @month AND YEAR(TransactionDate) = @year GROUP BY TransactionDate", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@day", day);
            ConnectionObjects.cmd.Parameters.AddWithValue("@month", month);
            ConnectionObjects.cmd.Parameters.AddWithValue("@year", year);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read())
            {
                label.Text = ConnectionObjects.reader.GetInt32(0).ToString();
            }
            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
        }

        public void DisplayReport3(int day, int month, int year, Label label)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(PickupID) FROM Pickups WHERE DAY(date) = @day AND " +
                "MONTH(date) = @month AND YEAR(date) = @year GROUP BY date", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@day", day);
            ConnectionObjects.cmd.Parameters.AddWithValue("@month", month);
            ConnectionObjects.cmd.Parameters.AddWithValue("@year", year);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read())
            {
                label.Text = ConnectionObjects.reader.GetInt32(0).ToString();
            }
            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
        }

        public void DisplayTopSales(int month)
        {
            ConnectionObjects.dataTable = new DataTable();

            ConnectionObjects.dataTable.Columns.Add("ID", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Sellable Item Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Class Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Total Sales", typeof(string));

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableID, S.SellableName, I.ItemClassName, SUM(P.Amount) FROM Pickups P JOIN " +
                "SellableItems S ON P.SellableID = S.SellableID " +
                "JOIN ItemClass I ON S.ItemClassID = I.ItemClassID WHERE MONTH(P.date) = @month GROUP BY S.SellableID, S.SellableName, I.ItemClassName", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@month", month);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while (ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0), ConnectionObjects.reader.GetString(1),
                    ConnectionObjects.reader.GetString(2), "PHP " + ConnectionObjects.reader.GetDecimal(3));
            }
            PageObjects.sales_Reports.TopReportGrid.DataSource = ConnectionObjects.dataTable;

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }

        public void DisplayTopItems()
        {
            ConnectionObjects.dataTable = new DataTable();
            ConnectionObjects.dataTable.Columns.Add("ID", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Sellable Item Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Item Class Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Scale Quantity", typeof(string));

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableID, S.SellableName, I.ItemClassName, S.SellableQuantity FROM SellableItems S " +
                "JOIN ItemClass I ON S.ItemClassID = I.ItemClassID WHERE Status = 1 ORDER BY S.SellableQuantity", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while(ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0), ConnectionObjects.reader.GetString(1),
                    ConnectionObjects.reader.GetString(2), ConnectionObjects.reader.GetDecimal(3) + "kg");
            }

            PageObjects.sales_Reports.TopReportGrid.DataSource = ConnectionObjects.dataTable;

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }
    }
}
