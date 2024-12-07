using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_Junkshop_Management_System.PickupItems
{
    public class PickupDetails
    {
        public string PickupID { get; set; }
        public string SellableID { get; set; }
        public string PartnerID { get; set; }
        public decimal ScaleQuantity { get; set; }
        public decimal Amount { get; set; }
    }
}
