using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_Junkshop_Management_System
{
    public class Sales
    {
        public string sellableid { get; set; }
        public string sellablename { get; set; }
        public decimal quantity { get; set; }
        public decimal amount { get; set; }
        public DateTime date { get; set; }
    }
}
