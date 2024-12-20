using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dan_Junkshop_Management_System
{
    public partial class ActivityLog : UserControl
    {
        public ActivityLog()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Dock = DockStyle.Fill;

            gridActivityLog.EnableHeadersVisualStyles = false;
            gridActivityLog.ColumnHeadersHeight = 50;
            gridActivityLog.RowHeadersWidth = 50;
            gridActivityLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        private void ActivityLog_Load(object sender, EventArgs e)
        {
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT A.ActivityID, E.FirstName, E.MiddleName, E.LastName, A.Description, " +
                "A.Date FROM ActivityLogs A JOIN Employees E ON A.EmpID = E.EmpID", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while(ConnectionObjects.reader.Read())
            {
                gridActivityLog.Rows.Add(ConnectionObjects.reader.GetString(0), $"{ConnectionObjects.reader.GetString(1)} {ConnectionObjects.reader.GetString(2)} {ConnectionObjects.reader.GetString(3)}", 
                    ConnectionObjects.reader.GetString(4), ConnectionObjects.reader.GetValue(5));
            }
            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();

            gridActivityLog.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
    }
}
