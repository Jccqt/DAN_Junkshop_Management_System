using System;
using System.Collections;
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
    public partial class frmNewTransaction : Form
    {
        private ArrayList itemNames = new ArrayList();
        private int rowIndex;
        public frmNewTransaction()
        {
            InitializeComponent();
           
        }

        public DataGridView ItemsGrid { get { return gridViewItems; } }
        public string ItemName { get { return itemNames[rowIndex].ToString(); } }
        public ArrayList ItemNamesArray { get { return itemNames; } }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            
        }

        private void NewBuyTransaction_Load(object sender, EventArgs e)
        {
            Queries.TransactionQuery.DisplayItems(1);
        }

        private void btnCancelTransaction_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
