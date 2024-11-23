using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System
{
    public partial class Employee : UserControl
    {
        public Employee()
        {
            InitializeComponent();

            // will set the size and position of the components
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Dock = DockStyle.Fill;
        
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

        private void Employee_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Active Employees";
            btnAddEmployee.Visible = true;

            EmployeePanel.Controls.Clear();

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT FirstName, MiddleName, LastName, EmpID, Position, Contact FROM Employees WHERE Status = 1", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while(ConnectionObjects.reader.Read())
            {
                DisplayEmployee displayEmployee = new DisplayEmployee();

                displayEmployee.lblFullName.Text = $"{ConnectionObjects.reader.GetValue(0).ToString()} {ConnectionObjects.reader.GetValue(1).ToString()} {ConnectionObjects.reader.GetValue(2).ToString()}";
                displayEmployee.lblEmployeeID.Text = ConnectionObjects.reader.GetValue(3).ToString();
                displayEmployee.lblPosition.Text = ConnectionObjects.reader.GetValue(4).ToString();
                displayEmployee.lblContact.Text = ConnectionObjects.reader.GetValue(5).ToString();

                EmployeePanel.Controls.Add(displayEmployee);
            }

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            GC.Collect();
        }
    }
}
