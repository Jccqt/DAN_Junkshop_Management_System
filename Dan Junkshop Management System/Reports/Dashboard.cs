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
            this.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            ConnectionObjects.conn.Close();
            Calendar.MaxSelectionCount = 1;
            
            Series series = ChartReport.Series.Add("Sales");
            series.ChartType = SeriesChartType.Pie;
            series.Font = new System.Drawing.Font("Arial", 8);

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableName, P.Amount FROM Pickups P JOIN SellableItems S " +
                "ON P.SellableID = S.SellableID WHERE DAY(P.date) = @day AND MONTH(P.date) = @month AND YEAR(P.date) = @year GROUP BY S.SellableName, P.Amount", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@day", day);
            ConnectionObjects.cmd.Parameters.AddWithValue("@month", month);
            ConnectionObjects.cmd.Parameters.AddWithValue("@year", year);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while (ConnectionObjects.reader.Read())
            {             
                series.Points.AddXY($"{ConnectionObjects.reader.GetString(0)}",ConnectionObjects.reader.GetDecimal(1));
                series.IsValueShownAsLabel = false;
            }
            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();

            // will display total sales today
            Queries.DashboardQuery.DisplayReport1(day, month, year, lblReport1Value);

            // will display total transaction count today
            Queries.DashboardQuery.DisplayReport2(day, month, year, lblReport2Value);

            // will display total pickup count today
            Queries.DashboardQuery.DisplayReport3(day, month, year, lblReport3Value);
        }

    }
}
