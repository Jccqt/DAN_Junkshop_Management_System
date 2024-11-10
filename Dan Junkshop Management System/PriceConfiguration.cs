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
        
        
        public PriceConfiguration()
        {
            InitializeComponent();
            PriceConfigurationContent content = new PriceConfigurationContent();
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            flowLayoutPanel1.Controls.Add(content);
           

        }
    }
}
