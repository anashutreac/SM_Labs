using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_SM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image file;
        Bitmap bmp;

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void flip_image_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)pictureBox.Image;
            bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox.Image = bmp;
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = ".bmp|*.bmp|.jpg|*.jpg|.png|*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(openFile.FileName);
                bmp = new Bitmap(openFile.FileName);
                pictureBox.Image = file;
                flip_image.Enabled = true;
                rotate_right.Enabled = true;
                rotate_left.Enabled = true;
                gray_colors.Enabled = true;
                mirror.Enabled = true;
                negative_colors.Enabled = true;
                save_button.Enabled = true;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = ".bmp | *.bmp |.jpg | *.jpg |.png | *.png";
            if (saveFile.ShowDialog() == DialogResult.OK)
                pictureBox.Image.Save(saveFile.FileName);
        }

        private void rotate_left_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)pictureBox.Image;
            bmp.RotateFlip(RotateFlipType.Rotate270FlipX);
            pictureBox.Image = bmp;
        }

        private void rotate_right_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)pictureBox.Image;
            bmp.RotateFlip(RotateFlipType.Rotate90FlipX);
            pictureBox.Image = bmp;
        }

        private void mirror_Click(object sender, EventArgs e)
        {
            Bitmap mir = bmp;
            //get source image dimension
            int width = mir.Width;
            int height = mir.Height;
            //mirror image
            Bitmap mimg = new Bitmap(width * 2, height);
            for (int y = 0; y < height; y++)
            {
                for (int lx = 0, rx = width * 2 - 1; lx < width; lx++, rx--)
                { //get source pixel value
                    Color p = mir.GetPixel(lx, y);
                    //set mirror pixel value
                    mimg.SetPixel(lx, y, p);
                    mimg.SetPixel(rx, y, p);
                }
            } //load mirror image in picturebox2
            bmp = mimg;
            pictureBox.Image = bmp;
        }

        private void gray_colors_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color originalColor = bmp.GetPixel(x, y);
                    int grayScale = (int)((originalColor.R * .3) + (originalColor.G * .59) + (originalColor.B * .11));
                    Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    bmp.SetPixel(x, y, newColor);
                }
            }
            pictureBox.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
            pictureBox.Image = GammaCorrection(bmp, trackBar1.Value, 1d);
        }
        private Bitmap GammaCorrection(Bitmap img, double gamma, double c = 1d)
        {
            int width = img.Width;
            int height = img.Height;
            BitmapData srcData = img.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = srcData.Stride * srcData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            //PictureBox.Copy(srcData.Scan0, buffer, 0, bytes);
            img.UnlockBits(srcData);
            int current = 0;
            int cChannels = 3;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    current = y * srcData.Stride + x * 4;
                    for (int i = 0; i < cChannels; i++)
                    {
                        double range = (double)buffer[current + i] / 255;
                        double correction = c * Math.Pow(range, gamma);
                        result[current + i] = (byte)(correction * 255);
                    }
                    result[current + 3] = 255;
                }
            }
            Bitmap resImg = new Bitmap(width, height);
            BitmapData resData = resImg.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            //Marshal.Copy(result, 0, resData.Scan0, bytes);
            resImg.UnlockBits(resData);
            return resImg;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
