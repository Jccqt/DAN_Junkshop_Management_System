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
    public partial class Inventory : UserControl
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            
        }

        public static implicit operator Inventory(HeaderWText v)
        {
            throw new NotImplementedException();
        }
    }
}
