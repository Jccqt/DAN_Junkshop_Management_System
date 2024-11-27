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
    public partial class frmAddingItemSelection : Form
    {
        public frmAddingItemSelection()
        {
            InitializeComponent();
        }

        private void btnNewSellTransaction_Click(object sender, EventArgs e)
        {

        }

        private void frmAddingItemSelection_Load(object sender, EventArgs e)
        {
            this.Owner = FormAnimation.formBackground;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
