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
        public string selectedButton;
        
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            HomepageObjects.dashboard = new DashboardPanel();
            ContentsPanel.Controls.Add(HomepageObjects.dashboard); // will display dashboard
            selectedButton = lblPageHeader.Text;
            GC.Collect();
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
                                                "\nAny unsaved changes will be lost!", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
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
            lblPageHeader.Text = "Dashboard";
            resetIconColor(); // will reset the color of homepage icons
            selectedButton = lblPageHeader.Text;

            ContentsPanel.Controls.Clear();
            ContentsPanel.Controls.Add(HomepageObjects.dashboard); // will display dashboard
            
        }

        public void btnSales_Click(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Sales and Reports";
            resetIconColor(); // will reset the color of homepage icons
            selectedButton = lblPageHeader.Text;

            ContentsPanel.Controls.Clear();
            ContentsPanel.Controls.Add(HomepageObjects.sales_Reports); // will display sales and reports page
        }

        private void btnPriceSetup_Click(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Price Setup";
            resetIconColor(); // will reset the color of homepage icons
            selectedButton = lblPageHeader.Text;

            ContentsPanel.Controls.Clear();
            ContentsPanel.Controls.Add(HomepageObjects.priceConfiguration); // will display price configuration page
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Inventory";
            resetIconColor(); // will reset the color of homepage icons
            selectedButton = lblPageHeader.Text;

            ContentsPanel.Controls.Clear();
            ContentsPanel.Controls.Add(HomepageObjects.inventory); // will display inventory page
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Transaction";
            resetIconColor(); // will reset the color of homepage icons
            selectedButton = lblPageHeader.Text;

            ContentsPanel.Controls.Clear();
            ContentsPanel.Controls.Add(HomepageObjects.transaction); // will display transaction page
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logoutDialog = MessageBox.Show("Are you sure you want to logout?" +
                "\nAny unsaved changes will be lost!", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(logoutDialog == DialogResult.Yes)
            {
                LoginPage loginPage = LoginPage.GetLoginInstance();
                loginPage.ShowInTaskbar = true;
                loginPage.Show();
                this.Close();
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Employee";
            resetIconColor(); // will reset the color of homepage icons
            selectedButton = lblPageHeader.Text;

            ContentsPanel.Controls.Clear();
            ContentsPanel.Controls.Add(HomepageObjects.employee); // will display employee page
        }

        private void btnPartners_Click(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Partners";
            resetIconColor(); // will reset the color of homepage icons
            selectedButton = lblPageHeader.Text;

            ContentsPanel.Controls.Clear();
            ContentsPanel.Controls.Add(HomepageObjects.partners); // will display partner page
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Delivery";
            resetIconColor(); // will reset the color of homepage icons
            selectedButton = lblPageHeader.Text;
            
            ContentsPanel.Controls.Clear();
            ContentsPanel.Controls.Add(HomepageObjects.delivery); // will display delivery page
        }

        public void resetIconColor()
        {
            // will set the homepage icons color to white
            switch (selectedButton)
            {
                case "Dashboard":
                    HomepageObjects.dashboard.Dispose();
                    btnHome.Image = Dan_Junkshop_Management_System.Properties.Resources.NewHome;
                    break;
                case "Sales and Reports":
                    HomepageObjects.sales_Reports.Dispose();
                    btnSales.Image = Dan_Junkshop_Management_System.Properties.Resources.NewSales;
                    break;
                case "Employee":
                    HomepageObjects.employee.Dispose();
                    btnEmployee.Image = Dan_Junkshop_Management_System.Properties.Resources.NewEmployee;
                    break;
                case "Transaction":
                    HomepageObjects.transaction.Dispose();
                    btnTransaction.Image = Dan_Junkshop_Management_System.Properties.Resources.NewTransaction;
                    break;
                case "Price Setup":
                    HomepageObjects.priceConfiguration.Dispose();
                    btnPriceSetup.Image = Dan_Junkshop_Management_System.Properties.Resources.NewPriceSetup;
                    break;
                case "Inventory":
                    HomepageObjects.inventory.Dispose();
                    btnInventory.Image = Dan_Junkshop_Management_System.Properties.Resources.NewInventory;
                    break;
                case "Partners":
                    HomepageObjects.partners.Dispose();
                    btnPartners.Image = Dan_Junkshop_Management_System.Properties.Resources.NewPartners;
                    break;
                case "Delivery":
                    HomepageObjects.delivery.Dispose();
                    btnDelivery.Image = Dan_Junkshop_Management_System.Properties.Resources.NewDelivery;
                    break;
            }

            // will set the homepage icons color to red
            switch (lblPageHeader.Text)
            {
                case "Dashboard":
                    HomepageObjects.dashboard = new DashboardPanel();
                    btnHome.Image = Dan_Junkshop_Management_System.Properties.Resources.newRedHome;
                    break;
                case "Sales and Reports":
                    HomepageObjects.sales_Reports = new Sales_Reports();
                    btnSales.Image = Dan_Junkshop_Management_System.Properties.Resources.newRedSales;
                    break;
                case "Employee":
                    HomepageObjects.employee = new Employee();
                    btnEmployee.Image = Dan_Junkshop_Management_System.Properties.Resources.newRedEmployee;
                    break;
                case "Transaction":
                    HomepageObjects.transaction = new Transaction();
                    btnTransaction.Image = Dan_Junkshop_Management_System.Properties.Resources.newRedTransaction;
                    break;
                case "Price Setup":
                    HomepageObjects.priceConfiguration = new PriceConfiguration();
                    btnPriceSetup.Image = Dan_Junkshop_Management_System.Properties.Resources.newRedPriceSetup;
                    break;
                case "Inventory":
                    HomepageObjects.inventory = new Inventory();
                    btnInventory.Image = Dan_Junkshop_Management_System.Properties.Resources.newRedInventory;
                    break;
                case "Partners":
                    HomepageObjects.partners = new Partners();
                    btnPartners.Image = Dan_Junkshop_Management_System.Properties.Resources.newRedPartners;
                    break;
                case "Delivery":
                    HomepageObjects.delivery = new Delivery();
                    btnDelivery.Image = Dan_Junkshop_Management_System.Properties.Resources.newRedDelive;
                    break;
            }


        }

    }
  
}
