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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.insertImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.right90 = new System.Windows.Forms.Button();
            this.left90 = new System.Windows.Forms.Button();
            this.rotate180 = new System.Windows.Forms.Button();
            this.flipVert = new System.Windows.Forms.Button();
            this.flipHoriz = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1292, 537);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // insertImage
            // 
            this.insertImage.Location = new System.Drawing.Point(24, 55);
            this.insertImage.Name = "insertImage";
            this.insertImage.Size = new System.Drawing.Size(129, 50);
            this.insertImage.TabIndex = 1;
            this.insertImage.Text = "Insert image";
            this.insertImage.UseVisualStyleBackColor = true;
            this.insertImage.Click += new System.EventHandler(this.insert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Tag = "hello";
            this.openFileDialog1.Title = "HELLO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Image Rotations";
            // 
            // right90
            // 
            this.right90.Location = new System.Drawing.Point(350, 55);
            this.right90.Name = "right90";
            this.right90.Size = new System.Drawing.Size(139, 23);
            this.right90.TabIndex = 7;
            this.right90.Text = "Rotate right 90*";
            this.right90.UseVisualStyleBackColor = true;
            this.right90.Click += new System.EventHandler(this.right90_Click);
            // 
            // left90
            // 
            this.left90.Location = new System.Drawing.Point(350, 95);
            this.left90.Name = "left90";
            this.left90.Size = new System.Drawing.Size(139, 23);
            this.left90.TabIndex = 8;
            this.left90.Text = "Rotate left 90*";
            this.left90.UseVisualStyleBackColor = true;
            this.left90.Click += new System.EventHandler(this.left90_Click);
            // 
            // rotate180
            // 
            this.rotate180.Location = new System.Drawing.Point(535, 55);
            this.rotate180.Name = "rotate180";
            this.rotate180.Size = new System.Drawing.Size(145, 23);
            this.rotate180.TabIndex = 9;
            this.rotate180.Text = "Rotate 180*";
            this.rotate180.UseVisualStyleBackColor = true;
            this.rotate180.Click += new System.EventHandler(this.rotate180_Click);
            // 
            // flipVert
            // 
            this.flipVert.Location = new System.Drawing.Point(535, 95);
            this.flipVert.Name = "flipVert";
            this.flipVert.Size = new System.Drawing.Size(145, 23);
            this.flipVert.TabIndex = 10;
            this.flipVert.Text = "Flip Vertical";
            this.flipVert.UseVisualStyleBackColor = true;
            this.flipVert.Click += new System.EventHandler(this.flipVert_Click);
            // 
            // flipHoriz
            // 
            this.flipHoriz.Location = new System.Drawing.Point(717, 54);
            this.flipHoriz.Name = "flipHoriz";
            this.flipHoriz.Size = new System.Drawing.Size(138, 23);
            this.flipHoriz.TabIndex = 11;
            this.flipHoriz.Text = "Flip Horizontal";
            this.flipHoriz.UseVisualStyleBackColor = true;
            this.flipHoriz.Click += new System.EventHandler(this.flipHoriz_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1044, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 686);
            this.Controls.Add(this.flipHoriz);
            this.Controls.Add(this.flipVert);
            this.Controls.Add(this.rotate180);
            this.Controls.Add(this.left90);
            this.Controls.Add(this.right90);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.insertImage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button insertImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button right90;
        private System.Windows.Forms.Button left90;
        private System.Windows.Forms.Button rotate180;
        private System.Windows.Forms.Button flipVert;
        private System.Windows.Forms.Button flipHoriz;
        private System.Windows.Forms.TextBox textBox1;
    }
}

