using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ImageEditor2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Image Img;
        private Size OriginalImageSize;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {

            

            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                textBox1.Text = open.FileName;
            }
        }

        private void left90_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
            else
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void right90_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image == null)
            {
                return;
            }
            else
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Refresh();
            }
            

        }

        private void rotate180_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox1.Refresh();

        }

        private void flipVert_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Refresh();

        }

        private void flipHoriz_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Refresh();

        }
    }
}
