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
            this.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
        }

        private void btnAddScrapsItem_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (frmAddingItem addScrap = new frmAddingItem())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .80;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();
                    addScrap.Owner = formBackground;
                    DialogResult ds = addScrap.ShowDialog();
                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { formBackground.Dispose(); }
        }
    }
}
