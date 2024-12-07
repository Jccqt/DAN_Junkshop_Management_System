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

        public void DisplayPartners(int status)
        {
            PageObjects.partners.PartnersFLP.Controls.Clear();

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT PartnerID, FirstName, MiddleName, LastName, Contact FROM Partners " +
                "WHERE Status = @status", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@status", status);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while(ConnectionObjects.reader.Read())
            {
                DisplayPartners displayPartners = new DisplayPartners();

                displayPartners.EditButton.Tag = ConnectionObjects.reader.GetString(0);
                displayPartners.lblFullName.Text = $"{ConnectionObjects.reader.GetString(1)} {ConnectionObjects.reader.GetString(2)} {ConnectionObjects.reader.GetString(3)}";
                displayPartners.lblContact.Text = ConnectionObjects.reader.GetString(4);

                PageObjects.partners.PartnersFLP.Controls.Add(displayPartners);

                displayPartners.EditButton.Click += new EventHandler(PageObjects.partners.ClickEdit);
            }

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();

        }

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
