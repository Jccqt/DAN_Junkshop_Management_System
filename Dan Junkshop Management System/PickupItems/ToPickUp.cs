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
    public partial class ToPickUp : UserControl
    {
        public ToPickUp()
        {
            InitializeComponent();
        }

        public DataGridView PickupGrid { get { return gridPickups; } }

        private void btnAddPickup_Click(object sender, EventArgs e)
        {
            using(PageObjects.addPickup = new frmAddPickUp())
            {
                using(Form form = new Form())
                {
                    FormAnimation.ShowFocus(form);
                    PageObjects.addPickup.Owner = form;
                    PageObjects.addPickup.ShowDialog();
                    form.Close();
                }
            }
            Queries.PickupQuery.DisplayPickups();
            GC.Collect(); // optimization purposes
        }

        private void ToPickUp_Load(object sender, EventArgs e)
        {
            Queries.PickupQuery.DisplayPickups();
        }
    }
}
