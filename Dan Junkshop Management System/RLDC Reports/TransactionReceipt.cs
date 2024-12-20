using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_Junkshop_Management_System.RLDC_Reports
{
    public class TransactionReceipt
    {
        public string TransactionID {  get; set; }
        public string EmployeeName { get; set; }
        public string TransactionType { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
