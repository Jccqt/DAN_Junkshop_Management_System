using Dan_Junkshop_Management_System.Deliveries;
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
    public partial class frmAddingVehicle : Form
    {
        public frmAddingVehicle()
        {
            InitializeComponent();
        }

        private void frmAddingVehicle_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            if (txtCapacity.Text == "")
            {
                txtCapacity.Text = "0.00";
            }

            txtPlateNumber.Text = txtCapacity.Text.Trim().ToUpper();

            VehicleDetails details = new VehicleDetails
            {
                VehicleName = txtVehicleName.Text,
                PlateNumber = txtPlateNumber.Text,       
                Capacity = Convert.ToDecimal(txtCapacity.Text)
            };

            if(Queries.VehicleQuery.VehicleDetailsChecker(details) && !Queries.VehicleQuery.VehicleExistChecker(details))
            {
                Queries.VehicleQuery.GetVehicleIDCount();
                Queries.VehicleQuery.AddVehicle(details);

                clearVehicleDetails();

                MessageBox.Show("Vehicle has been successfully added!", "Vehicle Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                details = null;
                this.Close();
            }
        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.FloatingNumbersOnly(sender, e);
        }

        void clearVehicleDetails()
        {
            txtVehicleName.Clear();
            txtPlateNumber.Clear();
            txtCapacity.Clear();
        }
    }
}
