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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItemRotateRight90 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRotateLeft90 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRotate180 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFlipVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFlipHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 27);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(46, 24);
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
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(59, 81);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(999, 56);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(36, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 495);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 686);
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
    }
}

