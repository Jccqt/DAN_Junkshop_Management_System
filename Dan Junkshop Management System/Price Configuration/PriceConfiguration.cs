using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dan_Junkshop_Management_System
{
    public partial class PriceConfiguration : UserControl
    {
        
        
        public PriceConfiguration()
        {
            InitializeComponent();
         
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Dock = DockStyle.Fill;
         
           

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using(PageObjects.addItemPrice = new frmAddItemPriceConfig())
            {
                using(Form form = new Form())
                {
                    FormAnimation.ShowFocus(form);
                    PageObjects.addItemPrice.Owner = form;
                    PageObjects.addItemPrice.ShowDialog();
                    form.Close();
                    showItemClasses();
                }
            }
        }

        private void PriceConfiguration_Load(object sender, EventArgs e)
        {
            showItemClasses();
        }

        void showItemClasses()
        {
            ConnectionObjects.dataTable = new DataTable();
            ConnectionObjects.dataTable.Columns.Add("Class Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Plant Price", typeof(double));
            ConnectionObjects.dataTable.Columns.Add("Capital", typeof(double));
            ConnectionObjects.dataTable.Columns.Add("Required scale for delivery", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Edit", typeof(Image));

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassName, ItemClassPlantPrice, " +
                "ItemClassCapital, ItemClassRequiredScale FROM ItemClass", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while(ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0),
                    ConnectionObjects.reader.GetDecimal(1), ConnectionObjects.reader.GetDecimal(2), ConnectionObjects.reader.GetDecimal(3) + "kg",
                    Dan_Junkshop_Management_System.Properties.Resources.icon_park_solid_edit);
            }

            gridViewItemClass.DataSource = ConnectionObjects.dataTable;

            gridViewItemClass.AutoResizeColumn(4, DataGridViewAutoSizeColumnMode.AllCells);

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }
    }
}
