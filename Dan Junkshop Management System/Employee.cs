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

            flpDisplayEmp.Controls.Add(displayEmployee);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (frmAddNewEmployee addNewEmployee = new frmAddNewEmployee())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .80;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();
                    addNewEmployee.Owner = formBackground;
                    DialogResult ds = addNewEmployee.ShowDialog();
                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { formBackground.Dispose(); }
        }
    }
}
