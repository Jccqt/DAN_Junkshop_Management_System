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
    public partial class Employee : UserControl
    {
        public Employee()
        {
            InitializeComponent();
            DisplayEmployee displayEmployee = new DisplayEmployee();

            EmployeePanel.Controls.Add(displayEmployee);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (frmAddNewEmployee addEmployee = new frmAddNewEmployee())
            {
                FormAnimation.ShowFocus();
                addEmployee.Owner = FormAnimation.formBackground;
                addEmployee.ShowDialog();
                FormAnimation.formBackground.Close();
            }
        }
    }
}
