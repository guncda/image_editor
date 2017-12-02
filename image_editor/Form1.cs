using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace image_editor
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd;
        SaveFileDialog sfd;
        bool mouseHold = false;
        Point startP = new Point(0, 0);
        Point endP = new Point(0, 0);
        int x,
            y,
            cX,
            cY,
            dX,
            dY;
        Color color;
        int tool;
        Graphics graphics;
        Bitmap image;

        public Form1()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            sfd = new SaveFileDialog();
            ofd.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";
            sfd.Filter = ofd.Filter;
            color = Color.Black;
            image = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            graphics = Graphics.FromImage(image);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (mouseHold)
            {
                x = e.X;
                y = e.Y;
                dX = e.X - cX;
                dY = e.Y - cY;
            }
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            startP = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                mouseHold = true;
            }
            cX = e.X;
            cY = e.Y;
        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            mouseHold = false;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (mouseHold)
            {
                endP = e.Location;
                x = e.X;
                y = e.Y;

                switch (tool)
                {
                    case 1:
                        graphics.DrawLine(new Pen(color), startP, endP);
                        pictureBox1.Invalidate();
                        break;

                    default:
                        Console.WriteLine("ERROR: Unkwon tool");
                        break;
                }
                startP = endP;
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(image);
            Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, pictureBox1.Size);
            g.Dispose();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                image.Save(sfd.FileName);
            }
        }

        private void buttonPencil_Click(object sender, EventArgs e)
        {
            tool = 1;
        }

    }
}
