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
    public partial class Delivery : UserControl
    {
        public DataGridView DeliveryGrid { get { return gridDeliverables; } }
        public DataGridView VehicleGrid { get { return gridVehicles; } }

        public Delivery()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Dock = DockStyle.Fill;
          
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            Queries.DeliveryQuery.DisplayDeliverables();
        }
    }
}
