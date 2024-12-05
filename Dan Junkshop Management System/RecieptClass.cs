using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System
{
    internal class RecieptClass
    {
//        e.PageSettings.PaperSize = new PaperSize("Receipt", 10, 0);

//        string dashline = "===========================================";
//        //for logo
//        Bitmap bitmap = Properties.Resources.forReceiptLogo;
//        System.Drawing.Image image = bitmap;
//        e.Graphics.DrawImage(image, 100, 25, 200, 110);

//            //add the line to the center header
//            e.Graphics.DrawString("Tabang Guiguinto Bulacan", new Font("Arial", 12), Brushes.Black, new Point(110, 150));
//            e.Graphics.DrawString("Contact #: 0999999999999", new Font("Arial", 12), Brushes.Black, new Point(110, 170));
//            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, 200));

//            //Labels
//            e.Graphics.DrawString("Cashier:         " +"<Cashier name>" , new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 220));
//            e.Graphics.DrawString("Transaction ID:         " + "<ID>", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 240));
//            e.Graphics.DrawString("Date:         " + DateTime.Now, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 260));

//            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, 285));

       
//            e.Graphics.DrawString("Item", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 300));
//            e.Graphics.DrawString("Kilo", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(110, 300));
//            e.Graphics.DrawString("Price", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(200, 300));
//            e.Graphics.DrawString("Subtotal", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(290, 300));
//            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, 310));

//            //textbox
//            //e.Graphics.DrawString("<item name>", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(25, 340));
//            //e.Graphics.DrawString("<Kilo>", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(110, 340));
//            //e.Graphics.DrawString("Price", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(200, 340));
//            //e.Graphics.DrawString("Subtotal", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(290, 340));

//            int startY = 350;
//        int pageHeight = e.MarginBounds.Height;
//        int itemPerPage = pageHeight / 25;
//        bool isDashedLineDrawn = false;

//            for (int i = currentPrintRow; i<listOfClubMembers.Rows.Count; i++)
//            {
//                if (i - currentPrintRow >= itemPerPage)
//                {
//                    e.HasMorePages = true; // more items to be printed
//                    currentPrintRow = i;
//                    return;
//                }
//    //dito mag add ng mga laman na i p-print
//    DataGridViewRow row = listOfClubMembers.Rows[i];
//                if (row.Cells["FirstName"].Value != null)
//                {
//                    string itemDesc = row.Cells["FirstName"].Value.ToString();
//    string prog = row.Cells["Program"].Value.ToString();
//    e.Graphics.DrawString(itemDesc.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(25, startY));
//                    e.Graphics.DrawString(prog.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(290, startY));
                            

//                    startY += 22;
//                }
//            }
//            //Will automatically calculate the dashline position after adding all of the item in the page
//            int dashlineY = startY;
//e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, dashlineY));
//e.HasMorePages = false;

//e.Graphics.DrawString("Total", new Font("Arial Black", 12, FontStyle.Regular), Brushes.Black, new Point(25, dashlineY + 22));
//e.Graphics.DrawString("<Total>", new Font("Arial Black", 12, FontStyle.Regular), Brushes.Black, new Point(290, dashlineY + 22));//dito dapat yung total nung pinagbentahan
//e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, dashlineY + 42));
//e.Graphics.DrawString("Thank You!", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(150, dashlineY + 62));
//        }
        

//        private void btnPrint_Click(object sender, EventArgs e)
//{
//    try
//    {
//        PrintPreviewDialog printPreview = new PrintPreviewDialog();
//        printPreview.Document = printDocument1;
//        printPreview.ShowDialog();
//    }
//    catch
//    {
//    }
}
    }

