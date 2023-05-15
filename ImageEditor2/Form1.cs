

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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
        private Image Img;

        private Size OriginalImageSize;
        private Bitmap bitmap;                                          // bitmap object of the image file we want to display
        public ArrayList bmList = new ArrayList();
        private List<Bitmap> bmList2;                                   //list of Bitmap objects, used for updating the pictureBox1.Image property when drawing with brush on image
        
        private List<Bitmap> listBitmaps;                               //list of Bitmap objects, used to set pictureBox1.Image when clear is pressed
        public int i2 = 0;                                                //index for listBitmaps list
        private Bitmap ogBm;
        public int idx=0;                                                 //index for the bitmap array and the draw array
        Point lastPoint = Point.Empty;
        bool isMouseDown = new Boolean();
        Pen my_pen;
        private List<Graphics> drawList;
        Graphics draw;
        private Bitmap drawing;
        //public ArrayList drawList = new ArrayList();
        private int currentFileIndex = -1;                              // index of the currently used file, if the value is -1 there is no open file                    
        public int numOpen = 0;
        int x, y, sX, sY, cX, cY;
        int initX;                                                      //initial X coordinate for drawing a rectangle
        int initY;                                                      //initial Y coordinate for drawing a rectangle
        Point LocationX1Y1 = Point.Empty;
        int width=0, height=0;
        public enum TOOL
        {
            SELECT,
            PEN,
            ERASER,
            FILLCOLOR,
            LINE,
            ELLIPSE,
            RECTANGLE,
            TRIANGLE
        }
        public TOOL curTool = TOOL.SELECT;

        public Form1()
        {
            bitmap = null;
            InitializeComponent();
            my_pen = new Pen(Color.Black, 3);
            pictureBox6.BackColor = Color.Black;
            bmList2 = new List<Bitmap>();
            listBitmaps = new List<Bitmap>();
            drawList = new List<Graphics> ();


        }
        
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
                numOpen++;
                for(int i = 0; i < 15; i++)
                {
                    Bitmap b2 = new Bitmap(open.FileName);
                    listBitmaps.Add(b2);
                }
                if (numOpen >= 2)
                {
                    i2 = listBitmaps.Count - 15 + 1;
                    idx++;
                }
                bitmap = new Bitmap(open.FileName);
                ogBm = new Bitmap(open.FileName);
                pictureBox1.Image = ogBm;
                Img = pictureBox1.Image;
                
                draw = Graphics.FromImage(ogBm);
                draw.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                drawList.Add(draw);
                //draw = Graphics.FromImage(bitmap);
                bmList2.Add(ogBm);
                
                //this.idx++;
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

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (isMouseDown)
            {
                if (curTool == TOOL.ELLIPSE)
                {
                    g.DrawEllipse(my_pen, initX, initY, LocationX1Y1.X, LocationX1Y1.Y);

                }
                if (curTool == TOOL.RECTANGLE)
                {
                    
                    g.DrawRectangle(my_pen, GetRect());
                }
            }
        }
        //Mouse down event handler used to draw on the picture
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = true;
            initX = e.X;
            initY= e.Y;


        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                if(lastPoint != null)
                {
                    if(pictureBox1.Image != null)
                    {
                        //Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                        //pictureBox1.Image = bmp; //assign the picturebox.Image property to the bitmap created
                        
                    }
                    LocationX1Y1 = e.Location;
                    pictureBox1.Refresh();
                    this.width = Math.Abs(e.X - initX);
                    this.height = Math.Abs(e.Y - initY);

                    if (curTool == TOOL.PEN)
                    {
                        drawList[idx].DrawLine(my_pen, lastPoint, e.Location);

                        pictureBox1.Image = bmList2[idx];


                        pictureBox1.Invalidate();//refreshes the picturebox

                        lastPoint = e.Location;//keep assigning the lastPoint to the current mouse position
                    }


                    


                    //draw a line from the last point the mouse was at to the new location


                }
            }
        }
        private Rectangle GetRect()
        {
            //Create Object Of rect. we define rect at TOP.
            Rectangle rect = new Rectangle();

            //The x-value of our Rectangle should be the minimum between the start x-value and the current x-position.
            rect.X = Math.Min(initX, LocationX1Y1.X);

            //same as above x-value. The y-value of our Rectangle should be the minimum between the start y-value and the current y-position.
            rect.Y = Math.Min(initY, LocationX1Y1.Y);

            //the width of our rectangle should be the maximum between the start x-position and current x-position MINUS.
            rect.Width = Math.Abs(initX - LocationX1Y1.X);

            rect.Height = Math.Abs(initY - LocationX1Y1.Y);

            return rect;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;

            lastPoint = Point.Empty;
            this.width = Math.Abs(e.X - initX);
            this.height = Math.Abs(e.Y - initY);
            LocationX1Y1 = e.Location;
            if (curTool == TOOL.RECTANGLE)
            {
                this.Refresh();

                drawList[idx].DrawRectangle(my_pen, GetRect());
                pictureBox1.Image = bmList2[idx];


                //pictureBox1.Invalidate();//refreshes the picturebox
            }



        }
        

        private void changeColor(object sender, EventArgs e)
        {
            PictureBox my_picture = (PictureBox)sender;
            my_pen.Color = my_picture.BackColor;
            pictureBox6.BackColor = my_picture.BackColor;
        }

        private void MenuItemGrayScale_Click(object sender, EventArgs e)
        {
            Bitmap newImg = new Bitmap(listBitmaps[i2].Width, listBitmaps[i2].Height);

            for (int i=0;i < listBitmaps[i2].Width; i++)
            {
                for (int j=0;j< listBitmaps[i2].Height; j++)
                {
                    Color c = listBitmaps[i2].GetPixel(i, j);
                    int gray = (int)((c.R * 0.2) + (c.G * 0.5) + (c.B * 0.2));
                    Color newC = Color.FromArgb(c.A, gray, gray, gray);
                    newImg.SetPixel(i,j, newC);
                }
            }
            pictureBox1.Image = newImg;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            
            drawList[idx].Clear(BackColor);
            drawList[idx] = null;
            bmList2[idx] = null;
            
            drawList.Add(Graphics.FromImage(listBitmaps[i2]));
            idx++;
            
            pictureBox1.Invalidate();
            bmList2.Add(listBitmaps[i2]);
            pictureBox1.Image = null;//refreshes the picturebox
            listBitmaps.Add(listBitmaps[i2]);
            pictureBox1.Image = listBitmaps[i2];
            
            i2++;
            pictureBox1.Invalidate();

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Tri_btn_Click(object sender, EventArgs e)
        {
            curTool = TOOL.TRIANGLE;

        }

        private void Rect_btn_Click(object sender, EventArgs e)
        {
            curTool = TOOL.RECTANGLE;
        }

        private void Circle_btn_Click(object sender, EventArgs e)
        {
            curTool = TOOL.ELLIPSE;
        }

        private void pencil_btn_Click(object sender, EventArgs e)
        {
            curTool = TOOL.PEN;


        }
    }
}
