using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System.Deliveries
{
    public class DeliveryCRUD
    {
        private string toDeliver;
        private int idCount;

        public void DisplayDeliverables()
        {
            ConnectionObjects.dataTable = new DataTable();
            ConnectionObjects.dataTable.Columns.Add("Class Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Current Scale", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Required Scale", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Status", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Deliver", typeof(Image));

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT I.ItemClassName, SUM(S.SellableQuantity), I.ItemClassRequiredScale " +
                "FROM SellableItems S JOIN ItemClass I ON S.ItemClassID = I.ItemClassID WHERE Status = 1 GROUP BY ItemClassName, ItemClassRequiredScale", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while(ConnectionObjects.reader.Read())
            {
                if(ConnectionObjects.reader.GetDecimal(1) >= ConnectionObjects.reader.GetDecimal(2))
                {
                    toDeliver = "Ready to deliver";
                }
                else
                {
                    toDeliver = "Not ready to deliver";
                }

                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0), ConnectionObjects.reader.GetDecimal(1) + "kg",
                    ConnectionObjects.reader.GetDecimal(2) + "kg", toDeliver, Dan_Junkshop_Management_System.Properties.Resources.blackDeliver);
            }

            PageObjects.delivery.DeliveryGrid.DataSource = ConnectionObjects.dataTable;

            PageObjects.delivery.DeliveryGrid.AutoResizeColumn(4, DataGridViewAutoSizeColumnMode.AllCells);

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;

        }

        public int GetDeliverIDCount()
        {
            idCount = 1000;
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(DeliverID) FROM Deliveries", ConnectionObjects.conn);
            idCount += Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());

            ConnectionObjects.conn.Close();

            idCount += 1;
            return idCount;
        }

    }
}
