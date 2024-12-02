using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System.Inventories.Scraps
{
    public class ScrapCRUD
    {
        private bool itemExist, detailsComplete;
        private int itemIDCount;

        public void DisplayItems(int status, bool isSearching)
        {
            PageObjects.inventory.ItemNameArray.Clear();

            ConnectionObjects.dataTable = new DataTable();
            ConnectionObjects.dataTable.Columns.Add("Scrap name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Condition", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Price/qty", typeof(double));
            ConnectionObjects.dataTable.Columns.Add("Quantity (pcs)", typeof(int));
            ConnectionObjects.dataTable.Columns.Add("Edit", typeof(Image));

            ConnectionObjects.conn.Open();

            if (isSearching)
            {
                // if search mode is on, scraps will be displayed based on search box input
                ConnectionObjects.cmd = new SqlCommand("SELECT ScrapName, ScrapCondition, ScrapQuantity, ScrapPrice FROM ScrapItems " +
                    $"WHERE ScrapName LIKE '%{PageObjects.inventory.SearchBox}%' AND Status = @status", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@status", status);
            }
            else
            {
                // if search mode is off, all scraps will be displayed
                ConnectionObjects.cmd = new SqlCommand("SELECT ScrapName, ScrapCondition, ScrapQuantity, ScrapPrice FROM ScrapItems WHERE Status = @status", ConnectionObjects.conn);
                ConnectionObjects.cmd.Parameters.AddWithValue("@status", status);
            }
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();


            while (ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0),
                    ConnectionObjects.reader.GetString(1), ConnectionObjects.reader.GetInt32(2), ConnectionObjects.reader.GetValue(3),
                    Dan_Junkshop_Management_System.Properties.Resources.icon_park_solid_edit);

                PageObjects.inventory.ItemNameArray.Add(ConnectionObjects.reader.GetString(0));
            }
            PageObjects.inventory.InventoryGrid.DataSource = ConnectionObjects.dataTable;

            PageObjects.inventory.InventoryGrid.AutoResizeColumn(4, DataGridViewAutoSizeColumnMode.AllCells);

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }

        public bool ItemExistChecker(ScrapDetails details)
        {
            details.ScrapName = details.ScrapName.Trim();
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ScrapName, ScrapCondition FROM ScrapItems WHERE ScrapName = @scrapname AND ScrapCondition = @scrapcondition", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@scrapname", details.ScrapName);
            ConnectionObjects.cmd.Parameters.AddWithValue("@scrapcondition", details.ScrapCondition);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read())
            {
                MessageBox.Show($"This scrap item with {details.ScrapCondition} condition was already existing!",
                     "Scrap Item Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                itemExist = true;
            }
            else
            {
                itemExist = false;
            }

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            return itemExist;
        }

        public bool ItemDetailsChecker(ScrapDetails details)
        {
            if(details.ScrapName == "" || details.ScrapCondition == "" ||
                details.ScrapQuantity.ToString() == "" || details.ScrapPrice.ToString() == "")
            {
                MessageBox.Show("Scrap tem details was incomplete!" +
                    "\nPlease complete the scrap item details.", "Scrap Item Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                detailsComplete = false;
            }
            else
            {
                detailsComplete = true;
            }
            return detailsComplete;
        }
        public void GetItemIDCount()
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT COUNT(ScrapID) FROM ScrapItems", ConnectionObjects.conn);
            itemIDCount = Convert.ToInt32(ConnectionObjects.cmd.ExecuteScalar());
            ConnectionObjects.conn.Close();
        }
        public void AddItem(ScrapDetails details)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("INSERT INTO ScrapItems VALUES(@scrapid, @scrapname, @scrapcondition, " +
                        "@scrapquantity, @scrapprice, @status)", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@scrapid", $"SCRAP{itemIDCount + 1}");
            ConnectionObjects.cmd.Parameters.AddWithValue("@scrapname", details.ScrapName);
            ConnectionObjects.cmd.Parameters.AddWithValue("@scrapcondition", details.ScrapCondition);
            ConnectionObjects.cmd.Parameters.AddWithValue("@scrapquantity", Convert.ToInt32(details.ScrapQuantity));
            ConnectionObjects.cmd.Parameters.AddWithValue("@scrapprice", Convert.ToDouble(details.ScrapPrice));
            ConnectionObjects.cmd.Parameters.AddWithValue("@status", 1);
            ConnectionObjects.cmd.ExecuteNonQuery();

            ConnectionObjects.conn.Close();
        }
    }
}
