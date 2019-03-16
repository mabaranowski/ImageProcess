using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Created by Mateusz Baranowski [AIR]

namespace ImageApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            Image myImage = Image.FromFile(@"c:\UNI\VS_Projects\Resources\Juno.jpg");
            pictureBox.Image = myImage;
            this.pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

            clearFields();
            widthTextBox.Text = Convert.ToString(pictureBox.Width);
            heightTextBox.Text = Convert.ToString(pictureBox.Height);
            vResTextBox.Text = Convert.ToString(pictureBox.Image.VerticalResolution);
            hResTextBox.Text = Convert.ToString(pictureBox.Image.HorizontalResolution);
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

            Image myImage = Image.FromFile(openFileDialog.InitialDirectory + openFileDialog.FileName);
            pictureBox.Image = myImage;
            this.pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

            clearFields();
            widthTextBox.Text = Convert.ToString(pictureBox.Width);
            heightTextBox.Text = Convert.ToString(pictureBox.Height);
            vResTextBox.Text = Convert.ToString(pictureBox.Image.VerticalResolution);
            hResTextBox.Text = Convert.ToString(pictureBox.Image.HorizontalResolution);
        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            //to delete
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //to delete
        }

        private void clearFields()
        {
            widthTextBox.Text = Convert.ToString("");
            heightTextBox.Text = Convert.ToString("");
            vResTextBox.Text = Convert.ToString("");
            hResTextBox.Text = Convert.ToString("");
        }
    }
}
