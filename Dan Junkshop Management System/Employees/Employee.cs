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
            Queries.EmployeeQuery.DisplayEmployee(1);
            GC.Collect();
        }
    }

}
