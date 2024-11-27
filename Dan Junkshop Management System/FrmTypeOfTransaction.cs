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
    public partial class frmTypeOfTransaction : Form
    {
        public frmTypeOfTransaction()
        {
            InitializeComponent();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {    
            using (PageObjects.newBuyTransaction = new frmNewBuyTransaction())
            {
                this.Hide();
                PageObjects.newBuyTransaction.ShowInTaskbar = false;
                PageObjects.newBuyTransaction.ShowDialog();
                this.Show();
            }     
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTypeOfTransaction_Load(object sender, EventArgs e)
        {
            this.Owner = FormAnimation.formBackground;
        }
    }
}
