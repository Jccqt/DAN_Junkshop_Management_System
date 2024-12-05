using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System
{
    public partial class Transaction : UserControl
    {

        public DataGridView TransactionGrid { get { return gridTransactions; } }

        public Transaction()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            //setting the height and the background color of the header.
            
            gridTransactions.EnableHeadersVisualStyles = false;
            gridTransactions.ColumnHeadersHeight = 50;
            gridTransactions.RowHeadersWidth = 50;
            gridTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            using(PageObjects.newBuyTransaction = new frmNewTransaction())
            {
                using(Form form = new Form())
                {
                    FormAnimation.ShowFocus(form);
                    PageObjects.newBuyTransaction.Owner = form;
                    PageObjects.newBuyTransaction.ShowDialog();
                    form.Close();
                }
            }
        }

        private void gridTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            Queries.TransactionQuery.DisplayTransactions();
        }
    }
}
