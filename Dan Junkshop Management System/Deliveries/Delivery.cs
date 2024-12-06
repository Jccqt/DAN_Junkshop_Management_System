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


        public Delivery()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Dock = DockStyle.Fill;
          
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            Queries.DeliveryQuery.DisplayDeliverables();
            Queries.VehicleQuery.DisplayVehicles();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            using(PageObjects.addVehicle = new frmAddingVehicle())
            {
                using(Form form = new Form())
                {
                    FormAnimation.ShowFocus(form);
                    PageObjects.addVehicle.Owner = form;
                    PageObjects.addVehicle.ShowDialog();
                    form.Close();
                }
            }
            Queries.VehicleQuery.DisplayVehicles();
            GC.Collect(); // optimization purposes
        }

        private void gridDeliverables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridDeliverables.Rows.Count > 0)
            {
                if(gridDeliverables.CurrentCell.ColumnIndex == 4)
                {

                    using(PageObjects.deliveryDetails = new frmDeliveryDetails())
                    {
                        using(Form form = new Form())
                        {
                            FormAnimation.ShowFocus(form);
                            PageObjects.deliveryDetails.Owner = form;
                            PageObjects.deliveryDetails.ShowDialog();
                            form.Close();
                        }
                    }
                    GC.Collect(); // optimization purposes
                }
            }
        }
    }
}
