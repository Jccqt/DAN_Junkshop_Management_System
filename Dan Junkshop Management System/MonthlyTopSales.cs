using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WebForms;
using System.IO;

namespace Dan_Junkshop_Management_System
{
    public partial class MonthlyTopSales : Form
    {
        public MonthlyTopSales()
        {
            InitializeComponent();
        }

        private void MonthlyTopSales_Load(object sender, EventArgs e)
        {
       
            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT S.SellableID, S.SellableName, SUM(P.Scale), SUM(P.Amount) FROM Pickups P " +
                "JOIN SellableItems S ON P.SellableID = S.SellableID WHERE MONTH(P.date) = 12 GROUP BY S.SellableID ,S.SellableName", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            List <Sales> sales = new List<Sales>();

            while(ConnectionObjects.reader.Read())
            {
                sales.Add(new Sales
                {
                    sellableid = ConnectionObjects.reader.GetString(0),
                    sellablename = ConnectionObjects.reader.GetString(1),
                    quantity = ConnectionObjects.reader.GetDecimal(2),
                    amount = ConnectionObjects.reader.GetDecimal(3)
                });
            }
         
            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();

            this.reportViewer1.LocalReport.ReportPath = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + @"\RLDC Reports\TopSales.rdlc";
            this.salesBindingSource.DataSource = sales;

            this.reportViewer1.RefreshReport();
        }
    }
}
