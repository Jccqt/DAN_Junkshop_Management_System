using Dan_Junkshop_Management_System.RLDC_Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System.Transactions
{
    public partial class ReceiptView : Form
    {
        public ReceiptView()
        {
            InitializeComponent();
        }

        private void ReceiptView_Load(object sender, EventArgs e)
        {

            ConnectionObjects.conn.Open();

            this.reportViewer1.LocalReport.ReportPath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + @"\RLDC Reports\TransactionReport.rdlc";

            List<TransactionReceipt> receiptDetails = new List<TransactionReceipt>();

            ConnectionObjects.cmd = new SqlCommand("SELECT E.FirstName, E.MiddleName, E.LastName, T.TransactionType, T.TransactionQuantity, " +
                "T.TransactionAmount, T.TransactionDate FROM Transactions T JOIN Employees E ON T.EmpID = E.EmpID WHERE T.TransactionID = @transactionid", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@transactionid", PageObjects.transaction.TransactionID);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            if (ConnectionObjects.reader.Read())
            {
                receiptDetails.Add(new TransactionReceipt
                {
                    EmployeeName = $"{ConnectionObjects.reader.GetString(0)} {ConnectionObjects.reader.GetString(1)} {ConnectionObjects.reader.GetString(2)}",
                    TransactionID = PageObjects.transaction.TransactionID,
                    TransactionType = ConnectionObjects.reader.GetString(3),
                    TotalQuantity = ConnectionObjects.reader.GetInt32(4),
                    TotalAmount = ConnectionObjects.reader.GetDecimal(5),
                    TransactionDate = ConnectionObjects.reader.GetDateTime(6)
                });
            }

            this.transactionReceiptBindingSource.DataSource = receiptDetails;

            ConnectionObjects.reader.Close();

            ConnectionObjects.cmd = new SqlCommand("SELECT I.ItemName, I.Scale, I.Subtotal FROM Transactions " +
                "CROSS APPLY OPENJSON(Items, '$.Items') " +
                "WITH (ItemName NVARCHAR(50) '$.Item', Scale decimal(18,2) '$.Scale', Subtotal decimal(18,2) '$.Subtotal') I WHERE TransactionID = @transactionid", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@transactionid", PageObjects.transaction.TransactionID);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            List<TransactionItems> items = new List<TransactionItems>();

            while (ConnectionObjects.reader.Read())
            {
                items.Add(new TransactionItems
                {
                    ItemName = ConnectionObjects.reader.GetString(0),
                    ItemScale = ConnectionObjects.reader.GetDecimal(1),
                    ItemSubTotal = ConnectionObjects.reader.GetDecimal(2)
                });
            }
            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();

            this.transactionItemsBindingSource.DataSource = items;

            this.reportViewer1.RefreshReport();
        }
    }
}
