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
    public partial class ActivityLog : UserControl
    {
        public ActivityLog()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Dock = DockStyle.Fill;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersHeight = 50;
            dataGridView2.RowHeadersWidth = 50;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }
    }
}
