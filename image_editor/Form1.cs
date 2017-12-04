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
        const string formTitle = "untitled - image_editor";
        String Txt = " test ";
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
            //this.DragEnter += new DragEventHandler(Form1_DragEnter);
            //this.DragDrop += new DragEventHandler(Form1_DragDrop);
            image = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            graphics = Graphics.FromImage(image);
            selectedColor.BackColor = Color.Black;
            this.Text = formTitle;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] tmp = (string[])e.Data.GetData(DataFormats.FileDrop);
            pictureBox1.ImageLocation = tmp[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Text = System.IO.Path.GetFileNameWithoutExtension(tmp[0]);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBox1.Invalidate();
            this.Text = formTitle;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                this.Text = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Text.i
            if (this.Text == formTitle) saveAsToolStripMenuItem_Click(sender, e);
            else
            {
                if (ofd.FileName != "") image.Save(ofd.FileName);
                else image.Save(sfd.FileName);
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
                this.Text = System.IO.Path.GetFileNameWithoutExtension(sfd.FileName);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    graphics.DrawString(Txt, drawFont, drawBrush, startP);
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

                switch (tool)
                {
                    case 1:
                        graphics.DrawLine(new Pen(selectedColor.BackColor), startP, endP);
                        pictureBox1.Invalidate();
                        break;
                    case 4:
                        graphics.FillEllipse(new SolidBrush(selectedColor.BackColor), e.X, e.Y, (int)comboBox1.SelectedItem, (int)comboBox1.SelectedItem);
                        pictureBox1.Invalidate();
                        break;
                    case 5:
                        graphics.FillEllipse(new SolidBrush(Color.White), e.X, e.Y, 20, 20);
                        pictureBox1.Invalidate();
                        break;
                    default:
                        Console.WriteLine("ERROR: Unkwon tool");
                        break;
                }

                startP = endP;
                
            }

        }

        private void pencil_Click(object sender, EventArgs e)
        {
            tool = 1;
        }

        private void brush_Click(object sender, EventArgs e)
        {
            tool = 4;
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            tool = 5;
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
            Txt = textBox1.Text;

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
