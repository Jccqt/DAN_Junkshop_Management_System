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
using System.Collections;

namespace Dan_Junkshop_Management_System
{
    public partial class Employee : UserControl
    {
        private string empId;
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
            // Optimize: Add employee page need GC.Collect
            using (frmAddingEmployee addEmployee = new frmAddingEmployee())
            {
                using(Form form = new Form())
                {
                    FormAnimation.ShowFocus(form);
                    addEmployee.Owner = form;
                    addEmployee.ShowDialog();
                    form.Close();
                    displayEmployees(1);
                }
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Active Employees";
            btnAddEmployee.Visible = true;
            displayEmployees(1);
        }

        void displayEmployees(int status)
        {
            EmployeePanel.Controls.Clear();

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT EmpID, FirstName, MiddleName, LastName, EmpID, Position, Contact FROM Employees WHERE Status = @status", ConnectionObjects.conn);
            ConnectionObjects.cmd.Parameters.AddWithValue("@status", status);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while (ConnectionObjects.reader.Read())
            {
                DisplayEmployee displayEmployee = new DisplayEmployee();

                displayEmployee.EditButton.Tag = ConnectionObjects.reader.GetString(0);
                displayEmployee.lblFullName.Text = $"{ConnectionObjects.reader.GetValue(1).ToString()} {ConnectionObjects.reader.GetValue(2).ToString()} {ConnectionObjects.reader.GetValue(3).ToString()}";
                displayEmployee.lblEmployeeID.Text = ConnectionObjects.reader.GetValue(4).ToString();
                displayEmployee.lblPosition.Text = ConnectionObjects.reader.GetValue(5).ToString();
                displayEmployee.lblContact.Text = ConnectionObjects.reader.GetValue(6).ToString();

                EmployeePanel.Controls.Add(displayEmployee);

                displayEmployee.EditButton.Click += new EventHandler(EditEmployee_Click);
            }

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            GC.Collect();
        }

        private void EditEmployee_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            empId = btn.Tag.ToString();
            using(PageObjects.editEmployee = new frmEditEmployee())
            {
                using(Form form = new Form())
                {
                    FormAnimation.ShowFocus(form);
                    PageObjects.editEmployee.Owner = form;
                    PageObjects.editEmployee.ShowDialog();
                    form.Close();
                }
            }
        }
    }

}
