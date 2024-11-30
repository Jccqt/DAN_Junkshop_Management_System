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
            ChartReport.Series["Series1"].Points.AddXY("Tite", 32);
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
