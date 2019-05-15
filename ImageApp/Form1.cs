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
using System.Net;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

//Created by Mateusz Baranowski [AIR]

namespace ImageApp
{
    public partial class ImageProcessApp : Form
    {

        public ImageProcessApp() { InitializeComponent(); }

        private Image image;
        private String path;

        private Image image2;
        private String path2;

        //====================I/O Menu====================

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open(pictureBox, image, path, detailsListBox, "LEFT");
        }

        private void openAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAs(pictureBox, image, path, detailsListBox, "LEFT");
        }

        private void openURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openUrl(pictureBox, urlTextBox, image, path, detailsListBox, "LEFT");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save(pictureBox);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs(pictureBox);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear(pictureBox, "LEFT");
        }

        //====================Transform Menu====================

        private void cropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crop(pictureBox, image, path, cropWidthTextBox, cropHeightTextBox, cropPosX, cropPosY, "LEFT");
        }

        //====================Color Menu====================

        private void grayScale1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grayScale1();
        }

        private void grayScale2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grayScale2();
        }

        private void grayScale3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grayScale3();
        }

        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            negative();
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sepia();
        }

        private void grayInvertedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            riddle();
        }

        private void redChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redChannel();
        }

        private void greenChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            greenChannel();
        }

        private void blueChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blueChannel();
        }

        //====================Filter Menu====================

        private void x3GrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] Matrix3x3 = new double[,]   
                { {  0.0, 0.2, 0.0, },  
                  {  0.2, 0.2, 0.2, },  
                  {  0.0, 0.2, 0.2, }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterGray(img, Matrix3x3);
            }
        }

        private void x3ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] Matrix3x3 = new double[,]   
                { {  0.0, 0.2, 0.0, },  
                  {  0.2, 0.2, 0.2, },  
                  {  0.0, 0.2, 0.2, }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterColor(img, Matrix3x3);
            }
        }

        private void x5GrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] Matrix5x5 = new double[,]
                { {  0.0, 0.0, 1.0, 0.0, 0.0 },  
                  {  0.0, 1.0, 1.0, 1.0, 0.0 },  
                  {  1.0, 1.0, 1.0, 1.0, 1.0 },
                  {  0.0, 1.0, 1.0, 1.0, 0.0 }, 
                  {  0.0, 0.0, 1.0, 0.0, 0.0 }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterGray(img, Matrix5x5);
            }
        }

        private void x5ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] Matrix5x5 = new double[,]
                { {  0.0, 0.0, 1.0, 0.0, 0.0 },  
                  {  0.0, 1.0, 1.0, 1.0, 0.0 },  
                  {  1.0, 1.0, 1.0, 1.0, 1.0 },
                  {  0.0, 1.0, 1.0, 1.0, 0.0 }, 
                  {  0.0, 0.0, 1.0, 0.0, 0.0 }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterColor(img, Matrix5x5);
            }
        }

        private void x3ColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double[,] Matrix3x3 = new double[,]   
                { {  1.0, 1.0, 1.0, },  
                  {  1.0, 1.0, 1.0, },  
                  {  1.0, 1.0, 1.0, }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterColor(img, Matrix3x3);
            }
        }

        private void x3GrayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double[,] Matrix3x3 = new double[,]   
                { {  1.0, 1.0, 1.0, },  
                  {  1.0, 1.0, 1.0, },  
                  {  1.0, 1.0, 1.0, }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterGray(img, Matrix3x3);
            }
        }

        private void x5GrayToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            double[,] Matrix5x5 = new double[,]
                { {  1.0, 1.0, 1.0, 1.0, 1.0 },  
                  {  1.0, 1.0, 1.0, 1.0, 1.0 },  
                  {  1.0, 1.0, 1.0, 1.0, 1.0 },
                  {  1.0, 1.0, 1.0, 1.0, 1.0 }, 
                  {  1.0, 1.0, 1.0, 1.0, 1.0 }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterGray(img, Matrix5x5);
            }
        }

        private void x5ColorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            double[,] Matrix5x5 = new double[,]
                { {  1.0, 1.0, 1.0, 1.0, 1.0 },  
                  {  1.0, 1.0, 1.0, 1.0, 1.0 },  
                  {  1.0, 1.0, 1.0, 1.0, 1.0 },
                  {  1.0, 1.0, 1.0, 1.0, 1.0 }, 
                  {  1.0, 1.0, 1.0, 1.0, 1.0 }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterColor(img, Matrix5x5);
            }
        }

        private void x3GrayToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            double[,] Matrix3x3 = new double[,]   
                { {  0.0, -1.0, 0.0, },  
                  {  -1.0, 5.0, -1.0, },  
                  {  0.0, -1.0, 0.0, }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterGray(img, Matrix3x3);
            }
        }

        private void x3ColorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            double[,] Matrix3x3 = new double[,]   
                { {  0.0, -1.0, 0.0, },  
                  {  -1.0, 5.0, -1.0, },  
                  {  0.0, -1.0, 0.0, }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterColor(img, Matrix3x3);
            }
        }

        private void x5GrayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double[,] Matrix5x5 = new double[,]
                { {  -1.0, -1.0, -1.0, -1.0, -1.0 },  
                  {  -1.0, 2.0, 2.0, 2.0, -1.0 },  
                  {  -1.0, 2.0, 8.0, 2.0, -1.0 },
                  {  -1.0, 2.0, 2.0, 2.0, -1.0 }, 
                  {  -1.0, -1.0, -1.0, -1.0, -1.0 }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterGray(img, Matrix5x5);
            }
        }

        private void x5ColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double[,] Matrix5x5 = new double[,]
                { {  -1.0, -1.0, -1.0, -1.0, -1.0 },  
                  {  -1.0, 2.0, 2.0, 2.0, -1.0 },  
                  {  -1.0, 2.0, 8.0, 2.0, -1.0 },
                  {  -1.0, 2.0, 2.0, 2.0, -1.0 }, 
                  {  -1.0, -1.0, -1.0, -1.0, -1.0 }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterColor(img, Matrix5x5);
            }
        }

        private void x3GrayToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            double[,] Matrix3x3 = new double[,]   
                { {  -1.0, -1.0, -1.0, },  
                  {  -1.0, 9.0, -1.0, },  
                  {  -1.0, -1.0, -1.0, }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterGray(img, Matrix3x3);
            }
        }

        private void x3ColorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            double[,] Matrix3x3 = new double[,]   
                { {  -1.0, -1.0, -1.0, },  
                  {  -1.0, 9.0, -1.0, },  
                  {  -1.0, -1.0, -1.0, }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterColor(img, Matrix3x3);
            }
        }

        private void x5GrayToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            double[,] Matrix5x5 = new double[,]
                { {  -1.0, 0.0, 0.0, 0.0, 0.0 },  
                  {  0.0, -2.0, 0.0, 0.0, 0.0 },  
                  {  0.0, 0.0, 6.0, 2.0, 0.0 },
                  {  0.0, 0.0, 0.0, -2.0, 0.0 }, 
                  {  0.0, 0.0, 0.0, 0.0, -1.0 }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterGray(img, Matrix5x5);
            }
        }

        private void x5ColorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            double[,] Matrix5x5 = new double[,]
                { {  -1.0, 0.0, 0.0, 0.0, 0.0 },  
                  {  0.0, -2.0, 0.0, 0.0, 0.0 },  
                  {  0.0, 0.0, 6.0, 2.0, 0.0 },
                  {  0.0, 0.0, 0.0, -2.0, 0.0 }, 
                  {  0.0, 0.0, 0.0, 0.0, -1.0 }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterColor(img, Matrix5x5);
            }
        }

        private void x3GrayToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            double[,] Matrix3x3 = new double[,]   
                { {  3.0, 0.0, 0.0, },  
                  {  0.0, -2.0, 0.0, },  
                  {  0.0, 0.0, -2.0, }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterGray(img, Matrix3x3);
            }
        }

        private void x3ColorToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            double[,] Matrix3x3 = new double[,]   
                { {  3.0, 0.0, 0.0, },  
                  {  0.0, -2.0, 0.0, },  
                  {  0.0, 0.0, -2.0, }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterColor(img, Matrix3x3);
            }
        }

        private void x5GrayToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            double[,] Matrix5x5 = new double[,]
                { {  -1.0, -1.0, -1.0, -1.0, 0.0 },  
                  {  -1.0, -1.0, -1.0, 0.0, 1.0 },  
                  {  -1.0, -1.0, 0.0, 1.0, 1.0 },
                  {  -1.0, 0.0, 1.0, 1.0, 1.0 }, 
                  {  0.0, 1.0, 1.0, 1.0, 1.0 }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterGray(img, Matrix5x5);
            }
        }

        private void x5ColorToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            double[,] Matrix5x5 = new double[,]
                { {  -1.0, -1.0, -1.0, -1.0, 0.0 },  
                  {  -1.0, -1.0, -1.0, 0.0, 1.0 },  
                  {  -1.0, -1.0, 0.0, 1.0, 1.0 },
                  {  -1.0, 0.0, 1.0, 1.0, 1.0 }, 
                  {  0.0, 1.0, 1.0, 1.0, 1.0 }, };

            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                pictureBox2.Image = colvFilterColor(img, Matrix5x5);
            }
        }

        //====================I/O 2 Menu====================

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            open(pictureBox2, image2, path2, detailsListBox2, "RIGHT");
        }

        private void openAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openAs(pictureBox2, image2, path2, detailsListBox2, "RIGHT");
        }

        private void openURLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openUrl(pictureBox2, urlTextBox2, image2, path2, detailsListBox2, "RIGHT");
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            save(pictureBox2);
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveAs(pictureBox2);
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clear(pictureBox2, "RIGHT");
        }

        //====================Bottom Features====================

        private void flipXButton_Click(object sender, EventArgs e)
        {
            flipXLog();
        }

        private void flipYButton_Click(object sender, EventArgs e)
        {
            flipYLog();
        }

        private void trackBarX_Scroll(object sender, EventArgs e)
        {
            trackBarRot();
        }

        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {
            trackBarZoo();
        }

        private void colorBinaryButton_Click(object sender, EventArgs e)
        {
            colorBinary();
        }

        private void binaryButton_Click(object sender, EventArgs e)
        {
            binary();
        }

        private void gammaButton_Click(object sender, EventArgs e)
        {
            gamma();
        }

        private void contrastButton_Click(object sender, EventArgs e)
        {
            contrast();
        }

        private void brightnessButton_Click(object sender, EventArgs e)
        {
            brightness();
        }

        //====================Logic====================

        private void open(PictureBox picBox, Image image, String path, ListBox listBox, String side)
        {
            path = @"c:\UNI\VS_Projects\Resources\pikapika.jpg";
            image = Image.FromFile(path);

            picBox.Image = image;
            picBox.SizeMode = PictureBoxSizeMode.Normal;

            if (side.Equals("LEFT"))
            {
                this.path = path;
                this.image = image;
            }
            else if (side.Equals("RIGHT"))
            {
                this.path2 = path;
                this.image2 = image;
            }

            clearPopulate(side);
            details(path, listBox);
        }

        private void save(PictureBox picBox)
        {
            if (picBox.Image != null)
            {
                picBox.Image.Save(@"c:\UNI\VS_Projects\Resources\SaveFolder\Juno01.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                picBox.Image.Save(@"c:\UNI\VS_Projects\Resources\SaveFolder\Juno01.png", System.Drawing.Imaging.ImageFormat.Png);
                picBox.Image.Save(@"c:\UNI\VS_Projects\Resources\SaveFolder\Juno01.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                picBox.Image.Save(@"c:\UNI\VS_Projects\Resources\SaveFolder\Juno01.gif", System.Drawing.Imaging.ImageFormat.Gif);
                picBox.Image.Save(@"c:\UNI\VS_Projects\Resources\SaveFolder\Juno01.tif", System.Drawing.Imaging.ImageFormat.Tiff);
            }
        }

        private void clear(PictureBox picBox, String side)
        {
            picBox.Image = null;
            picBox.Invalidate();

            if (side.Equals("LEFT"))
            {
                clearFields(detailsListBox, widthTextBox, heightTextBox, vResTextBox, hResTextBox, colorsTextBox);
            }
            else if (side.Equals("RIGHT"))
            {
                clearFields(detailsListBox2, widthTextBox2, heightTextBox2, vResTextBox2, hResTextBox2, colorsTextBox2);
            }
        }

        private void saveAs(PictureBox picBox)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Jpeg Image|*.jpg|Png Image|*.png|Bitmap Image|*.bmp|Gif Image|*.gif|Tiff Image|*.tiff";
            saveFileDialog.Title = "Save as an Image File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "" && picBox.Image != null)
            {
                System.IO.FileStream fileStream = (System.IO.FileStream)saveFileDialog.OpenFile();

                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        picBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        picBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case 3:
                        picBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 4:
                        picBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case 5:
                        picBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                }
            }
        }

        private void openAs(PictureBox picBox, Image image, String path, ListBox listBox, String side)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Jpeg Image|*.jpg|Png Image|*.png|Bitmap Image|*.bmp|Gif Image|*.gif|Tiff Image|*.tiff";
            openFileDialog.Title = "Open from an Image File";
            openFileDialog.ShowDialog();

            try
            {
                System.IO.FileStream fileStream = (System.IO.FileStream)openFileDialog.OpenFile();
                path = openFileDialog.InitialDirectory + openFileDialog.FileName;

                picBox.SizeMode = PictureBoxSizeMode.Normal;
                image = Image.FromFile(path);
                picBox.Image = image;

                if (side.Equals("LEFT"))
                {
                    this.path = path;
                    this.image = image;
                }
                else if (side.Equals("RIGHT"))
                {
                    this.path2 = path;
                    this.image2 = image;
                }

                clearPopulate(side);
                details(path, listBox);
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Error getting image index");
            }

        }

        private void openUrl(PictureBox picBox, TextBox urlTextBox, Image image, String path, ListBox listBox, String side)
        {
            if (!string.IsNullOrWhiteSpace(urlTextBox.Text))
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
                try
                {
                    picBox.Load(urlTextBox.Text);
                    image = pictureBox.Image;

                    path = @"c:\UNI\VS_Projects\Resources\UrlTemp\tmp";
                    picBox.Image.Save(path);

                    if (side.Equals("LEFT"))
                    {
                        this.path = path;
                        this.image = image;
                    }
                    else if (side.Equals("RIGHT"))
                    {
                        this.path2 = path;
                        this.image2 = image;
                    }

                    clearPopulate(side);
                    details(path, listBox);
                }
                catch
                {
                    System.Diagnostics.Debug.WriteLine("Error opening image from URL");
                }
            }
        }

        private void crop(PictureBox picBox, Image image, String path, TextBox cropWidth, TextBox cropHeight, TextBox cropX, TextBox cropY, String side)
        {
            if (!string.IsNullOrWhiteSpace(cropWidth.Text) && !string.IsNullOrWhiteSpace(cropHeight.Text) && !string.IsNullOrWhiteSpace(cropX.Text) && !string.IsNullOrWhiteSpace(cropY.Text))
            {
                try
                {
                    cropImage(image, picBox, Convert.ToInt16(cropWidth.Text), Convert.ToInt16(cropHeight.Text), Convert.ToInt16(cropX.Text), Convert.ToInt16(cropY.Text));
                    picBox.SizeMode = PictureBoxSizeMode.Normal;

                    clearPopulate(side);

                    if (picBox.Image != null)
                    {
                        if (side.Equals("LEFT"))
                        {
                            details(this.path, detailsListBox);
                        }
                        else if (side.Equals("RIGHT"))
                        {
                            details(this.path2, detailsListBox2);
                        }
                    }

                }
                catch
                {
                    System.Diagnostics.Debug.WriteLine("Error cropping image");
                }
            }
        }

        private void cropImage(Image image, PictureBox picBox, int width, int height, int posX, int posY)
        {
            Bitmap bmp = image as Bitmap;

            Point point = new Point(posX, posY);
            Size size = new Size(width, height);
            Rectangle selection = new Rectangle(point, size);

            if (bmp != null && width > 0 && height > 0)
            {
                Bitmap cropBmp = bmp.Clone(selection, bmp.PixelFormat);

                image.Dispose();
                picBox.Image = cropBmp;
            }
        }

        private void clearFields(ListBox listBox, TextBox width, TextBox height, TextBox vRes, TextBox hRes, TextBox colors)
        {
            width.Text = Convert.ToString("");
            height.Text = Convert.ToString("");
            vRes.Text = Convert.ToString("");
            hRes.Text = Convert.ToString("");
            colors.Text = Convert.ToString("");
            listBox.Items.Clear();
        }

        private void populateFields(PictureBox picBox, TextBox cropWidth, TextBox cropHeight, TextBox cropX, TextBox cropY,
            TextBox width, TextBox height, TextBox vRes, TextBox hRes, TextBox colors, TextBox rotate, TextBox zoom, string path)
        {
            if (picBox != null && picBox.Image != null)
            {
                cropWidth.Text = Convert.ToString(0);
                cropHeight.Text = Convert.ToString(0);
                cropX.Text = Convert.ToString(0);
                cropY.Text = Convert.ToString(0);

                width.Text = Convert.ToString(picBox.Image.Width);
                height.Text = Convert.ToString(picBox.Image.Height);
                vRes.Text = Convert.ToString(picBox.Image.VerticalResolution);
                hRes.Text = Convert.ToString(picBox.Image.HorizontalResolution);
                colors.Text = Convert.ToString(getColors(path));

                rotate.Text = Convert.ToString(0);
                zoom.Text = Convert.ToString(1);
                gammaBox.Text = Convert.ToString(0);
                binaryTextBox.Text = Convert.ToString(0);
                binaryColorTextBox.Text = Convert.ToString(0);

                colorOne1.Text = Convert.ToString(0);
                colorOne2.Text = Convert.ToString(0);
                colorOne3.Text = Convert.ToString(0);
                colorTwo1.Text = Convert.ToString(0);
                colorTwo2.Text = Convert.ToString(0);
                colorTwo3.Text = Convert.ToString(0);
            }
        }

        private void populateFields(PictureBox picBox, TextBox width, TextBox height, TextBox vRes, TextBox hRes, TextBox colors, TextBox rotate, TextBox zoom, string path)
        {
            if (picBox != null && picBox.Image != null)
            {

                width.Text = Convert.ToString(picBox.Image.Width);
                height.Text = Convert.ToString(picBox.Image.Height);
                vRes.Text = Convert.ToString(picBox.Image.VerticalResolution);
                hRes.Text = Convert.ToString(picBox.Image.HorizontalResolution);
                colors.Text = Convert.ToString(getColors(path));

                rotate.Text = Convert.ToString(0);
                zoom.Text = Convert.ToString(1);
                gammaBox.Text = Convert.ToString(0);
                binaryTextBox.Text = Convert.ToString(0);
                binaryColorTextBox.Text = Convert.ToString(0);

                colorOne1.Text = Convert.ToString(0);
                colorOne2.Text = Convert.ToString(0);
                colorOne3.Text = Convert.ToString(0);
                colorTwo1.Text = Convert.ToString(0);
                colorTwo2.Text = Convert.ToString(0);
                colorTwo3.Text = Convert.ToString(0);
            }
        }

        private void details(string fileName, ListBox listbox)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            listbox.Items.Clear();

            listbox.Items.Add("Name: " + fileInfo.Name);
            listbox.Items.Add("Size: " + fileInfo.Length + " bytes");
            listbox.Items.Add("Location: " + fileInfo.DirectoryName);
            listbox.Items.Add("Extension: " + fileInfo.Extension);
            listbox.Items.Add("Attributes: " + fileInfo.Attributes.ToString());

            listbox.Items.Add("Creation date: " + fileInfo.CreationTime.ToShortDateString());
            listbox.Items.Add("Access date: " + fileInfo.LastAccessTime.ToShortDateString());
            listbox.Items.Add("Modification date: " + fileInfo.LastWriteTime.ToShortDateString());
        }

        private void clearPopulate(String side)
        {
            if (side.Equals("LEFT"))
            {
                clearFields(detailsListBox, widthTextBox, heightTextBox, vResTextBox, hResTextBox, colorsTextBox);
                populateFields(pictureBox, cropWidthTextBox, cropHeightTextBox, cropPosX, cropPosY, widthTextBox,
                     heightTextBox, vResTextBox, hResTextBox, colorsTextBox, rotateBox, zoomBox, path);
            }
            else if (side.Equals("RIGHT"))
            {
                clearFields(detailsListBox2, widthTextBox2, heightTextBox2, vResTextBox2, hResTextBox2, colorsTextBox2);
                populateFields(pictureBox2, widthTextBox2, heightTextBox2, vResTextBox2, hResTextBox2, colorsTextBox2, rotateBox, zoomBox, path);
            }
        }

        private int getColors(String fileName)
        {
            int count = 0;
            HashSet<Color> colors = new HashSet<Color>();
            Bitmap bmp = null;

            if (File.Exists(fileName))
            {
                try
                {
                    bmp = new Bitmap(fileName);
                    if (bmp != null)
                    {
                        for (int y = 0; y < bmp.Size.Height; y++)
                        {
                            for (int x = 0; x < bmp.Size.Width; x++)
                            {
                                colors.Add(bmp.GetPixel(x, y));
                            }
                        }
                        count = colors.Count;
                    }
                }
                catch
                {
                    System.Diagnostics.Debug.WriteLine("Error getting image colors");
                }
                finally
                {
                    colors.Clear();
                    bmp.Dispose();
                }
            }
            return count;
        }

        private void flipXLog()
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox2.Image = pictureBox.Image;
            }
        }

        private void flipYLog()
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox2.Image = pictureBox.Image;
            }
        }

        private void trackBarRot()
        {
            rotateBox.Text = trackBarX.Value.ToString();

            if (trackBarX.Value >= 0)
            {
                pictureBox2.Image = RotateImage(image, trackBarX.Value);
            }
        }

        private Image RotateImage(Image image, int angle)
        {
            if (pictureBox.Image != null)
            {
                PointF offset = new PointF((float)image.Width / 2, (float)image.Height / 2);

                Bitmap bitmap = new Bitmap(image.Width, image.Height);
                bitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.TranslateTransform(offset.X, offset.Y);
                graphics.RotateTransform(angle);
                graphics.TranslateTransform(-offset.X, -offset.Y);

                try
                {
                    graphics.DrawImage(image, new Point(0, 0));
                }
                catch
                {
                    System.Diagnostics.Debug.WriteLine("Out of memory");
                }

                return bitmap;
            }
            return null;
        }

        private void trackBarZoo()
        {
            zoomBox.Text = trackBarZoom.Value.ToString();

            if (trackBarZoom.Value >= 1)
            {
                pictureBox2.Image = ZoomImage(image, trackBarZoom.Value);
            }
        }

        private Image ZoomImage(Image image, int zoom)
        {
            if (pictureBox.Image != null)
            {
                Bitmap bitmap = new Bitmap(image, Convert.ToInt32(image.Width * zoom), Convert.ToInt32(image.Height * zoom));

                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                return bitmap;
            }
            return null;
        }

        private void grayScale1()
        {
            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color color = img.GetPixel(i, j);

                        int r = color.R;
                        int g = color.G;
                        int b = color.B;

                        int avg = (r + g + b) / 3;

                        img.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                        pictureBox2.Image = img;
                    }
                }
            }
        }

        private void grayScale2()
        {
            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color color = img.GetPixel(i, j);

                        int r = Convert.ToInt16(0.299 * color.R);
                        int g = Convert.ToInt16(0.587 * color.G);
                        int b = Convert.ToInt16(0.114 * color.B);

                        int avg = r + g + b;

                        img.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                        pictureBox2.Image = img;
                    }
                }
            }
        }

        private void grayScale3()
        {
            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color color = img.GetPixel(i, j);

                        int r = Convert.ToInt16(0.11 * color.R);
                        int g = Convert.ToInt16(0.59 * color.G);
                        int b = Convert.ToInt16(0.30 * color.B);

                        int avg = r + g + b;

                        img.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                        pictureBox2.Image = img;
                    }
                }
            }
        }

        private void negative()
        {
            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color color = img.GetPixel(i, j);

                        int r = 255 - color.R;
                        int g = 255 - color.G;
                        int b = 255 - color.B;

                        img.SetPixel(i, j, Color.FromArgb(r, g, b));
                        pictureBox2.Image = img;
                    }
                }
            }
        }

        private void sepia()
        {
            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color color = img.GetPixel(i, j);

                        int r = Convert.ToInt16(0.393 * color.R + 0.769 * color.G + 0.189 * color.B);
                        int g = Convert.ToInt16(0.349 * color.R + 0.686 * color.G + 0.168 * color.B); ;
                        int b = Convert.ToInt16(0.272 * color.R + 0.534 * color.G + 0.131 * color.B); ;

                        restrictColors(r, g, b);
                        img.SetPixel(i, j, Color.FromArgb(r, g, b));
                        pictureBox2.Image = img;
                    }
                }
            }
        }

        private void riddle()
        {
            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color color = img.GetPixel(i, j);

                        int r = 255 - color.R;
                        int g = 255 - color.G;
                        int b = 255 - color.B;

                        int avg = (r + g + b) / 3;

                        img.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                        pictureBox2.Image = img;
                    }
                }
            }
        }

        private void redChannel()
        {
            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color color = img.GetPixel(i, j);

                        int r = color.R;
                        int g = 0;
                        int b = 0;

                        img.SetPixel(i, j, Color.FromArgb(r, g, b));
                        pictureBox2.Image = img;
                    }
                }
            }
        }

        private void greenChannel()
        {
            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color color = img.GetPixel(i, j);

                        int r = 0;
                        int g = color.G;
                        int b = 0;

                        img.SetPixel(i, j, Color.FromArgb(r, g, b));
                        pictureBox2.Image = img;
                    }
                }
            }
        }

        private void blueChannel()
        {
            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color color = img.GetPixel(i, j);

                        int r = 0;
                        int g = 0;
                        int b = color.B;

                        img.SetPixel(i, j, Color.FromArgb(r, g, b));
                        pictureBox2.Image = img;
                    }
                }
            }
        }

        private void colorBinary()
        {
            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color color = img.GetPixel(i, j);
                        double thershold = (double)binaryColorTrackBar.Value;
                        int r = color.R;
                        int g = color.G;
                        int b = color.B;
                        int sum = r + g + b;

                        if (sum > thershold)
                        {
                            r = Convert.ToInt16(colorOne1.Text);
                            g = Convert.ToInt16(colorOne2.Text);
                            b = Convert.ToInt16(colorOne3.Text);
                        }
                        else
                        {
                            r = Convert.ToInt16(colorTwo1.Text);
                            g = Convert.ToInt16(colorTwo2.Text);
                            b = Convert.ToInt16(colorTwo3.Text);
                        }

                        img.SetPixel(i, j, Color.FromArgb(r, g, b));
                        pictureBox2.Image = img;
                    }
                }
            }
        }

        private void binary()
        {
            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color color = img.GetPixel(i, j);
                        double thershold = (double)binaryTrackBar.Value;
                        int r = color.R;
                        int g = color.G;
                        int b = color.B;
                        int sum = r + g + b;

                        if (sum > thershold)
                        {
                            r = 255;
                            g = 255;
                            b = 255;
                        }
                        else
                        {
                            r = 0;
                            g = 0;
                            b = 0;
                        }

                        img.SetPixel(i, j, Color.FromArgb(r, g, b));
                        pictureBox2.Image = img;
                    }
                }
            }
        }

        private void gamma()
        {
            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color color = img.GetPixel(i, j);
                        double gamma = (double)gammaTrackBar.Value * 0.01;
                        int r = Convert.ToInt32(255 * Math.Pow(color.R / 255.0, 1 / gamma));
                        int g = Convert.ToInt32(255 * Math.Pow(color.G / 255.0, 1 / gamma));
                        int b = Convert.ToInt32(255 * Math.Pow(color.B / 255.0, 1 / gamma));

                        restrictColors(r, g, b);
                        img.SetPixel(i, j, Color.FromArgb(r, g, b));
                        pictureBox2.Image = img;
                    }
                }
            }
        }

        private void binaryTrackBar_Scroll(object sender, EventArgs e)
        {
            double thershold = (double)binaryTrackBar.Value;
            binaryTextBox.Text = thershold.ToString();
        }

        private void gammaTrackBar_Scroll(object sender, EventArgs e)
        {
            double gamma = (double)gammaTrackBar.Value * 0.01;
            gammaBox.Text = gamma.ToString();
        }

        private void binaryColorTrackBar_Scroll(object sender, EventArgs e)
        {
            double thershold = (double)binaryColorTrackBar.Value;
            binaryColorTextBox.Text = thershold.ToString();
        }

        private void contrast()
        {
            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color color = img.GetPixel(i, j);
                        double contrast = Math.Pow(((100.0 + (double)contrastTrackBar.Value) / 100), 2);
                        int r = Convert.ToInt32(((((color.R / 255.0) - 0.5) * contrast) + 0.5) * 255.0);
                        int g = Convert.ToInt32(((((color.G / 255.0) - 0.5) * contrast) + 0.5) * 255.0);
                        int b = Convert.ToInt32(((((color.B / 255.0) - 0.5) * contrast) + 0.5) * 255.0);

                        restrictColors(r, g, b);
                        img.SetPixel(i, j, Color.FromArgb(r, g, b));
                        pictureBox2.Image = img;
                    }
                }
            }
        }

        private void contrastTrackBar_Scroll(object sender, EventArgs e)
        {
            double contrast = Math.Pow(((100.0 + (double)contrastTrackBar.Value) / 100), 2);
            contrastTextBox.Text = contrast.ToString();
        }

        private void brightness()
        {
            if (pictureBox.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox.Image);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color color = img.GetPixel(i, j);
                        double brightness = (double)brightnessTrackBar.Value;
                        int r = Convert.ToInt32(Math.Round(color.R * brightness / 100.0));
                        int g = Convert.ToInt32(Math.Round(color.G * brightness / 100.0));
                        int b = Convert.ToInt32(Math.Round(color.B * brightness / 100.0));

                        restrictColors(r, g, b);
                        img.SetPixel(i, j, Color.FromArgb(r, g, b));
                        pictureBox2.Image = img;
                    }
                }
            }
        }

        private void brightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            double brightness = (double)brightnessTrackBar.Value;
            brightnessTextbox.Text = brightness.ToString();
        }

        private void restrictColors(int r, int g, int b)
        {
            if (r > 255)
            {
                r = 255;
            }
            if (g > 255)
            {
                g = 255;
            }
            if (b > 255)
            {
                b = 255;
            }
            if (r < 0)
            {
                r = 0;
            }
            if (g < 0)
            {
                g = 0;
            }
            if (b < 0)
            {
                b = 0;
            }
        }

        private Bitmap colvFilterColor(Bitmap img, double[,] matrix)
        {
            Bitmap cloneImg = new Bitmap(img);
            Bitmap outputImg = new Bitmap(cloneImg);

            double rgb;
            double r;
            double g;
            double bc;
            double factor;

            for (int i = 1; i < cloneImg.Width - 1; i++)
            {
                for (int j = 1; j < cloneImg.Height - 1; j++)
                {
                    r = 0;
                    g = 0;
                    bc = 0;
                    factor = 0;

                    for (int a = -1; a < 2; a++)
                    {
                        for (int b = -1; b < 2; b++)
                        {
                            r += (cloneImg.GetPixel(i + a, j + b).R * matrix[a + 1, b + 1]);
                            g += (cloneImg.GetPixel(i + a, j + b).G * matrix[a + 1, b + 1]);
                            bc += (cloneImg.GetPixel(i + a, j + b).B * matrix[a + 1, b + 1]);

                            factor += matrix[a + 1, b + 1];
                        }
                    }

                    r = Math.Min(Math.Max((r / factor), 0), 255);
                    g = Math.Min(Math.Max((g / factor), 0), 255);
                    bc = Math.Min(Math.Max((bc / factor), 0), 255);

                    outputImg.SetPixel(i, j, Color.FromArgb((int)r, (int)g, (int)bc));
                }
            }

            return outputImg;
        }

        private Bitmap colvFilterGray(Bitmap img, double[,] matrix)
        {
            Bitmap cloneImg = new Bitmap(img);
            Bitmap outputImg = new Bitmap(cloneImg);

            double rgb;
            double factor;

            for (int i = 1; i < cloneImg.Width - 1; i++)
            {
                for (int j = 1; j < cloneImg.Height - 1; j++)
                {
                    rgb = 0;
                    factor = 0;

                    for (int a = -1; a < 2; a++)
                    {
                        for (int b = -1; b < 2; b++)
                        {
                            rgb += (cloneImg.GetPixel(i + a, j + b).R * matrix[a + 1, b + 1] +
                                cloneImg.GetPixel(i + a, j + b).G * matrix[a + 1, b + 1] +
                                cloneImg.GetPixel(i + a, j + b).B * matrix[a + 1, b + 1]);

                            factor += matrix[a + 1, b + 1];
                        }
                    }

                    rgb = Math.Min(Math.Max((rgb / (factor * 3)), 0), 255);
                    int result = Convert.ToInt32(rgb);

                    outputImg.SetPixel(i, j, Color.FromArgb(result, result, result));
                }
            }

            return outputImg;
        }

        //====================Project====================

        private string[] chars = { "#", "#", "@", "%", "=", "+", "*", ":", "-", ".", "&nbsp;" };
        private string content;

        private void convertToTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asciiArt();
        }

        private void asciiButton_Click(object sender, EventArgs e)
        {
            asciiArt();
        }

        private void asciiArt()
        {
                try
                {
                    Bitmap image = new Bitmap(this.image);
                    int size = Convert.ToInt32(asciiSize.Text);

                    image = resizeImage(image, size);

                    content = convertToAscii(image);
                    content = content.Replace("&nbsp;", " ").Replace("<BR>", "\n");

                    asciTextBox.Visible = true;
                    asciTextBox.WordWrap = false;
                    asciTextBox.SelectionAlignment = HorizontalAlignment.Center;

                    asciTextBox.Text = content;
                }
                catch
                {
                    System.Diagnostics.Debug.WriteLine("Error converting image");
                }
        }

        private string convertToAscii(Bitmap image)
        {
            Boolean toggle = false;
            StringBuilder sb = new StringBuilder();

            for (int h = 0; h < image.Height; h++)
            {
                for (int w = 0; w < image.Width; w++)
                {
                    Color pixelColor = image.GetPixel(w, h);
                    int red = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int green = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int blue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color grayColor = Color.FromArgb(red, green, blue);

                    if (!toggle)
                    {
                        int index = (grayColor.R * 10) / 255;
                        sb.Append(chars[index]);
                    }
                }
                if (!toggle)
                {
                    sb.Append("<BR>");
                    toggle = true;
                }
                else
                {
                    toggle = false;
                }
            }

            return sb.ToString();
        }

        private Bitmap resizeImage(Bitmap inputBitmap, int asciiWidth)
        {
            int asciiHeight = (int) Math.Ceiling((double) inputBitmap.Height * asciiWidth / inputBitmap.Width);

            Bitmap result = new Bitmap(asciiWidth, asciiHeight);
            Graphics g = Graphics.FromImage((Image)result);

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(inputBitmap, 0, 0, asciiWidth, asciiHeight);
            g.Dispose();

            return result;
        }
        
    }
}
