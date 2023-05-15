namespace ImageEditor2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItemRotateRight90 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRotateLeft90 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRotate180 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFlipVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFlipHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.yellowColor = new System.Windows.Forms.PictureBox();
            this.blackColor = new System.Windows.Forms.PictureBox();
            this.blueColor = new System.Windows.Forms.PictureBox();
            this.whiteColor = new System.Windows.Forms.PictureBox();
            this.redColor = new System.Windows.Forms.PictureBox();
            this.Clear = new System.Windows.Forms.Button();
            this.pencil_btn = new System.Windows.Forms.Button();
            this.Rect_btn = new System.Windows.Forms.Button();
            this.Circle_btn = new System.Windows.Forms.Button();
            this.Tri_btn = new System.Windows.Forms.Button();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItemGrayScale = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yellowColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColor)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Tag = "hello";
            this.openFileDialog1.Title = "HELLO";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 31);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemOpen,
            this.MenuItemSave,
            this.MenuItemSaveas});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(46, 28);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // MenuItemOpen
            // 
            this.MenuItemOpen.Name = "MenuItemOpen";
            this.MenuItemOpen.Size = new System.Drawing.Size(224, 26);
            this.MenuItemOpen.Text = "Open";
            this.MenuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click);
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.Size = new System.Drawing.Size(224, 26);
            this.MenuItemSave.Text = "Save";
            this.MenuItemSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // MenuItemSaveas
            // 
            this.MenuItemSaveas.Name = "MenuItemSaveas";
            this.MenuItemSaveas.Size = new System.Drawing.Size(224, 26);
            this.MenuItemSaveas.Text = "Save As";
            this.MenuItemSaveas.Click += new System.EventHandler(this.Saveas_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRotateRight90,
            this.MenuItemRotateLeft90,
            this.MenuItemRotate180,
            this.MenuItemFlipVertical,
            this.MenuItemFlipHorizontal});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(67, 24);
            this.toolStripDropDownButton2.Text = "Rotate";
            // 
            // MenuItemRotateRight90
            // 
            this.MenuItemRotateRight90.Name = "MenuItemRotateRight90";
            this.MenuItemRotateRight90.Size = new System.Drawing.Size(224, 26);
            this.MenuItemRotateRight90.Text = "Rotate right 90*";
            this.MenuItemRotateRight90.Click += new System.EventHandler(this.MenuItemRotateRight90_Click);
            // 
            // MenuItemRotateLeft90
            // 
            this.MenuItemRotateLeft90.Name = "MenuItemRotateLeft90";
            this.MenuItemRotateLeft90.Size = new System.Drawing.Size(224, 26);
            this.MenuItemRotateLeft90.Text = "Rotate left 90*";
            this.MenuItemRotateLeft90.Click += new System.EventHandler(this.MenuItemRotateLeft90_Click);
            // 
            // MenuItemRotate180
            // 
            this.MenuItemRotate180.Name = "MenuItemRotate180";
            this.MenuItemRotate180.Size = new System.Drawing.Size(224, 26);
            this.MenuItemRotate180.Text = "Rotate 180*";
            this.MenuItemRotate180.Click += new System.EventHandler(this.MenuItemRotate180_Click);
            // 
            // MenuItemFlipVertical
            // 
            this.MenuItemFlipVertical.Name = "MenuItemFlipVertical";
            this.MenuItemFlipVertical.Size = new System.Drawing.Size(224, 26);
            this.MenuItemFlipVertical.Text = "Flip Vertical";
            this.MenuItemFlipVertical.Click += new System.EventHandler(this.MenuItemFlipVertical_Click);
            // 
            // MenuItemFlipHorizontal
            // 
            this.MenuItemFlipHorizontal.Name = "MenuItemFlipHorizontal";
            this.MenuItemFlipHorizontal.Size = new System.Drawing.Size(224, 26);
            this.MenuItemFlipHorizontal.Text = "Flip Horizontal";
            this.MenuItemFlipHorizontal.Click += new System.EventHandler(this.MenuItemFlipHorizontal_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(155, 141);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(903, 56);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(58, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 471);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = " ";
            this.pictureBox1.Location = new System.Drawing.Point(20, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1002, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Zoom Slider";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(762, 24);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(61, 40);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 59);
            this.label2.TabIndex = 19;
            this.label2.Text = "Selected color:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseMnemonic = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.yellowColor);
            this.panel2.Controls.Add(this.blackColor);
            this.panel2.Controls.Add(this.blueColor);
            this.panel2.Controls.Add(this.whiteColor);
            this.panel2.Controls.Add(this.redColor);
            this.panel2.Location = new System.Drawing.Point(831, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 57);
            this.panel2.TabIndex = 20;
            // 
            // yellowColor
            // 
            this.yellowColor.BackColor = System.Drawing.Color.Yellow;
            this.yellowColor.Location = new System.Drawing.Point(189, 10);
            this.yellowColor.Margin = new System.Windows.Forms.Padding(4);
            this.yellowColor.Name = "yellowColor";
            this.yellowColor.Size = new System.Drawing.Size(48, 30);
            this.yellowColor.TabIndex = 4;
            this.yellowColor.TabStop = false;
            this.yellowColor.Click += new System.EventHandler(this.changeColor);
            // 
            // blackColor
            // 
            this.blackColor.BackColor = System.Drawing.Color.Black;
            this.blackColor.Location = new System.Drawing.Point(77, 10);
            this.blackColor.Margin = new System.Windows.Forms.Padding(4);
            this.blackColor.Name = "blackColor";
            this.blackColor.Size = new System.Drawing.Size(48, 30);
            this.blackColor.TabIndex = 3;
            this.blackColor.TabStop = false;
            this.blackColor.Click += new System.EventHandler(this.changeColor);
            // 
            // blueColor
            // 
            this.blueColor.BackColor = System.Drawing.Color.Blue;
            this.blueColor.Location = new System.Drawing.Point(245, 10);
            this.blueColor.Margin = new System.Windows.Forms.Padding(4);
            this.blueColor.Name = "blueColor";
            this.blueColor.Size = new System.Drawing.Size(48, 30);
            this.blueColor.TabIndex = 2;
            this.blueColor.TabStop = false;
            this.blueColor.Click += new System.EventHandler(this.changeColor);
            // 
            // whiteColor
            // 
            this.whiteColor.BackColor = System.Drawing.Color.White;
            this.whiteColor.Location = new System.Drawing.Point(133, 9);
            this.whiteColor.Margin = new System.Windows.Forms.Padding(4);
            this.whiteColor.Name = "whiteColor";
            this.whiteColor.Size = new System.Drawing.Size(48, 31);
            this.whiteColor.TabIndex = 1;
            this.whiteColor.TabStop = false;
            this.whiteColor.Click += new System.EventHandler(this.changeColor);
            // 
            // redColor
            // 
            this.redColor.BackColor = System.Drawing.Color.Crimson;
            this.redColor.Location = new System.Drawing.Point(21, 10);
            this.redColor.Margin = new System.Windows.Forms.Padding(4);
            this.redColor.Name = "redColor";
            this.redColor.Size = new System.Drawing.Size(48, 30);
            this.redColor.TabIndex = 0;
            this.redColor.TabStop = false;
            this.redColor.Click += new System.EventHandler(this.changeColor);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(522, 30);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(110, 50);
            this.Clear.TabIndex = 21;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // pencil_btn
            // 
            this.pencil_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pencil_btn.Image = ((System.Drawing.Image)(resources.GetObject("pencil_btn.Image")));
            this.pencil_btn.Location = new System.Drawing.Point(270, 38);
            this.pencil_btn.Margin = new System.Windows.Forms.Padding(4);
            this.pencil_btn.Name = "pencil_btn";
            this.pencil_btn.Size = new System.Drawing.Size(49, 42);
            this.pencil_btn.TabIndex = 22;
            this.pencil_btn.UseVisualStyleBackColor = true;
            this.pencil_btn.Click += new System.EventHandler(this.pencil_btn_Click);
            // 
            // Rect_btn
            // 
            this.Rect_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rect_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rect_btn.Image = ((System.Drawing.Image)(resources.GetObject("Rect_btn.Image")));
            this.Rect_btn.Location = new System.Drawing.Point(327, 38);
            this.Rect_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Rect_btn.Name = "Rect_btn";
            this.Rect_btn.Size = new System.Drawing.Size(49, 43);
            this.Rect_btn.TabIndex = 23;
            this.Rect_btn.UseVisualStyleBackColor = true;
            this.Rect_btn.Click += new System.EventHandler(this.Rect_btn_Click);
            // 
            // Circle_btn
            // 
            this.Circle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Circle_btn.Image = ((System.Drawing.Image)(resources.GetObject("Circle_btn.Image")));
            this.Circle_btn.Location = new System.Drawing.Point(384, 38);
            this.Circle_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Circle_btn.Name = "Circle_btn";
            this.Circle_btn.Size = new System.Drawing.Size(49, 42);
            this.Circle_btn.TabIndex = 24;
            this.Circle_btn.UseVisualStyleBackColor = true;
            this.Circle_btn.Click += new System.EventHandler(this.Circle_btn_Click);
            // 
            // Tri_btn
            // 
            this.Tri_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tri_btn.Image = ((System.Drawing.Image)(resources.GetObject("Tri_btn.Image")));
            this.Tri_btn.Location = new System.Drawing.Point(441, 38);
            this.Tri_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Tri_btn.Name = "Tri_btn";
            this.Tri_btn.Size = new System.Drawing.Size(49, 43);
            this.Tri_btn.TabIndex = 25;
            this.Tri_btn.UseVisualStyleBackColor = true;
            this.Tri_btn.Click += new System.EventHandler(this.Tri_btn_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemGrayScale});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(67, 24);
            this.toolStripDropDownButton3.Text = "Effects";
            // 
            // MenuItemGrayScale
            // 
            this.MenuItemGrayScale.Name = "MenuItemGrayScale";
            this.MenuItemGrayScale.Size = new System.Drawing.Size(224, 26);
            this.MenuItemGrayScale.Text = "Gray Scale";
            this.MenuItemGrayScale.Click += new System.EventHandler(this.MenuItemGrayScale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 686);
            this.Controls.Add(this.Tri_btn);
            this.Controls.Add(this.Circle_btn);
            this.Controls.Add(this.Rect_btn);
            this.Controls.Add(this.pencil_btn);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yellowColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSaveas;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRotateRight90;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRotateLeft90;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRotate180;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFlipVertical;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFlipHorizontal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox yellowColor;
        private System.Windows.Forms.PictureBox blackColor;
        private System.Windows.Forms.PictureBox blueColor;
        private System.Windows.Forms.PictureBox whiteColor;
        private System.Windows.Forms.PictureBox redColor;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button pencil_btn;
        private System.Windows.Forms.Button Rect_btn;
        private System.Windows.Forms.Button Circle_btn;
        private System.Windows.Forms.Button Tri_btn;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGrayScale;
    }
}

