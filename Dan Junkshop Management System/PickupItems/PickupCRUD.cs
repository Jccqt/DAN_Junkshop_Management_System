using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dan_Junkshop_Management_System.PickupItems
{
    public class PickupCRUD
    {
        private int idCount;

        public void DisplayPickups()
        {
            ConnectionObjects.dataTable = new DataTable();

            ConnectionObjects.dataTable.Columns.Add("ID", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Sellable Item Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Sold to", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Scale Quantity", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Total Amount", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Date", typeof(DateTime));

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT P.PickupID, S.SellableName, R.FirstName, R.MiddleName, R.LastName, " +
                "P.Scale, P.Amount, P.date FROM Pickups P JOIN SellableItems S ON P.SellableID = S.SellableID " +
                "JOIN Partners R ON P.PartnerID = R.PartnerID", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while(ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0), ConnectionObjects.reader.GetString(1), 
                    $"{ConnectionObjects.reader.GetString(2)} {ConnectionObjects.reader.GetString(3)} {ConnectionObjects.reader.GetString(4)}", 
                    ConnectionObjects.reader.GetDecimal(5) + "kg", "PHP " + ConnectionObjects.reader.GetDecimal(6), ConnectionObjects.reader.GetDateTime(7));
            }

            PageObjects.pickup.PickupGrid.DataSource = ConnectionObjects.dataTable;

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;

        }

        public int GetPickupIDCount()
        {
            idCount = 1000;

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(PickupID) FROM Pickups", ConnectionObjects.conn);
            idCount += Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());

            ConnectionObjects.conn.Close();

            return idCount + 1;
        }

        public void ProcessPickup(PickupDetails details)
        {
            var localDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm tt");

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("INSERT INTO Pickups VALUES (@pickupid, @sellableid, @partnerid, " +
                "@empid, @scale, @amount, @date)", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@pickupid", details.PickupID);
            ConnectionObjects.cmd.Parameters.AddWithValue("@sellableid", details.SellableID);
            ConnectionObjects.cmd.Parameters.AddWithValue("@partnerid", details.PartnerID);
            ConnectionObjects.cmd.Parameters.AddWithValue("@empid", PageObjects.homepage.EmpID);
            ConnectionObjects.cmd.Parameters.AddWithValue("@scale", details.ScaleQuantity);
            ConnectionObjects.cmd.Parameters.AddWithValue("@amount", details.Amount);
            ConnectionObjects.cmd.Parameters.AddWithValue("@date", localDate);
            ConnectionObjects.cmd.ExecuteNonQuery();

            ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(ActivityID) FROM ActivityLogs", ConnectionObjects.conn);
            int actCount = 1000 + Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());

            ConnectionObjects.cmd = new SqlCommand("INSERT INTO ActivityLogs VALUES(@activityid, @empid, @description, @date)", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@activityid", $"ACT{actCount + 1}");
            ConnectionObjects.cmd.Parameters.AddWithValue("@empid", PageObjects.homepage.EmpID);
            ConnectionObjects.cmd.Parameters.AddWithValue("@description", $"Process a pick-up with ID: {details.PickupID}.");
            ConnectionObjects.cmd.Parameters.AddWithValue("@date", localDate);
            ConnectionObjects.cmd.ExecuteNonQuery();

            ConnectionObjects.conn.Close();
        }

        public void DeductToInventory(PickupDetails details)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("BEGIN" +
                "\nBEGIN TRANSACTION" +
                "\n DECLARE @Quantity AS DECIMAL(18,2);" +
                "\n SET @Quantity = (SELECT SellableQuantity FROM SellableItems WHERE SellableID = @sellableid);" +
                "\n SET @Quantity = @Quantity - @QuantitySold" +
                "\n UPDATE SellableItems SET SellableQuantity = @Quantity WHERE SellableID = @sellableid" +
                "\n COMMIT" +
                "\nEND", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@QuantitySold", details.ScaleQuantity);
            ConnectionObjects.cmd.Parameters.AddWithValue("@sellableid", details.SellableID);
            ConnectionObjects.cmd.ExecuteNonQuery();

            ConnectionObjects.conn.Close();
        }
    }
}
