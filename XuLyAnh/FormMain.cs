using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyAnh
{
    public enum Channels
    {
        Red,
        Green,
        Blue
    }
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog() { Filter = "Image file|*.png;*.jpg;*.bmp;*.gif" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtSrc.Text = dlg.FileName;
                LoadFile(dlg.FileName);
            }
        }

        private void LoadFile(string fileName)
        {
            var bitmap = new Bitmap(fileName);
            picOriginal.Image = bitmap;

            // Load single channel
            var bmp = (Bitmap)bitmap.Clone();
            Grayscale(bmp);
            picRed.Image = bmp;
            bmp = (Bitmap)bitmap.Clone();
            GiamMau(bmp, 4);
            picGreen.Image = bmp;
            bmp = (Bitmap)bitmap.Clone();
            GiamMau(bmp, 8);
            picBlue.Image = bmp;
        }

        private void OnlyChannel(Bitmap bmp, Channels ch)
        {
            int acc = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            
            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
            for (int counter = 0; counter < rgbValues.Length-3; counter += acc)
            {
                switch (ch)
                {
                    case Channels.Red:
                        rgbValues[counter] = 0;
                        rgbValues[counter+1] = 0;
                        break;
                    case Channels.Green:
                        rgbValues[counter] = 0;
                        rgbValues[counter + 2] = 0;
                        break;
                    case Channels.Blue:
                        rgbValues[counter + 1] = 0;
                        rgbValues[counter + 2] = 0;
                        break;
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            bmp.UnlockBits(bmpData);
        }

        int[] cnt = new int[256];
        private void Grayscale(Bitmap bmp)
        {
            int acc = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            for (int i = 0; i < 256; i++) cnt[i] = 0;
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);
            IntPtr ptr = bmpData.Scan0;

            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
            for (int counter = 0; counter < rgbValues.Length - 3; counter += acc)
            {
                byte by = (byte)((0 + rgbValues[counter] + rgbValues[counter + 1] + rgbValues[counter + 2]) / 3);
                rgbValues[counter] = rgbValues[counter+1] = rgbValues[counter+2] = by;
                cnt[by]++;
            }
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            bmp.UnlockBits(bmpData);
        }


        private void GiamMau(Bitmap bmp, int t)
        {
            int acc = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);
            IntPtr ptr = bmpData.Scan0;

            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
            int seg = 255 / t;
            for (int counter = 0; counter < rgbValues.Length - 3; counter += acc)
            {
                for(int i = counter;i<counter+3;i++)
                {
                    int x = rgbValues[i] / seg*seg+seg/2;
                    if (x > 255) x = 255;
                    rgbValues[i] = (byte)x;
                }
            }
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            bmp.UnlockBits(bmpData);
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            (new FormChart(cnt)).Show();
        }
    }
}
