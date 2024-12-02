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
        public Transaction()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.Dock = DockStyle.Fill;
            //setting the height and the background color of the header.
            
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            using(PageObjects.newBuyTransaction = new frmNewBuyTransaction())
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
    }
}
