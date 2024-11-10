using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dan_Junkshop_Management_System.Components
{
    internal class RoundPictureBox : PictureBox
    {
        public RoundPictureBox() { 
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0,0,ClientSize.Width,ClientSize.Height);
            this.Region = new System.Drawing.Region(path);
            base.OnPaint(e);
        }
    }
}
