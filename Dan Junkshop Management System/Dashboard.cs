using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace Dan_Junkshop_Management_System
{
    public partial class DashboardPanel : UserControl
    {
        public static string ReportLabel;

        public DashboardPanel()
        {
            InitializeComponent();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            Series series = ChartReport.Series.Add("Sales");
            series.ChartType = SeriesChartType.Pie;
            series.Font = new System.Drawing.Font("Arial", 12);

            ConnectionObjects.conn.Close();
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT I.ItemName, I.Subtotal FROM Transactions " +
                "CROSS APPLY OPENJSON(Items, '$.Items') " +
                "WITH (ItemName NVARCHAR(50) '$.Item', Subtotal decimal(18,2) '$.Subtotal') I", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while (ConnectionObjects.reader.Read())
            {
                series.Points.AddXY(ConnectionObjects.reader.GetString(0), ConnectionObjects.reader.GetDecimal(1));
            }
            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            ReportLabel = "Report1";
            PageObjects.homepage.btnSales_Click(sender, e); // will display sales and reports page
            ReportLabel = "";
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            ReportLabel = "Report2";
            PageObjects.homepage.btnSales_Click(sender, e); // will display sales and reports page
            ReportLabel = "";
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            ReportLabel = "Report3";
            PageObjects.homepage.btnSales_Click(sender, e); // will display sales and reports page
            ReportLabel = "";
        }
    }
}
