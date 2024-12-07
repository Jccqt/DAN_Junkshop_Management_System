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
        private string partnerID;

        public string PartnerID { get { return partnerID; } }
        public FlowLayoutPanel PartnersFLP { get { return PartnersPanel; } }
        public EventHandler ClickEdit { get { return EditPartner_Click; } }

        public Partners()
        {
            InitializeComponent();
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

        private void EditPartner_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            partnerID = btn.Tag.ToString();

            using(PageObjects.editPartner = new frmEditPartners())
            {
                using(Form form = new Form())
                {
                    FormAnimation.ShowFocus(form);
                    PageObjects.editPartner.Owner = form;
                    PageObjects.editPartner.ShowDialog();
                    form.Close();
                }
            }
            
        }

        private void Partners_Load(object sender, EventArgs e)
        {
            Queries.PartnerQuery.DisplayPartners(1);
        }
    }
}
