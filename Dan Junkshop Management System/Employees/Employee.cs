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
using Dan_Junkshop_Management_System.Employees;

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

        public string EmployeeID { get { return empId; } }
        public FlowLayoutPanel EmpFLP { get { return EmployeePanel; } }
        public EventHandler ClickEdit { get { return EditEmployee_Click; } }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (PageObjects.addEmployee = new frmAddingEmployee())
            {
                using(Form form = new Form())
                {
                    FormAnimation.ShowFocus(form);
                    PageObjects.addEmployee.Owner = form;
                    PageObjects.addEmployee.ShowDialog();
                    form.Close();
                }
            }
            Queries.EmployeeQuery.DisplayEmployee(1);
           
            GC.Collect();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Active Employees";
            btnAddEmployee.Visible = true;
            Queries.EmployeeQuery.DisplayEmployee(1);
        }


        private void EditEmployee_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(PageObjects.homepage.EmpID == btn.Tag.ToString())
            {
                MessageBox.Show("You cannot edit your own details since you are currently logged in", "Employee Notification", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                empId = btn.Tag.ToString();
                using (PageObjects.editEmployee = new frmEditEmployee())
                {
                    using (Form form = new Form())
                    {
                        FormAnimation.ShowFocus(form);
                        PageObjects.editEmployee.Owner = form;
                        PageObjects.editEmployee.ShowDialog();
                        form.Close();
                    }
                }
                if (lblStatus.Text == "Active Employees")
                {
                    Queries.EmployeeQuery.DisplayEmployee(1);
                }
                else
                {
                    Queries.EmployeeQuery.DisplayEmployee(0);
                }

                GC.Collect();
            }

            
        }

        private void btnSwitchStatus_Click(object sender, EventArgs e)
        {
            if (!btnSwitchStatus.Checked)
            {
                lblStatus.Text = "Inactive Employees";
                btnAddEmployee.Visible = false;
                Queries.EmployeeQuery.DisplayEmployee(0);
            }
            else
            {
                lblStatus.Text = "Active Employees";
                btnAddEmployee.Visible = true;
                Queries.EmployeeQuery.DisplayEmployee(1);
            }
        }
    }

}
