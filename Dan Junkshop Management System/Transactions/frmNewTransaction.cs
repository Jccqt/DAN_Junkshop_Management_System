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
        private ArrayList itemList = new ArrayList();
        private ArrayList orderList = new ArrayList();
        private int rowIndex;
        private bool isSupplier;
        public frmNewTransaction()
        {
            InitializeComponent();

        }

        public DataGridView ItemsGrid { get { return gridViewItems; } }
        public string ItemName { get { return itemList[rowIndex].ToString(); } }
        public string OrderName { get { return orderList[rowIndex].ToString(); } }
        public ArrayList ItemNamesArray { get { return itemList; } }
        public ArrayList OrderNamesArray { get { return orderList; } }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }

        private void NewBuyTransaction_Load(object sender, EventArgs e)
        {
            orderList.Clear();
            Queries.TransactionQuery.DisplayItems(1);
        }

        private void btnCancelTransaction_Click(object sender, EventArgs e)
        {
            if (orderList.Count == 0)
            {
                this.Close();
            }
            else
            {
                DialogResult cancelTransaction = MessageBox.Show("Are you sure you want to cancel transaction?", "Transaction Notification",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cancelTransaction == DialogResult.Yes)
                {
                    this.Close();
                }
            }

        }

        private void gridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewItems.CurrentCell.ColumnIndex == 3)
            {
                rowIndex = gridViewItems.CurrentCell.RowIndex;

                if (orderList.Contains(itemList[rowIndex]))
                {
                    MessageBox.Show("Item was already exist on order overview!", "Transaction Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    orderList.Add(itemList[rowIndex]);

                }

            }
            GC.Collect(); // optimization purposes
        }

        private void gridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
