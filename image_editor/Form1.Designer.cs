namespace image_editor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutImageEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencil = new System.Windows.Forms.CheckBox();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnGray50 = new System.Windows.Forms.Button();
            this.btnDarkRed = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnTurquoise = new System.Windows.Forms.Button();
            this.btnIndigo = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnGray25 = new System.Windows.Forms.Button();
            this.btnBrown = new System.Windows.Forms.Button();
            this.btnRose = new System.Windows.Forms.Button();
            this.btnGolden = new System.Windows.Forms.Button();
            this.btnLightYellow = new System.Windows.Forms.Button();
            this.btnLime = new System.Windows.Forms.Button();
            this.btnLigthCyan = new System.Windows.Forms.Button();
            this.btnBlueGray = new System.Windows.Forms.Button();
            this.btnLavender = new System.Windows.Forms.Button();
            this.colorPalette = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Rectangle = new System.Windows.Forms.Button();
            this.DrawText = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.brush = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.eraser = new System.Windows.Forms.Button();
            this.btnRectSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(25, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutImageEditorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutImageEditorToolStripMenuItem
            // 
            this.aboutImageEditorToolStripMenuItem.Name = "aboutImageEditorToolStripMenuItem";
            this.aboutImageEditorToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aboutImageEditorToolStripMenuItem.Text = "About Image Editor";
            // 
            // pencil
            // 
            this.pencil.Appearance = System.Windows.Forms.Appearance.Button;
            this.pencil.Image = global::image_editor.Properties.Resources.pencil;
            this.pencil.Location = new System.Drawing.Point(90, 25);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(30, 30);
            this.pencil.TabIndex = 2;
            this.pencil.TabStop = false;
            this.pencil.UseVisualStyleBackColor = true;
            this.pencil.Click += new System.EventHandler(this.pencil_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(350, 25);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(30, 30);
            this.btnBlack.TabIndex = 3;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnGray50
            // 
            this.btnGray50.BackColor = System.Drawing.Color.Gray;
            this.btnGray50.Location = new System.Drawing.Point(380, 25);
            this.btnGray50.Name = "btnGray50";
            this.btnGray50.Size = new System.Drawing.Size(30, 30);
            this.btnGray50.TabIndex = 4;
            this.btnGray50.UseVisualStyleBackColor = false;
            this.btnGray50.Click += new System.EventHandler(this.btnGray50_Click);
            // 
            // btnDarkRed
            // 
            this.btnDarkRed.BackColor = System.Drawing.Color.DarkRed;
            this.btnDarkRed.Location = new System.Drawing.Point(410, 25);
            this.btnDarkRed.Name = "btnDarkRed";
            this.btnDarkRed.Size = new System.Drawing.Size(30, 30);
            this.btnDarkRed.TabIndex = 5;
            this.btnDarkRed.UseVisualStyleBackColor = false;
            this.btnDarkRed.Click += new System.EventHandler(this.btnDarkRed_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(440, 25);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(30, 30);
            this.btnRed.TabIndex = 6;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.Location = new System.Drawing.Point(470, 25);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(30, 30);
            this.btnOrange.TabIndex = 7;
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(500, 25);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(30, 30);
            this.btnYellow.TabIndex = 8;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Location = new System.Drawing.Point(530, 25);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(30, 30);
            this.btnGreen.TabIndex = 9;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnTurquoise
            // 
            this.btnTurquoise.BackColor = System.Drawing.Color.Turquoise;
            this.btnTurquoise.Location = new System.Drawing.Point(560, 25);
            this.btnTurquoise.Name = "btnTurquoise";
            this.btnTurquoise.Size = new System.Drawing.Size(30, 30);
            this.btnTurquoise.TabIndex = 10;
            this.btnTurquoise.UseVisualStyleBackColor = false;
            this.btnTurquoise.Click += new System.EventHandler(this.btnTurquoise_Click);
            // 
            // btnIndigo
            // 
            this.btnIndigo.BackColor = System.Drawing.Color.Blue;
            this.btnIndigo.Location = new System.Drawing.Point(590, 25);
            this.btnIndigo.Name = "btnIndigo";
            this.btnIndigo.Size = new System.Drawing.Size(30, 30);
            this.btnIndigo.TabIndex = 11;
            this.btnIndigo.UseVisualStyleBackColor = false;
            this.btnIndigo.Click += new System.EventHandler(this.btnIndigo_Click);
            // 
            // btnPurple
            // 
            this.btnPurple.BackColor = System.Drawing.Color.Purple;
            this.btnPurple.Location = new System.Drawing.Point(620, 25);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(30, 30);
            this.btnPurple.TabIndex = 12;
            this.btnPurple.UseVisualStyleBackColor = false;
            this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.Location = new System.Drawing.Point(350, 55);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(30, 30);
            this.btnWhite.TabIndex = 13;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnGray25
            // 
            this.btnGray25.BackColor = System.Drawing.Color.LightGray;
            this.btnGray25.Location = new System.Drawing.Point(380, 55);
            this.btnGray25.Name = "btnGray25";
            this.btnGray25.Size = new System.Drawing.Size(30, 30);
            this.btnGray25.TabIndex = 14;
            this.btnGray25.UseVisualStyleBackColor = false;
            this.btnGray25.Click += new System.EventHandler(this.btnGray25_Click);
            // 
            // btnBrown
            // 
            this.btnBrown.BackColor = System.Drawing.Color.Brown;
            this.btnBrown.Location = new System.Drawing.Point(410, 55);
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(30, 30);
            this.btnBrown.TabIndex = 15;
            this.btnBrown.UseVisualStyleBackColor = false;
            this.btnBrown.Click += new System.EventHandler(this.btnBrown_Click);
            // 
            // btnRose
            // 
            this.btnRose.BackColor = System.Drawing.Color.Pink;
            this.btnRose.Location = new System.Drawing.Point(440, 55);
            this.btnRose.Name = "btnRose";
            this.btnRose.Size = new System.Drawing.Size(30, 30);
            this.btnRose.TabIndex = 16;
            this.btnRose.UseVisualStyleBackColor = false;
            this.btnRose.Click += new System.EventHandler(this.btnRose_Click);
            // 
            // btnGolden
            // 
            this.btnGolden.BackColor = System.Drawing.Color.Gold;
            this.btnGolden.Location = new System.Drawing.Point(470, 55);
            this.btnGolden.Name = "btnGolden";
            this.btnGolden.Size = new System.Drawing.Size(30, 30);
            this.btnGolden.TabIndex = 17;
            this.btnGolden.UseVisualStyleBackColor = false;
            this.btnGolden.Click += new System.EventHandler(this.btnGolden_Click);
            // 
            // btnLightYellow
            // 
            this.btnLightYellow.BackColor = System.Drawing.Color.LightYellow;
            this.btnLightYellow.Location = new System.Drawing.Point(500, 55);
            this.btnLightYellow.Name = "btnLightYellow";
            this.btnLightYellow.Size = new System.Drawing.Size(30, 30);
            this.btnLightYellow.TabIndex = 18;
            this.btnLightYellow.UseVisualStyleBackColor = false;
            this.btnLightYellow.Click += new System.EventHandler(this.btnLightYellow_Click);
            // 
            // btnLime
            // 
            this.btnLime.BackColor = System.Drawing.Color.Lime;
            this.btnLime.Location = new System.Drawing.Point(530, 55);
            this.btnLime.Name = "btnLime";
            this.btnLime.Size = new System.Drawing.Size(30, 30);
            this.btnLime.TabIndex = 19;
            this.btnLime.UseVisualStyleBackColor = false;
            this.btnLime.Click += new System.EventHandler(this.btnLime_Click);
            // 
            // btnLigthCyan
            // 
            this.btnLigthCyan.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLigthCyan.Location = new System.Drawing.Point(560, 55);
            this.btnLigthCyan.Name = "btnLigthCyan";
            this.btnLigthCyan.Size = new System.Drawing.Size(30, 30);
            this.btnLigthCyan.TabIndex = 20;
            this.btnLigthCyan.UseVisualStyleBackColor = false;
            this.btnLigthCyan.Click += new System.EventHandler(this.btnLigthCyan_Click);
            // 
            // btnBlueGray
            // 
            this.btnBlueGray.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBlueGray.Location = new System.Drawing.Point(590, 55);
            this.btnBlueGray.Name = "btnBlueGray";
            this.btnBlueGray.Size = new System.Drawing.Size(30, 30);
            this.btnBlueGray.TabIndex = 21;
            this.btnBlueGray.UseVisualStyleBackColor = false;
            this.btnBlueGray.Click += new System.EventHandler(this.btnBlueGray_Click);
            // 
            // btnLavender
            // 
            this.btnLavender.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLavender.Location = new System.Drawing.Point(620, 55);
            this.btnLavender.Name = "btnLavender";
            this.btnLavender.Size = new System.Drawing.Size(30, 30);
            this.btnLavender.TabIndex = 22;
            this.btnLavender.UseVisualStyleBackColor = false;
            this.btnLavender.Click += new System.EventHandler(this.btnLavender_Click);
            // 
            // colorPalette
            // 
            this.colorPalette.Image = ((System.Drawing.Image)(resources.GetObject("colorPalette.Image")));
            this.colorPalette.Location = new System.Drawing.Point(650, 25);
            this.colorPalette.Name = "colorPalette";
            this.colorPalette.Size = new System.Drawing.Size(75, 45);
            this.colorPalette.TabIndex = 23;
            this.colorPalette.UseVisualStyleBackColor = true;
            this.colorPalette.Click += new System.EventHandler(this.colorPalette_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Color";
            // 
            // selectedColor
            // 
            this.selectedColor.BackColor = System.Drawing.Color.Black;
            this.selectedColor.Location = new System.Drawing.Point(300, 25);
            this.selectedColor.Name = "selectedColor";
            this.selectedColor.Size = new System.Drawing.Size(45, 45);
            this.selectedColor.TabIndex = 24;
            this.selectedColor.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Color Palette";
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(235, 25);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(30, 30);
            this.Rectangle.TabIndex = 27;
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrawText
            // 
            this.DrawText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DrawText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DrawText.Location = new System.Drawing.Point(150, 25);
            this.DrawText.Name = "DrawText";
            this.DrawText.Size = new System.Drawing.Size(30, 30);
            this.DrawText.TabIndex = 28;
            this.DrawText.Text = "A";
            this.DrawText.UseVisualStyleBackColor = true;
            this.DrawText.Click += new System.EventHandler(this.DrawText_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // brush
            // 
            this.brush.Image = ((System.Drawing.Image)(resources.GetObject("brush.Image")));
            this.brush.Location = new System.Drawing.Point(185, 25);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(45, 45);
            this.brush.TabIndex = 30;
            this.brush.UseVisualStyleBackColor = true;
            this.brush.Click += new System.EventHandler(this.brush_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            5,
            10,
            15});
            this.comboBox1.Location = new System.Drawing.Point(185, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // eraser
            // 
            this.eraser.Image = ((System.Drawing.Image)(resources.GetObject("eraser.Image")));
            this.eraser.Location = new System.Drawing.Point(120, 25);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(30, 30);
            this.eraser.TabIndex = 32;
            this.eraser.UseVisualStyleBackColor = true;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // btnRectSelect
            // 
            this.btnRectSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnRectSelect.Image")));
            this.btnRectSelect.Location = new System.Drawing.Point(25, 25);
            this.btnRectSelect.Name = "btnRectSelect";
            this.btnRectSelect.Size = new System.Drawing.Size(60, 60);
            this.btnRectSelect.TabIndex = 33;
            this.btnRectSelect.UseVisualStyleBackColor = true;
            this.btnRectSelect.Click += new System.EventHandler(this.btnRectSelect_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 520);
            this.Controls.Add(this.btnRectSelect);
            this.Controls.Add(this.eraser);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.brush);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DrawText);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedColor);
            this.Controls.Add(this.colorPalette);
            this.Controls.Add(this.btnLavender);
            this.Controls.Add(this.btnBlueGray);
            this.Controls.Add(this.btnLigthCyan);
            this.Controls.Add(this.btnLime);
            this.Controls.Add(this.btnLightYellow);
            this.Controls.Add(this.btnGolden);
            this.Controls.Add(this.btnRose);
            this.Controls.Add(this.btnBrown);
            this.Controls.Add(this.btnGray25);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnPurple);
            this.Controls.Add(this.btnIndigo);
            this.Controls.Add(this.btnTurquoise);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnOrange);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnDarkRed);
            this.Controls.Add(this.btnGray50);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.pencil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutImageEditorToolStripMenuItem;
        private System.Windows.Forms.CheckBox pencil;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnGray50;
        private System.Windows.Forms.Button btnDarkRed;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnTurquoise;
        private System.Windows.Forms.Button btnIndigo;
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnGray25;
        private System.Windows.Forms.Button btnBrown;
        private System.Windows.Forms.Button btnRose;
        private System.Windows.Forms.Button btnGolden;
        private System.Windows.Forms.Button btnLightYellow;
        private System.Windows.Forms.Button btnLime;
        private System.Windows.Forms.Button btnLigthCyan;
        private System.Windows.Forms.Button btnBlueGray;
        private System.Windows.Forms.Button btnLavender;
        private System.Windows.Forms.Button colorPalette;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectedColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button DrawText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button brush;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Button btnRectSelect;
    }
}

