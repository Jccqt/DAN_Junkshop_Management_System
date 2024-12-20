using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Dan_Junkshop_Management_System
{
    public partial class Sales_Reports : UserControl
    {
       
        public DataGridView TopReportGrid { get { return gridTopReports; } }
        public int GetMonth { get { return DateTime.ParseExact(cbMonths.Text, "MMMM", CultureInfo.CurrentCulture).Month; } }
        public int GetYear { get { return Convert.ToInt32(cbYear.Text); } }

        public Sales_Reports()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void Sales_Reports_Load(object sender, EventArgs e)
        {
            cbYear.Items.Clear();
            int currentYear = DateTime.Now.Year;

            for(int i = 2000; i <= currentYear; i++)
            {
                cbYear.Items.Add(i);
            }

            cbMonths.Text = "December";
            cbYear.Text = currentYear.ToString();

            int monthNumerical = DateTime.ParseExact(cbMonths.Text, "MMMM", CultureInfo.CurrentCulture).Month;
            this.gridTopReports.DataSource = null;
            Queries.DashboardQuery.DisplayTopSales(monthNumerical, Convert.ToInt32(cbYear.Text));

        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            using(MonthlyTopSales topSalesPage = new MonthlyTopSales())
            {
                topSalesPage.ShowDialog();
            }
        }

        private void cbMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbYear.Text != "")
            {
                int monthNumerical = DateTime.ParseExact(cbMonths.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                this.gridTopReports.DataSource = null;
                Queries.DashboardQuery.DisplayTopSales(monthNumerical, Convert.ToInt32(cbYear.Text));
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbYear.Text != "")
            {
                int monthNumerical = DateTime.ParseExact(cbMonths.Text, "MMMM", CultureInfo.CurrentCulture).Month;
                this.gridTopReports.DataSource = null;
                Queries.DashboardQuery.DisplayTopSales(monthNumerical, Convert.ToInt32(cbYear.Text));
            }
        }
    }
}
