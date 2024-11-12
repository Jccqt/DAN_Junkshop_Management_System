using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System
{
    public partial class frmAddNewEmployee : Form
    {
        public frmAddNewEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult employeeExit = MessageBox.Show("Are you sure you want to cancel adding employee?"
                                            + "\nAny unsaved changes cannot be recovered!", "Cancel Adding Employee", 
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(employeeExit == DialogResult.Yes)
            {
                this.Close(); // will exit the page for adding employee
            }
        }

        private void frmAddNewEmployee_Load(object sender, EventArgs e)
        {
            // will set the maximun date to 18 years old and above for dtBirthDate picker 
            // and will not show the dates that is below 18 years old
            ConnectionObjects.conn.Open();

            var localDate = DateTime.Now.ToString("yyyy-MM-dd");

            ConnectionObjects.cmd = new SqlCommand("SELECT DATEADD(year, -18, @currentDate)", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@currentDate", localDate);
            var legalAge = Convert.ToDateTime(ConnectionObjects.cmd.ExecuteScalar());

            dtBirthDate.MaxDate = legalAge;

            ConnectionObjects.conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult clearEmployee = MessageBox.Show("Are you sure you want to clear employee details?",
                                                        "Clear Details", MessageBoxButtons.YesNo, 
                                                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(clearEmployee == DialogResult.Yes)
            {
                ClearDetails(); // will clear employee details
            }
        }

        void ClearDetails()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleInitial.Clear();
            txtContact.Clear();
            cbPosition.SelectedIndex = -1;
            dtBirthDate.Value = DateTime.Now;
            cbGender.SelectedIndex = -1;
            txtUsername.Clear();
            txtPassword.Clear();
            txtAddress.Clear();
        }
    }
}
