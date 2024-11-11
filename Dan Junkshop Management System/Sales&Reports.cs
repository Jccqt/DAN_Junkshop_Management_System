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
           
        }

        private void transactionButton_Click(object sender, EventArgs e)
        { 
           
            btnReport1.BackColor = Color.White;
            btnReport1.ForeColor = Color.Black;
            btnReport3.BackColor = Color.White;
            btnReport3.ForeColor = Color.Black;
            btnReport2.ForeColor = Color.White;
            btnReport2.BackColor = Color.FromArgb(255, 83, 87);     
        }

        private void topSaleButton_Click(object sender, EventArgs e)
        {
            
            btnReport2.BackColor = Color.White;
            btnReport2.ForeColor = Color.Black;
            btnReport3.BackColor = Color.White;
            btnReport3.ForeColor = Color.Black;
            btnReport1.ForeColor = Color.White;
            btnReport1.BackColor = Color.FromArgb(255, 83, 87);
        }

        private void deliveryButton_Click(object sender, EventArgs e)
        {
            
            btnReport2.BackColor = Color.White;
            btnReport2.ForeColor = Color.Black;
            btnReport1.BackColor = Color.White;
            btnReport1.ForeColor = Color.Black;
            btnReport3.ForeColor = Color.White;
            btnReport3.BackColor = Color.FromArgb(255, 83, 87);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
