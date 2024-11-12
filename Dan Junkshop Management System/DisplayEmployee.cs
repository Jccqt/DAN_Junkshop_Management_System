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
    public partial class DisplayEmployee : UserControl
    {
        public bool IsCollapsed;
        public DisplayEmployee()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed)
            {
                pnlSettings.Height += 10;

                if (pnlSettings.Size == pnlSettings.MaximumSize)
                {
                    timer1.Stop();
                    IsCollapsed = false;
                }
            }
            else
            {
                pnlSettings.Height -= 10;

                if (pnlSettings.Size == pnlSettings.MinimumSize)
                {
                    timer1.Stop();
                    IsCollapsed = true;
                }
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void DisplayEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
