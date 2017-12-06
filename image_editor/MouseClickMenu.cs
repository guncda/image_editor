using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace image_editor
{
    class MouseClickMenu : System.Windows.Forms.ContextMenu
    {

        PictureBox picture;
        Rectangle src;
        Graphics graphics;

        public MouseClickMenu(PictureBox p, Rectangle r, Graphics g)
        {
            this.graphics = g;
            this.picture = p;
            this.src = r;

            this.MenuItems.Add("Copy", new EventHandler(copy));
            this.MenuItems.Add("Paste", new EventHandler(paste));
        }

        private void copy(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(src.Width, src.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    Rectangle r = new Rectangle(0, 0, src.Width, src.Height);
                    g.DrawImage(picture.Image, r, src, GraphicsUnit.Pixel);
                }
                Clipboard.SetImage(bmp);
            }
            catch (ArgumentNullException a) { }
        }

        private void paste(object sender, EventArgs e)
        {
            Image i = Clipboard.GetImage();
            if (i == null) return;

            graphics.DrawImage(i, new Point(0, 0));
            picture.Invalidate();
        }

    }
}
