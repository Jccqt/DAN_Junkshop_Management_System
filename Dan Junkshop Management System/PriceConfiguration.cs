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
    public partial class PriceConfiguration : UserControl
    {
        static PriceConfigurationContent content = new PriceConfigurationContent();
        
        public PriceConfiguration()
        {
            this.Anchor = AnchorStyles.Top;
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(content);


        }

        private void panelBorder1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
           
          
            
        }
    }
}
