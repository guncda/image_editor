using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows; 



namespace image_editor
{
    public partial class Form1 : Form
    {
        const string formTitle = "untitled - image_editor";
        String Txt = " ";
        OpenFileDialog ofd;
        SaveFileDialog sfd;
        bool mouseHold = false;
        Point startP = new Point(0, 0);
        Point startPRec = new Point(0, 0);
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
        Rectangle selectedArea;
        Rectangle drawingArea;
        Bitmap selectedBitmap;
        bool moveSelection = false;
        int contrast_value = 0;
        int brightness = 0;
        String fileName = "";
        int cntSelect = 0;

        PictureBox image2 = new PictureBox();

        public Form1()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            sfd = new SaveFileDialog();
            ofd.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";
            sfd.Filter = ofd.Filter;
            image = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            graphics = Graphics.FromImage(image);
            selectedColor.BackColor = Color.Black;
            this.Text = formTitle;
            comboBox1.SelectedIndex = 1;
        }
        public void SetContrast(double contrast)
        {
            Bitmap temp = (Bitmap)image;
            Bitmap bmap = (Bitmap)temp.Clone();
            if (contrast < -100) contrast = -100;
            if (contrast > 100) contrast = 100;
            contrast = (100.0 + contrast) / 100.0;
            contrast *= contrast;
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    double pR = c.R / 255.0;
                    pR -= 0.5;
                    pR *= contrast;
                    pR += 0.5;
                    pR *= 255;
                    if (pR < 0) pR = 0;
                    if (pR > 255) pR = 255;

                    double pG = c.G / 255.0;
                    pG -= 0.5;
                    pG *= contrast;
                    pG += 0.5;
                    pG *= 255;
                    if (pG < 0) pG = 0;
                    if (pG > 255) pG = 255;

                    double pB = c.B / 255.0;
                    pB -= 0.5;
                    pB *= contrast;
                    pB += 0.5;
                    pB *= 255;
                    if (pB < 0) pB = 0;
                    if (pB > 255) pB = 255;

                    bmap.SetPixel(i, j,
        Color.FromArgb((byte)pR, (byte)pG, (byte)pB));
                }
            }
            image = (Bitmap)bmap.Clone();
        }

        public void SetBrightness(int brightness)
        {
            
            Bitmap temp = (Bitmap)image;
            Bitmap bmap = (Bitmap)temp.Clone();
            if (brightness < -255) brightness = -255;
            if (brightness > 255) brightness = 255;
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    int cR = c.R + brightness;
                    int cG = c.G + brightness;
                    int cB = c.B + brightness;

                    if (cR < 0) cR = 1;
                    if (cR > 255) cR = 255;

                    if (cG < 0) cG = 1;
                    if (cG > 255) cG = 255;

                    if (cB < 0) cB = 1;
                    if (cB > 255) cB = 255;

                    bmap.SetPixel(i, j, Color.FromArgb((byte)cR, (byte)cG, (byte)cB));
                }
            }
            image = (Bitmap)bmap.Clone();
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
            System.Drawing.Image img = System.Drawing.Image.FromFile(tmp[0]);
            pictureBox1.Size = new System.Drawing.Size(img.Width, img.Height);

            image = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            graphics = Graphics.FromImage(image);

            this.Text = System.IO.Path.GetFileNameWithoutExtension(tmp[0]);
            fileName = tmp[0];
            deselect();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBox1.Size = new System.Drawing.Size(700, 400);
            pictureBox1.Invalidate();
            this.Text = formTitle;

            selectedArea = new Rectangle(0,0,0,0);

            deselect();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                this.Text = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
                fileName = ofd.FileName;

                System.Drawing.Image img = System.Drawing.Image.FromFile(ofd.FileName);
                pictureBox1.Size = new System.Drawing.Size(img.Width, img.Height);
                image = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                graphics = Graphics.FromImage(image);

                deselect();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text == formTitle) saveAsToolStripMenuItem_Click(sender, e);
            else
            {
                Graphics g = Graphics.FromImage(image);
                Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
                g.CopyFromScreen(rect.Location, Point.Empty, pictureBox1.Size);
                g.Dispose();

                if (fileName != "") image.Save(fileName);
                else image.Save(sfd.FileName);
            }
            deselect();
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
            deselect();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);

            /*Graphics g = Graphics.FromImage(image);
            Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, pictureBox1.Size);
            g.Dispose();*/

            if (tool == 2)
            {
                drawingArea = new Rectangle(
                    Math.Min(startPRec.X, endP.X),
                    Math.Min(startPRec.Y, endP.Y),
                    Math.Abs(endP.X - startPRec.X),
                    Math.Abs(endP.Y - startPRec.Y));

                e.Graphics.DrawRectangle(
                    new Pen(selectedColor.BackColor), drawingArea);
            }

            if (tool == 6)
            {
                selectedArea = new Rectangle(
                    Math.Min(startPRec.X, endP.X),
                    Math.Min(startPRec.Y, endP.Y),
                    Math.Abs(endP.X - startPRec.X),
                    Math.Abs(endP.Y - startPRec.Y));

                e.Graphics.DrawRectangle(
                    new Pen(Color.Blue) { DashPattern = new float[] { 5, 1.5f } },
                    selectedArea);
            }

            if (moveSelection)
            {
                e.Graphics.DrawImage(selectedBitmap, endP);
            }
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

            if (e.Button == MouseButtons.Right)
            {
                MouseClickMenu menu;

                menu = new MouseClickMenu(pictureBox1, selectedArea, graphics);
                pictureBox1.ContextMenu = menu;
            }
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            startP = startPRec = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                mouseHold = true;
            }
            if (e.Button == MouseButtons.Right) return;
            cX = e.X;
            cY = e.Y;
            switch (tool)
            {
                case 3:
                    
                   
                    Font drawFont = new Font("Arial", 16);
                    SolidBrush drawBrush = new SolidBrush(selectedColor.BackColor);
                    graphics.DrawString(Txt, drawFont, drawBrush, startP);
                    pictureBox1.Invalidate();
                    break;

            }


            if (selectedArea.Contains(startP))
            {
                moveSelection = true;
                tool = 0;
                try
                {
                    deselect();
                    selectedBitmap = new Bitmap(selectedArea.Width, selectedArea.Height);
                    //using (Graphics g = Graphics.FromImage(selectedBitmap))
                    //{
                    Graphics g = Graphics.FromImage(selectedBitmap);
                        Rectangle r = new Rectangle(selectedArea.X, selectedArea.Y, selectedArea.Width, selectedArea.Height);
                        //g.DrawImage(pictureBox1.Image, r, selectedArea, GraphicsUnit.Pixel);

                        Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
                        g.CopyFromScreen(
                            new Point(rect.Location.X + r.Location.X, rect.Location.Y + r.Location.Y),
                            new Point(-1, -1), selectedBitmap.Size);
                        /*g.DrawImage(selectedBitmap, rect, selectedArea, GraphicsUnit.Pixel);
                        g.Dispose();*/
                    //}

                        //if (cntSelect == 0)
                        {
                            graphics.FillRectangle(new SolidBrush(Color.White), selectedArea);
                            cntSelect++;

                            /*image2.Size = pictureBox1.Size;
                            image2.Image = image;

                            image2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
                            image2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
                            image2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image2_mouseDown);
                            image2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
                            image2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);*/
                        }
                }
                catch (ArgumentNullException a) { }
            }

        }

        private void image2_mouseDown(object sender, MouseEventArgs e)
        {

        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            mouseHold = false;
            switch (tool)
            {
                case 2:
                    graphics.DrawRectangle(new Pen(selectedColor.BackColor), drawingArea);
                    pictureBox1.Invalidate();
                    break;
                
            }

            if (moveSelection)
            {

                moveSelection = false;
                tool = 6;
                graphics.DrawImage(selectedBitmap, endP);

                startPRec = endP;
                endP = new Point(startPRec.X + selectedBitmap.Width, endP.Y + selectedBitmap.Height);
                pictureBox1.Invalidate();
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
                    case 2:
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
                    case 6:
                        pictureBox1.Invalidate();
                        break;
                    default:
                        Console.WriteLine("ERROR: Unkwon tool");
                        break;
                }

                startP = endP;

                if (moveSelection)
                {
                    //graphics.DrawImage(selectedBitmap, endP);
                    pictureBox1.Invalidate();
                }
                
            }

        }

        private void deselect()
        {
            tool = 0;
            pictureBox1.Invalidate();
        }

        private void pencil_Click(object sender, EventArgs e)
        {
            deselect();
            tool = 1;
            //cntSelect = 0;
        }

        private void brush_Click(object sender, EventArgs e)
        {
            deselect();
            tool = 4;
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            deselect();
            tool = 5;
        }

        private void btnRectSelect_Click(object sender, EventArgs e)
        {
            deselect();
            tool = 6;

            startPRec = endP = new Point(0, 0);
        }

        public void btnBlack_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.Black;
        }

        protected void btnGray50_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.Gray;
        }

        private void btnDarkRed_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.DarkRed;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.Red;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.Orange;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.Yellow;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.Green;
        }

        private void btnTurquoise_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.Turquoise;
        }

        private void btnIndigo_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.Blue;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.Purple;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.White;
        }

        private void btnGray25_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.LightGray;
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.Brown;
        }

        private void btnRose_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.Pink;
        }

        private void btnGolden_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.Gold;
        }

        private void btnLightYellow_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.LightYellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deselect();
            startPRec = new Point(0, 0);
            endP = new Point(0, 0);
            tool = 2;
        }

        private void DrawText_Click(object sender, EventArgs e)
        {
            deselect();
            tool = 3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            deselect();
            Txt = textBox1.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contrast_Click(object sender, EventArgs e)
        {
            contrast_value = Int32.Parse(contrast_text.Text);
            SetContrast(contrast_value);
            pictureBox1.Invalidate();
        }

        private void contrast_text_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void brightness_value_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            brightness = Int32.Parse(brightness_value.Text);
            SetBrightness(brightness);
            pictureBox1.Invalidate();
        }

        private void btnLime_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.Lime;
        }

        private void btnLigthCyan_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.PaleTurquoise;
        }

        private void btnBlueGray_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.CadetBlue;
        }

        private void btnLavender_Click(object sender, EventArgs e)
        {
            //deselect();
            selectedColor.BackColor = Color.Lavender;
        }

        private void colorPalette_Click(object sender, EventArgs e)
        {
            //deselect();
            
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.ShowHelp = true;
            cd.Color = selectedColor.BackColor;

            if (cd.ShowDialog() == DialogResult.OK)
                selectedColor.BackColor = cd.Color;
        }


    }

}
