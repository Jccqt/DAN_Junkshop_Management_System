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
            ContentsPanel.Controls.Clear();
            lblPageHeader.Text = "Price Setup";
            ContentsPanel.Controls.Add(HomepageObjects.priceConfiguration);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ContentsPanel.Controls.Clear();
            lblPageHeader.Text = "Inventory"; 
            ContentsPanel.Controls.Add(HomepageObjects.inventory);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            

            Form formBackground = new Form();
            try
            {
                using (FrmTypeOfTransaction transactionType = new FrmTypeOfTransaction())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .80;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();
                    transactionType.Owner = formBackground;
                    DialogResult ds = transactionType.ShowDialog();
                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { formBackground.Dispose(); }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            lblPageHeader.Text = "Employee";
            ContentsPanel.Controls.Clear();
            ContentsPanel.Controls.Add(employee);
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();
            lblPageHeader.Text = "Delivery";
            ContentsPanel.Controls.Clear();
            ContentsPanel.Controls.Add(delivery);
        }
    }
  
}
