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

//Created by Mateusz Baranowski [AIR]

namespace ImageApp
{
    public partial class ImageProcessApp : Form
    {

        private Image image;
        private String path;

        public ImageProcessApp()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            path = @"c:\UNI\VS_Projects\Resources\Juno.jpg";
            image = Image.FromFile(path);
           
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;

            clearFields();
            populateFields(path);
            details(path);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Save(@"c:\UNI\VS_Projects\Resources\SaveFolder\Juno01.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                pictureBox.Image.Save(@"c:\UNI\VS_Projects\Resources\SaveFolder\Juno01.png", System.Drawing.Imaging.ImageFormat.Png);
                pictureBox.Image.Save(@"c:\UNI\VS_Projects\Resources\SaveFolder\Juno01.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                pictureBox.Image.Save(@"c:\UNI\VS_Projects\Resources\SaveFolder\Juno01.gif", System.Drawing.Imaging.ImageFormat.Gif);
                pictureBox.Image.Save(@"c:\UNI\VS_Projects\Resources\SaveFolder\Juno01.tif", System.Drawing.Imaging.ImageFormat.Tiff);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pictureBox.Invalidate();
            clearFields();
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Jpeg Image|*.jpg|Png Image|*.png|Bitmap Image|*.bmp|Gif Image|*.gif|Tiff Image|*.tiff";
            saveFileDialog.Title = "Save as an Image File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "" && pictureBox.Image != null)
            {
                System.IO.FileStream fileStream = (System.IO.FileStream)saveFileDialog.OpenFile();

                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        pictureBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break; 
                    case 2:
                        pictureBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Png);
                        break;                   
                    case 3:
                        pictureBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 4:
                        pictureBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case 5:
                        pictureBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                }
            }
        }

        private void openAsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Jpeg Image|*.jpg|Png Image|*.png|Bitmap Image|*.bmp|Gif Image|*.gif|Tiff Image|*.tiff";
            openFileDialog.Title = "Open from an Image File";
            openFileDialog.ShowDialog();

            System.IO.FileStream fileStream = (System.IO.FileStream)openFileDialog.OpenFile();
            path = openFileDialog.InitialDirectory + openFileDialog.FileName;

            pictureBox.SizeMode = PictureBoxSizeMode.Normal;
            image = Image.FromFile(path);
            pictureBox.Image = image;
            
            clearFields();
            populateFields(path);
            details(path);
        }

        private void openUrlButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(urlTextBox.Text))
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
                try
                {
                    pictureBox.Load(urlTextBox.Text);
                    image = pictureBox.Image;

                    path = @"c:\UNI\VS_Projects\Resources\UrlTemp\tmp";
                    pictureBox.Image.Save(path);

                    clearFields();
                    populateFields(path);
                    details(path);
                }
                catch
                {
                    System.Diagnostics.Debug.WriteLine("Error opening image from URL");
                }
            }
        }

        private void cropButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cropWidthTextBox.Text) && !string.IsNullOrWhiteSpace(cropHeightTextBox.Text) && !string.IsNullOrWhiteSpace(cropPosX.Text) && !string.IsNullOrWhiteSpace(cropPosY.Text))
            {
                try
                {
                    cropImage(image, Convert.ToInt16(cropWidthTextBox.Text), Convert.ToInt16(cropHeightTextBox.Text), Convert.ToInt16(cropPosX.Text), Convert.ToInt16(cropPosY.Text));
                    pictureBox.SizeMode = PictureBoxSizeMode.Normal;
                    populateFields(path);
                }
                catch
                {
                    System.Diagnostics.Debug.WriteLine("Error cropping image");
                }
            }
        }

        private void clearFields()
        {
            widthTextBox.Text = Convert.ToString("");
            heightTextBox.Text = Convert.ToString("");
            vResTextBox.Text = Convert.ToString("");
            hResTextBox.Text = Convert.ToString("");
            colorsTextBox.Text = Convert.ToString("");
            detailsListBox.Items.Clear();
        }

        private void populateFields(string path)
        {
            if (pictureBox != null && pictureBox.Image != null)
            {
                cropWidthTextBox.Text = Convert.ToString(0);
                cropHeightTextBox.Text = Convert.ToString(0);
                cropPosX.Text = Convert.ToString(0);
                cropPosY.Text = Convert.ToString(0);
                widthTextBox.Text = Convert.ToString(pictureBox.Image.Width);
                heightTextBox.Text = Convert.ToString(pictureBox.Image.Height);
                vResTextBox.Text = Convert.ToString(pictureBox.Image.VerticalResolution);
                hResTextBox.Text = Convert.ToString(pictureBox.Image.HorizontalResolution);
                colorsTextBox.Text = Convert.ToString(getColors(path));
            }
        }

        private void details(string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            detailsListBox.Items.Clear();

            detailsListBox.Items.Add("Name: " + fileInfo.Name);
            detailsListBox.Items.Add("Size: " + fileInfo.Length + " bytes");
            detailsListBox.Items.Add("Location: " + fileInfo.DirectoryName);
            detailsListBox.Items.Add("Extension: " + fileInfo.Extension);
            detailsListBox.Items.Add("Attributes: " + fileInfo.Attributes.ToString());
            detailsListBox.Items.Add("Creation date: " + fileInfo.CreationTime.ToShortDateString());
            detailsListBox.Items.Add("Access date: " + fileInfo.LastAccessTime.ToShortDateString());
            detailsListBox.Items.Add("Modification date: " + fileInfo.LastWriteTime.ToShortDateString());
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

        private void cropImage(Image image, int width, int height, int posX, int posY)
        {
            Bitmap bmp = image as Bitmap;

            Point point = new Point(posX, posY);
            Size size = new Size(width, height);
            Rectangle selection = new Rectangle(point, size);

            if (bmp != null && width > 0 && height > 0)
            {
                Bitmap cropBmp = bmp.Clone(selection, bmp.PixelFormat);

                image.Dispose();
                pictureBox.Image = cropBmp;
            }
        }

    }
}
