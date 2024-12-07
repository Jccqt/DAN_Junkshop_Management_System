using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dan_Junkshop_Management_System.Price_Configuration
{
    public class ItemClassCRUD
    {
        private decimal totalOwnedQuantity, plantPrice;
        private string ClassID, className;

        public decimal GetTotalOwnedQuantity(string className)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT SUM(S.SellableQuantity) FROM SellableItems S JOIN ItemClass I " +
                "ON S.ItemClassID = I.ItemClassID WHERE I.ItemClassName = @className GROUP BY S.ItemClassID", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@classname", className);
            totalOwnedQuantity = Convert.ToDecimal(ConnectionObjects.cmd.ExecuteScalar());

            ConnectionObjects.conn.Close();

            return totalOwnedQuantity;
        }

        public decimal GetPlantPrice(string className)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassPlantPrice FROM ItemClass ", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@classname", className);
            plantPrice = Convert.ToDecimal(ConnectionObjects.cmd.ExecuteScalar());

            ConnectionObjects.conn.Close();

            return plantPrice;
        }

        public string GetClassID(string className)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassID FROM ");
            return ClassID;
        }

        public string GetClassName(string itemName)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT I.ItemClassName FROM SellableItems S JOIN ItemClass I ON " +
                "S.ItemClassID = I.ItemClassID WHERE SellableName = @sellablename", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@sellablename", itemName);
            className = ConnectionObjects.cmd.ExecuteScalar().ToString();

            ConnectionObjects.conn.Close();

            return className;
        }
    }
}
