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

        public Button EditButton { get { return btnEdit; } }
    }
}
