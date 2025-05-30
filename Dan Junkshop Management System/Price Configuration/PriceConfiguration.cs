﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Dan_Junkshop_Management_System
{
    public partial class PriceConfiguration : UserControl
    {
        ArrayList itemClassList = new ArrayList();
        int rowIndex;

        public string ItemClassName { get { return itemClassList[rowIndex].ToString(); } }
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
            itemClassList.Clear();

            ConnectionObjects.dataTable = new DataTable();
            ConnectionObjects.dataTable.Columns.Add("Class Name", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Plant Price\\kg", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Buy price\\kg", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Profit\\kg", typeof(string));
            ConnectionObjects.dataTable.Columns.Add("Edit", typeof(Image));

            ConnectionObjects.conn.Open();

            ConnectionObjects.cmd = new SqlCommand("SELECT ItemClassName, ItemClassPlantPrice, " +
                "ItemClassProfit FROM ItemClass", ConnectionObjects.conn);
            ConnectionObjects.reader = ConnectionObjects.cmd.ExecuteReader();

            while(ConnectionObjects.reader.Read())
            {
                ConnectionObjects.dataTable.Rows.Add(ConnectionObjects.reader.GetString(0),
                    "PHP " + ConnectionObjects.reader.GetDecimal(1), 
                   "PHP " + (ConnectionObjects.reader.GetDecimal(1) - ConnectionObjects.reader.GetDecimal(2)), "PHP " + ConnectionObjects.reader.GetDecimal(2), 
                    Dan_Junkshop_Management_System.Properties.Resources.icon_park_solid_edit);

                itemClassList.Add(ConnectionObjects.reader.GetString(0));
            }

            gridViewItemClass.DataSource = ConnectionObjects.dataTable;

            gridViewItemClass.AutoResizeColumn(4, DataGridViewAutoSizeColumnMode.AllCells);
            
            foreach(DataGridViewColumn column in gridViewItemClass.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            ConnectionObjects.reader.Close();
            ConnectionObjects.conn.Close();
            ConnectionObjects.dataTable = null;
        }

        private void gridViewItemClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridViewItemClass.Rows.Count > 0)
            {
                if(gridViewItemClass.CurrentCell.ColumnIndex == 4)
                {
                    rowIndex = gridViewItemClass.CurrentCell.RowIndex;

                    using(PageObjects.editItemPrice = new frmEditPriceConfigItem())
                    {
                        using(Form form = new Form())
                        {
                            FormAnimation.ShowFocus(form);
                            PageObjects.editItemPrice.Owner = form;
                            PageObjects.editItemPrice.ShowDialog();
                            form.Close();
                        }
                    }
                    showItemClasses();
                    GC.Collect();
                }
            }
        }
    }
}
