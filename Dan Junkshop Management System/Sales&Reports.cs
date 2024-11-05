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
    public partial class Sales_Reports : UserControl
    {
        static SalesHeader salesHeader = new SalesHeader();
        static TopSalesContent salesContent = new TopSalesContent();
        
        public Sales_Reports()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

           

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void Sales_Reports_Load(object sender, EventArgs e)
        {
           
        }

        private void transactionButton_Click(object sender, EventArgs e)
        { 
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(salesHeader.transactionHeader);
            flowLayoutPanel1.Controls.Add(salesContent.TransactionTblContent);
            topSaleButton.BackColor = Color.White;
            topSaleButton.ForeColor = Color.Black;
            deliveryButton.BackColor = Color.White;
            deliveryButton.ForeColor = Color.Black;
            transactionButton.ForeColor = Color.White;
            transactionButton.BackColor = Color.FromArgb(255, 83, 87);     
        }

        private void topSaleButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(salesHeader.TopSaleHeader);
            flowLayoutPanel1.Controls.Add(salesContent.topSalePanel);
            transactionButton.BackColor = Color.White;
            transactionButton.ForeColor = Color.Black;
            deliveryButton.BackColor = Color.White;
            deliveryButton.ForeColor = Color.Black;
            topSaleButton.ForeColor = Color.White;
            topSaleButton.BackColor = Color.FromArgb(255, 83, 87);
        }

        private void deliveryButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(salesHeader.deliveryHeader);
            flowLayoutPanel1.Controls.Add(salesContent.deliveryTblContent);
            transactionButton.BackColor = Color.White;
            transactionButton.ForeColor = Color.Black;
            topSaleButton.BackColor = Color.White;
            topSaleButton.ForeColor = Color.Black;
            deliveryButton.ForeColor = Color.White;
            deliveryButton.BackColor = Color.FromArgb(255, 83, 87);
        }
    }
}
