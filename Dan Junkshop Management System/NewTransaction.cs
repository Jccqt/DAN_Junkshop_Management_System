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
    public partial class NewTransaction : Form
    {
        public NewTransaction()
        {
            InitializeComponent();
            TransactionSoldItems transactionSoldItems = new TransactionSoldItems();
            flowLayoutPanel1.Controls.Add(transactionSoldItems);

           
        }

 

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           this.Close();
           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (AddingSellableItems addingSellableItems = new AddingSellableItems())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .80;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();
                    addingSellableItems.Owner = formBackground;
                    DialogResult ds = addingSellableItems.ShowDialog();
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
