using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Dan_Junkshop_Management_System.Deliveries
{
    public class VehicleCRUD
    {
        private bool vehicleExist, detailsComplete;
        private int idCount;
        private string availability;

        public void DisplayVehicles()
        {
            ConnectionObjects.dataTable = new DataTable();
            ConnectionObjects.dataTable.Columns.Add("ID",  typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Vehicle Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Plate Number", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Capacity", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Availability", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Edit", typeof(Image));

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT * FROM Vehicles", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while(ConnectionObjects.reader.Read())
            {
                if(ConnectionObjects.reader.GetInt32(4) == 1)
                {
                    availability = "Available";
                }
                else
                {
                    availability = "Not Available";
                }

                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0),  ConnectionObjects.reader.GetString(1), 
                    ConnectionObjects.reader.GetString(2), ConnectionObjects.reader.GetDecimal(3) + "kg", availability, 
                    Dan_Junkshop_Management_System.Properties.Resources.icon_park_solid_edit);
            }
            
            PageObjects.delivery.VehicleGrid.DataSource = ConnectionObjects.dataTable;

            PageObjects.delivery.VehicleGrid.AutoResizeColumn(5, DataGridViewAutoSizeColumnMode.AllCells);

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }

        public bool VehicleExistChecker(VehicleDetails details)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT VehiclePlateNumber FROM Vehicles WHERE VehiclePlateNumber = @platenumber", ConnectionObjects.conn);
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
            idCount = Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());

            ConnectionObjects.conn.Close();
        }

        public void AddVehicle(VehicleDetails details)
        {
            ConnectionObjects.conn.Open();

            idCount += 1000;

            ConnectionObjects.cmd = new SqlCommand("INSERT INTO Vehicles VALUES (@vehicleid, @vehiclename, @vehicleplatenumber, @vehiclecapacity, " +
                "@availability)", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@vehicleid", $"VEHICLE{idCount + 1}");
            ConnectionObjects.cmd.Parameters.AddWithValue("@vehiclename", details.VehicleName);
            ConnectionObjects.cmd.Parameters.AddWithValue("@vehicleplatenumber", details.PlateNumber);
            ConnectionObjects.cmd.Parameters.AddWithValue("@vehiclecapacity", details.Capacity);
            ConnectionObjects.cmd.Parameters.AddWithValue("@availability", 1);
            ConnectionObjects.cmd.ExecuteNonQuery();

            ConnectionObjects.conn.Close();
        }
    }
}
