using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dan_Junkshop_Management_System.Partner
{
    public class PartnerCRUD
    {
        private string partnerID;

        public void GetPartnerList(ComboBox cbPartner)
        {
            cbPartner.Items.Clear();

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT FirstName, MiddleName, LastName FROM Partners WHERE Status = 1", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while (ConnectionObjects.reader.Read())
            {
                cbPartner.Items.Add($"{ConnectionObjects.reader.GetString(0)} {ConnectionObjects.reader.GetString(1)} {ConnectionObjects.reader.GetString(2)}");
            }
            ConnectionObjects.reader.Close();

            ConnectionObjects.conn.Close();
        }

        public string GetPartnerID(string fullname)
        {
            string[] name = fullname.Split(' ');

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT PartnerID FROM Partners WHERE FirstName = @firstname AND MiddleName = @middlename " +
                "AND LastName = @lastname", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@firstname", name[0]);
            ConnectionObjects.cmd.Parameters.AddWithValue("@middlename", name[1]);
            ConnectionObjects.cmd.Parameters.AddWithValue("@lastname", name[2]);
            partnerID = ConnectionObjects.cmd.ExecuteScalar().ToString();

            ConnectionObjects.conn.Close();

            return partnerID;
        }
    }
}
