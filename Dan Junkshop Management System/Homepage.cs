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
    public partial class Homepage : Form
    {
        
        static Dashboard dashboard;
        static Sales_Reports sales_Reports = new Sales_Reports();
        static Inventory inventory;
       static PriceConfiguration priceConfiguration = new PriceConfiguration();
        public Homepage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            inventory = new Inventory();
            panel3.Controls.Add(priceConfiguration);
          
          
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void customButton7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

    
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
  
}
