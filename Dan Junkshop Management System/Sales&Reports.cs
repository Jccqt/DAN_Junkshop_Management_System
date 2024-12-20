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

            btnReport1_Click(sender, e);
            // will load report table based on the element that was clicked on dashboard
            switch (DashboardPanel.ReportLabel)
            {
                case "Report1": btnReport1_Click(sender, e);  break;
                case "Report2": btnReport2_Click(sender, e); break;
                case "Report3": btnReport3_Click(sender, e); break;
            }
        }


        private void btnReport1_Click(object sender, EventArgs e)
        {
            int monthNumerical = DateTime.ParseExact(cbMonths.Text, "MMMM", CultureInfo.CurrentCulture).Month;
            this.gridTopReports.DataSource = null;
            Queries.DashboardQuery.DisplayTopSales(monthNumerical, Convert.ToInt32(cbYear.Text));
            lblTable.Text = btnReport1.Text;
            btnReport2.BackColor = Color.White;
            btnReport2.ForeColor = Color.Black;
            btnReport3.BackColor = Color.White;
            btnReport3.ForeColor = Color.Black;
            btnReport1.ForeColor = Color.White;
            btnReport1.BackColor = Color.FromArgb(255, 83, 87);
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            this.gridTopReports.DataSource = null;
            Queries.DashboardQuery.DisplayTopItems();
            lblTable.Text = btnReport2.Text;
            btnReport1.BackColor = Color.White;
            btnReport1.ForeColor = Color.Black;
            btnReport3.BackColor = Color.White;
            btnReport3.ForeColor = Color.Black;
            btnReport2.ForeColor = Color.White;
            btnReport2.BackColor = Color.FromArgb(255, 83, 87);
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            this.gridTopReports.DataSource = null;
            lblTable.Text = btnReport3.Text;
            btnReport2.BackColor = Color.White;
            btnReport2.ForeColor = Color.Black;
            btnReport1.BackColor = Color.White;
            btnReport1.ForeColor = Color.Black;
            btnReport3.ForeColor = Color.White;
            btnReport3.BackColor = Color.FromArgb(255, 83, 87);
        }

        void ChangeTable()
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                btnReport1_Click(sender, e);
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbYear.Text != "")
            {
                btnReport1_Click(sender, e);
            }
        }
    }
}
