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
    public partial class Form1 : Form
    {
        
        static Dashboard dashboard;
        static NewAdminTab adminTab1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adminTab1 = new NewAdminTab();
            dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Fill;
            
            adminTab1.Dock = DockStyle.Fill;
            this.Controls.Add(adminTab1);
            adminTab1.panel3.Controls.Add(dashboard);
        }


      

    }
  
}
