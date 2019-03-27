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

//Created by Mateusz Baranowski [AIR]

namespace ImageApp
{
    public partial class ImageProcessApp : Form
    {
        
        public ImageProcessApp() { InitializeComponent(); }


        //====================Primary Display Side====================

        private Image image;
        private String path;

        private void openButton_Click(object sender, EventArgs e)
        {
            open(pictureBox, image, path, detailsListBox, "LEFT");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            save(pictureBox);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear(pictureBox, "LEFT");
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            saveAs(pictureBox);
        }

        private void openAsButton_Click(object sender, EventArgs e)
        {
            openAs(pictureBox, image, path, detailsListBox, "LEFT");
        }

        private void openUrlButton_Click(object sender, EventArgs e)
        {
            openUrl(pictureBox, urlTextBox, image, path, detailsListBox, "LEFT");
        }

        private void cropButton_Click(object sender, EventArgs e)
        {
            crop(pictureBox, image, path, cropWidthTextBox, cropHeightTextBox, cropPosX, cropPosY, "LEFT");
        }

        private void flipX_Click(object sender, EventArgs e)
        {
            flipXLog();
        }

        private void flipY_Click(object sender, EventArgs e)
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


        //====================Secondary Display Side====================

        private Image image2;
        private String path2;

        private void openButton2_Click(object sender, EventArgs e)
        {
            open(pictureBox2, image2, path2, detailsListBox2, "RIGHT");
        }

        private void saveButton2_Click(object sender, EventArgs e)
        {
            save(pictureBox2);
        }

        private void clearButton2_Click(object sender, EventArgs e)
        {
            clear(pictureBox2, "RIGHT");
        }

        private void saveAsButton2_Click(object sender, EventArgs e)
        {
            saveAs(pictureBox2);
        }

        private void openAsButton2_Click(object sender, EventArgs e)
        {
            openAs(pictureBox2, image2, path2, detailsListBox2, "RIGHT");
        }

        private void openUrlButton2_Click(object sender, EventArgs e)
        {
            openUrl(pictureBox2, urlTextBox2, image2, path2, detailsListBox2, "RIGHT");
        }

        private void cropButton2_Click(object sender, EventArgs e)
        {
            crop(pictureBox2, image2, path2, cropWidthTextBox2, cropHeightTextBox2, cropPosX2, cropPosY2, "RIGHT");
        }


        //====================Logic Side====================

        private void open(PictureBox picBox, Image image, String path, ListBox listBox, String side)
        {
            path = @"c:\UNI\VS_Projects\Resources\Juno.jpg";
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
                   
                    if(picBox.Image != null) 
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
                populateFields(pictureBox2, cropWidthTextBox2, cropHeightTextBox2, cropPosX2, cropPosY2, widthTextBox2,
                    heightTextBox2, vResTextBox2, hResTextBox2, colorsTextBox2, rotateBox, zoomBox, path);
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

    }
}
