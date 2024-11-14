using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System
{
    public partial class Sales_Reports : UserControl
    {
       
        
        public Sales_Reports()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void Sales_Reports_Load(object sender, EventArgs e)
        {
            // will load report table based on the element that was clicked on dashboard
            switch (DashboardPanel.ReportLabel)
            {
                case "Report1": btnReport1_Click(sender, e); break;
                case "Report2": btnReport2_Click(sender, e); break;
                case "Report3": btnReport3_Click(sender, e); break;
            }
        }

        

        private void btnReport1_Click(object sender, EventArgs e)
        {
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
    }
}
