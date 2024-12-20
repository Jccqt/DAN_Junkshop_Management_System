using Dan_Junkshop_Management_System.Transactions;
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
        string id;

        public DataGridView TransactionGrid { get { return gridTransactions; } }
        public string TransactionID { get { return id; } }

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
            Queries.TransactionQuery.DisplayTransactions();
        }

        private void gridTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridTransactions.Rows.Count > 0)
            {
                if(gridTransactions.CurrentCell.ColumnIndex == 6)
                {
                    id = gridTransactions.Rows[gridTransactions.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    Console.WriteLine(id);
                    using(ReceiptView receiptPage = new ReceiptView())
                    {
                        using(Form form = new Form())
                        {
                            FormAnimation.ShowFocus(form);
                            receiptPage.Owner = form;
                            receiptPage.ShowDialog();
                            form.Close();
                        }
                    }
                }
            }
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            Queries.TransactionQuery.DisplayTransactions();
        }
    }
}
