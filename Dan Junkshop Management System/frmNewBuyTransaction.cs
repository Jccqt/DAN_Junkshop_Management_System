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
    public partial class frmNewBuyTransaction : Form
    {
        public frmNewBuyTransaction()
        {
            InitializeComponent();
            TransactionSoldItems transactionSoldItems = new TransactionSoldItems();
            flowLayoutPanel1.Controls.Add(transactionSoldItems);
        }

 

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using(PageObjects.addItemSelection = new frmAddingItemSelection())
            {
                this.Hide();
                PageObjects.addItemSelection.ShowDialog();
                this.Show();
            }
        }

        private void NewBuyTransaction_Load(object sender, EventArgs e)
        {
            this.Owner = FormAnimation.formBackground;
        }
    }
}
