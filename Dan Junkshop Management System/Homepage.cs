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
        
        
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            ContentsPanel.Controls.Add(HomepageObjects.dashboard);
            

        }

        private void btnWindowSize_Click(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            // will prompt a warning message if the user is trying to exit the app
            DialogResult exitDialog = MessageBox.Show("Are you sure you want to exit the app?" +
                                                "\nAny unsaved progress cannot be recovered!", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if(exitDialog == DialogResult.Yes)
            {
                Application.Exit(); // will terminate the application
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        //New buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.btnHome.Image = Dan_Junkshop_Management_System.Properties.Resources.newRedHome;
            ContentsPanel.Controls.Clear();
            ContentsPanel.Controls.Add(HomepageObjects.dashboard);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
           
            this.btnSales.Image = Dan_Junkshop_Management_System.Properties.Resources.newRedSales;
            ContentsPanel.Controls.Clear();
            lblPageHeader.Text = "Sales and Reports";
            ContentsPanel.Controls.Add(HomepageObjects.sales_Reports);
        }

        private void btnPriceSetup_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            ContentsPanel.Controls.Clear();
            ContentsPanel.Controls.Add(transaction);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
  
}
