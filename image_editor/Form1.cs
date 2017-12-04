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
        String Text = " test ";
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
            image = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            graphics = Graphics.FromImage(image);
            selectedColor.BackColor = Color.Black; ;
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
            switch (tool)
            {
                case 3:
                    
                   
                    Font drawFont = new Font("Arial", 16);
                    SolidBrush drawBrush = new SolidBrush(Color.Black);
                    graphics.DrawString(Text, drawFont, drawBrush, startP);
                    pictureBox1.Invalidate();
                    break;

            }

        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            mouseHold = false;
            switch (tool)
            {
                case 2:
                    Rectangle rec = new Rectangle(startP.X, startP.Y, Math.Abs(e.X - startP.X), Math.Abs(e.Y - startP.Y));
                    graphics.DrawRectangle(new Pen(selectedColor.BackColor), rec);
                    pictureBox1.Invalidate();
                    break;

            }
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (mouseHold)
            {
                endP = e.Location;
                x = e.X;
                y = e.Y;
                pictureBox1.Invalidate();
                switch (tool)
                {
                    case 1:
                        graphics.DrawLine(new Pen(selectedColor.BackColor), startP, endP);
                        pictureBox1.Invalidate();
                        startP = endP;
                        break;
                    case 2:
                       
                        break;
                    default:
                        Console.WriteLine("ERROR: Unkwon tool");
                        break;
                }
                
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

        public void btnBlack_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Black;
        }

        protected void btnGray50_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Gray;
        }

        private void btnDarkRed_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.DarkRed;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Red;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Orange;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Yellow;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Green;
        }

        private void btnTurquoise_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Turquoise;
        }

        private void btnIndigo_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Blue;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Purple;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.White;
        }

        private void btnGray25_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.LightGray;
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Brown;
        }

        private void btnRose_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Pink;
        }

        private void btnGolden_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Gold;
        }

        private void btnLightYellow_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.LightYellow;
        }

        private void pencil_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tool = 2;
        }

        private void DrawText_Click(object sender, EventArgs e)
        {
            tool = 3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Text = textBox1.Text;

        }

        private void btnLime_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Lime;
        }

        private void btnLigthCyan_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.PaleTurquoise;
        }

        private void btnBlueGray_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.CadetBlue;
        }

        private void btnLavender_Click(object sender, EventArgs e)
        {
            selectedColor.BackColor = Color.Lavender;
        }

        private void colorPalette_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.ShowHelp = true;
            cd.Color = selectedColor.BackColor;
            //cd.Color = textBox1.ForeColor;

            if (cd.ShowDialog() == DialogResult.OK)
                selectedColor.BackColor = cd.Color;
        }

    }
}
