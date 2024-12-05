using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System.Vehicles
{
    public class VehicleCRUD
    {
        private bool vehicleExist, detailsComplete;
        private int idCount;

        public void DisplayVehicles()
        {
            ConnectionObjects.dataTable = new DataTable();
            ConnectionObjects.dataTable.Columns.Add("ID",  typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Vehicle Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Plate Number", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Capacity", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Availability", typeof(string));

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT * FROM Vehicles", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while(ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0),  ConnectionObjects.reader.GetString(1), 
                    ConnectionObjects.reader.GetString(2), ConnectionObjects.reader.GetDecimal(3) + "kg", ConnectionObjects.reader.GetString(4));
            }
            
            PageObjects.delivery.VehicleGrid.DataSource = ConnectionObjects.dataTable;

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }

        public bool VehicleExistChecker(VehicleDetails details)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT VehicleName, PlateNumber FROM Vehicles WHERE VehicleName = @vehiclename AND " +
                "PlateNumber = @platenumber", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@vehiclename", details.VehicleName);
            ConnectionObjects.cmd.Parameters.AddWithValue("@platenumber", details.PlateNumber);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if(ConnectionObjects.reader.Read())
            {
                MessageBox.Show("Vehicle already exist!", "Vehicle Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                vehicleExist = true;
            }
            else
            {
                vehicleExist = false;
            }

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();

            return vehicleExist;
        }

        public bool VehicleDetailsChecker(VehicleDetails details)
        {
            if(details.VehicleName == "" || details.PlateNumber == "" || details.Capacity == 0)
            {
                MessageBox.Show("Vehicle details was incomplete!" +
                    "\nPlease complete vehicle details to save", "Vehicle Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                detailsComplete = false;
            }
            else
            {
                detailsComplete = true;
            }
            return detailsComplete;
        }

        public void GetVehicleIDCount()
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(VehicleID) FROM Vehicles", ConnectionObjects.conn);
            idCount = ConnectionObjects.cmd.ExecuteNonQuery();

            ConnectionObjects.conn.Close();
        }
    }
}
