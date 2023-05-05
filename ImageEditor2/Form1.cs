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
        private Bitmap bitmap;                                          // bitmap object of the image file we want to display
        private float zoomFactor = 1.00F;                               // zoom factor, used when changing image dimensions
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

       

        

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  

            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                Img = pictureBox1.Image;
                // image file path  
                
            }


        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void Saveas_Click(object sender, EventArgs e)
        {


        }

        
        Image Zoom(Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, (img.Width * size.Width),  (img.Height * size.Height));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }
        private void getZoom(int zoomSize)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int newWidth = pictureBox1.Image.Width / zoomSize;
            int newHeight = pictureBox1.Image.Height / zoomSize;
            Bitmap bmpNew = new Bitmap(newWidth, newHeight);

            Graphics gr = Graphics.FromImage(bmpNew);
            gr.DrawImage(bmp, 0, 0, bmpNew.Width, bmpNew.Height);
            pictureBox1.Image = bmpNew;

            //panel1.AutoScrollMinSize = new Size(pictureBox1.Image.Width, pictureBox1.Image.Height);


        }

        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = Zoom(Img, new Size(trackBar1.Value, trackBar1.Value));

            }
        }

        private void MenuItemRotateRight90_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
            else
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void MenuItemRotateLeft90_Click(object sender, EventArgs e)
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

        private void MenuItemRotate180_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox1.Refresh();
        }

        private void MenuItemFlipVertical_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Refresh();
        }

        private void MenuItemFlipHorizontal_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Refresh();
        }
    }
}
