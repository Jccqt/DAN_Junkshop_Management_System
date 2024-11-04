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
    public partial class Homepage : Form
    {
        
        static Dashboard dashboard;
       
        public Homepage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          dashboard = new Dashboard();

          panel1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
          panel1.Dock = DockStyle.Fill;
          
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
  
}
