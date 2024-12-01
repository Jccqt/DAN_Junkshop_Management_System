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
    public partial class Partners : UserControl
    {
        public Partners()
        {
            InitializeComponent();
            // TODO: Adding the display partners on the partners panel.
        }

        private void btnAddPartners_Click(object sender, EventArgs e)
        {
            using(PageObjects.addPartner = new frmAddingPartner())
            {
                using(Form form = new Form())
                {
                    FormAnimation.ShowFocus(form);
                    PageObjects.addPartner.Owner = form;
                    PageObjects.addPartner.ShowDialog();
                    form.Close();
                }
            }
        }
    }
}
