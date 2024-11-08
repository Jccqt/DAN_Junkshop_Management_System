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
        
        static Dashboard dashboard = new Dashboard();
        static Sales_Reports sales_Reports = new Sales_Reports();
        static Inventory inventory = new Inventory();
        static PriceConfiguration priceConfiguration = new PriceConfiguration();
        public Homepage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.Controls.Add(dashboard);

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(dashboard);
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

        private void customButton3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            headerLabel.Text = "Sales and Reports";
            panel3.Controls.Add(sales_Reports);
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            headerLabel.Text = "Inventory";
            panel3.Controls.Add(inventory);
        }

        private void priceSetupBtn_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            headerLabel.Text = "Price Configuration";
            panel3.Controls.Add(priceConfiguration);
        }
    }
  
}
