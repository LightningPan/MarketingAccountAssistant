using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ImageProcessingDemo1;

namespace ImageProcessingDemo1
{
    class PictureProcessing
    {
        private void OverFlowRBG(int r,int b,int g,out int Cr,out int Cb, out int Cg)
        {
            Cr = r;
            Cb = b;
            Cg = g;
            if (r > 255) Cr = 255;
            if (r < 0) Cr = 0;
            if (g > 255) Cg = 255;
            if (g < 0) Cg = 0;
            if (b > 255) Cb = 255;
            if (b < 0) Cb = 0;
        }
        public Bitmap OpenFile(bool flag,string FileName)
        {
            Bitmap bitmap=new Bitmap(100,100,PixelFormat.Format32bppArgb);
            if (flag)//openImageDialog.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Image image = (Bitmap)System.Drawing.Image.FromFile(FileName);
                //bitmap = new Bitmap(image, pictureBox1.Width, pictureBox1.Height);
                bitmap = new Bitmap(image);
                return bitmap;
                // ConvertedImage.SetFrame();
            }
            else
                return bitmap;
        }
        public Bitmap GetBit(Size size, Point point)
        {
            Double Factor = 1.5;
            int SizeX = Convert.ToInt32(size.Width * Factor);
            int SizeY = Convert.ToInt32(size.Height * Factor);
            Bitmap bit = new Bitmap(SizeX, SizeY);
            int x = Convert.ToInt32(point.X * Factor);
            int y = Convert.ToInt32(point.Y * Factor);
            Graphics g = Graphics.FromImage(bit);
            g.CopyFromScreen(x, y, 0, 0, new Size(SizeX, SizeY));
            g.CompositingQuality = CompositingQuality.HighQuality;
            return bit;
        }
        public void SaveFile(bool flag,string fileName,Bitmap bit,out bool changeFlag)
        {
            if (flag)
            {
                changeFlag = false;
                bool NeedSave = true;
                if (fileName != "" && fileName != null)
                {
                    string fileExtName = fileName.Substring(fileName.LastIndexOf(".") + 1).ToString();
                    System.Drawing.Imaging.ImageFormat imageFormat = null;
                    if (fileExtName != "")
                    {
                        switch (fileExtName)
                        {
                            case "jpg":
                                imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                            case "bmp":
                                imageFormat = System.Drawing.Imaging.ImageFormat.Bmp;
                                break;
                            case "gif":
                                imageFormat = System.Drawing.Imaging.ImageFormat.Gif;
                                break;
                            default:
                                MessageBox.Show("只能存取为：jpg、bmp、gif格式");
                                NeedSave = false;
                                break;
                        }
                    }
                    if (imageFormat == null)
                    {
                        imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                    }
                    if (NeedSave)
                    {
                        try
                        {
                            bit.Save(fileName, imageFormat);
                            MessageBox.Show("保存成功！");
                            changeFlag = true;
                        }
                        catch
                        {
                            MessageBox.Show("保存失败！");
                        }
                    }
                }
            }
            else
            {
                changeFlag = false;
                return;
            }
        }
        public Bitmap DarkCorner(Bitmap bitmap,int value)
        {
            if (bitmap != null)
            {
                Bitmap NewBitmap = bitmap.Clone() as Bitmap;
                int width = NewBitmap.Width;
                int height = NewBitmap.Height;
                double cx = width / 2;
                double cy = height / 2;
                double maxDist = cx * cx + cy * cy;
                double currDist = 0, factor;
                Color color;
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        currDist = ((double)i - cx) * ((double)i - cx) + ((double)j - cy) * ((double)j - cy);
                        factor = currDist * value / maxDist / 100;
                        color = NewBitmap.GetPixel(i, j);
                        int red = (int)(color.R * (1 - factor));
                        int green = (int)(color.G * (1 - factor));
                        int blue = (int)(color.B * (1 - factor));
                        NewBitmap.SetPixel(i, j, Color.FromArgb(red, green, blue));
                    }
                }
                return NewBitmap;
            }
            else
            {
                throw new Exception("未打开图片文件");
            }
        }
        public Bitmap BrightNess(Bitmap bitmap,int value)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Color color;
                int red, green, blue;
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < newbitmap.Height; y++)
                    {
                        color = newbitmap.GetPixel(x, y);
                        red = (int)(color.R * value / 100);
                        green = (int)(color.G * value / 100);
                        blue = (int)(color.B * value / 100);
                        newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
                return newbitmap;
            }
            else
            {
                throw new Exception("未打开图片文件");
            }
        }
        public Bitmap DeColor(Bitmap bitmap)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Color color;
                int gray;
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < newbitmap.Height; y++)
                    {
                        color = newbitmap.GetPixel(x, y);
                        gray = (int)(0.3 * color.R + 0.59 * color.G + 0.11 * color.B);
                        newbitmap.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                    }
                }
                return newbitmap;
            }
            else
            {
                throw new Exception("未打开图片文件");
            }
        }
        public Bitmap ReverseColor(Bitmap bitmap)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Color color;
                int red, green, blue;
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < newbitmap.Height; y++)
                    {
                        color = newbitmap.GetPixel(x, y);
                        red = (int)(255 - color.R);
                        green = (int)(255 - color.G);
                        blue = (int)(255 - color.B);
                        newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
                return newbitmap;
            }
            else
            {
                throw new Exception("未打开图片文件");
            }
        }
        public Bitmap Relife(Bitmap bitmap)
        {
            if (bitmap != null)
            {
                int height = bitmap.Height;
                int width = bitmap.Width;
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Color color1, color2;
                for(int x=0; x<width-1;x++)
                {
                    for(int y=0;y<height-1;y++)
                    {
                        int r = 0, g = 0, b = 0;
                        color1 = bitmap.GetPixel(x, y);
                        color2 = bitmap.GetPixel(x + 1, y + 1);
                        r = Math.Abs(color1.R - color2.R + 128);
                        g = Math.Abs(color1.G - color2.G + 128);
                        b = Math.Abs(color1.B - color2.B + 128);
                        OverFlowRBG(r, b, g, out r, out b, out g);
                        newbitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }
                return newbitmap;
            }
            else
            {
                throw new Exception("未打开图片文件");
            }
        }
            public Bitmap Mosic(Bitmap bitmap,int value)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                if (value == 0)
                {
                    throw new Exception("该效果参数不能为0");
                }
                int RIDIO = value;
                for (int h = 0; h < newbitmap.Height; h += RIDIO)
                {
                    for (int w = 0; w < newbitmap.Width; w += RIDIO)
                    {
                        int avgRed = 0, avgGreen = 0, avgBlue = 0;
                        int count = 0;
                        for (int x = w; (x < w + RIDIO && x < newbitmap.Width); x++)
                        {
                            for (int y = h; (y < h + RIDIO && y < newbitmap.Height); y++)
                            {
                                Color color = newbitmap.GetPixel(x, y);
                                avgRed += color.R;
                                avgGreen += color.G;
                                avgBlue += color.B;
                                count++;
                            }
                        }
                        avgRed = avgRed / count;
                        avgGreen = avgGreen / count;
                        avgBlue = avgBlue / count;
                        for (int x = w; (x < w + RIDIO && x < newbitmap.Width); x++)
                        {
                            for (int y = h; (y < h + RIDIO && y < newbitmap.Height); y++)
                            {
                                Color newColor = Color.FromArgb(avgRed, avgGreen, avgBlue);
                                newbitmap.SetPixel(x, y, newColor);
                            }
                        }
                    }
                }
                return newbitmap;
            }
            else
            {
                throw new Exception("未打开图片文件");
            }
        }
        public Bitmap Spread(Bitmap bitmap)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Color color;
                int red, green, blue;
                int flag = 0;
                for (int x = 0; x < newbitmap.Width; x++)
                {
                    for (int y = 0; y < newbitmap.Height; y++)
                    {
                        Random random = new Random();
                        int RankKey = random.Next(-5, 5);
                        if (x + RankKey >= newbitmap.Width || y + RankKey >= newbitmap.Height || x + RankKey < 0 || y + RankKey < 0)
                        {
                            flag = 1;
                            continue;
                        }
                        color = newbitmap.GetPixel(x + RankKey, y + RankKey);
                        red = (int)(color.R);
                        green = (int)(color.G);
                        blue = (int)(color.B);
                        newbitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
                return newbitmap;
            }
            else
            {
                throw new Exception("未打开图片文件");
            }
        }
        public Bitmap AtomizationChange(Bitmap bitmap)
        {
            if (bitmap != null)
            {
                int height = bitmap.Height;
                int width = bitmap.Width;
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Color color;
                for(int x=1;x<width-1;x++)
                {
                    for(int y=1;y<height-1;y++)
                    {
                        System.Random MyRandom = new Random();
                        int k = MyRandom.Next(123456);
                        int dx = x + k % 19;
                        int dy = y + k % 19;
                        if (dx >= width) dx = width - 1;
                        if (dy >= height) dy = height - 1;
                        color = bitmap.GetPixel(x, y);
                    }
                }
                return newbitmap;
            }
            else
            {
                throw new Exception("未打开图片文件");
            }
        }
        public Bitmap SharpenChange(Bitmap bitmap)
        {
            if (bitmap != null)
            {
                int height = bitmap.Height;
                int width = bitmap.Width;
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Color color;
                int[] Laplacin = { -1, -1, -1, -1, 9, -1, -1, -1, -1 };
                for (int x = 1; x < width - 1; x++)
                    for (int y = 1; y < height - 1; y++)
                    {
                        int r = 0, g = 0, b = 0;
                        int Index = 0;
                        for(int col=-1;col<=1;col++)
                            for(int row=-1;row<=1;row++)
                            {
                                color = bitmap.GetPixel(x + row, y + col);
                                r += color.R * Laplacin[Index];
                                g += color.G * Laplacin[Index];
                                b += color.B * Laplacin[Index];
                                Index++;
                            }
                            OverFlowRBG(r, b, g, out r, out b, out g);
                            newbitmap.SetPixel(x - 1, y - 1, Color.FromArgb(r, g, b));
                    }
                return newbitmap;
            }
            else
            {
                throw new Exception("未打开图片文件");
            }
        }
        public Bitmap BlurChange(Bitmap bitmap)
        {
            if (bitmap != null)
            {
                int height = bitmap.Height;
                int width = bitmap.Width;
                Bitmap newbitmap = bitmap.Clone() as Bitmap;
                Color color;
                int[] Laplacin = { 1, 2, 1, 2, 4, 2, 1, 2, 1 };
                for (int x = 1; x < width - 1; x++)
                    for (int y = 1; y < height - 1; y++)
                    {
                        int r = 0, g = 0, b = 0;
                        int Index = 0;
                        for (int col = -1; col <= 1; col++)
                            for (int row = -1; row <= 1; row++)
                            {
                                color = bitmap.GetPixel(x + row, y + col);
                                r += color.R * Laplacin[Index];
                                g += color.G * Laplacin[Index];
                                b += color.B * Laplacin[Index];
                                Index++;
                            }
                        r /= 16;
                        g /= 16;
                        b /= 16;
                        OverFlowRBG(r, b, g, out r, out b, out g);
                        newbitmap.SetPixel(x - 1, y - 1, Color.FromArgb(r, g, b));
                    }
                return newbitmap;
            }
            else
            {
                throw new Exception("未打开图片文件");
            }
        }
        public Bitmap LevelChange(Bitmap bitmap)
        {
            if (bitmap != null)
            {
                Bitmap newbitmap = new Bitmap(bitmap, bitmap.Width, bitmap.Height);
                int w = bitmap.Width, h = bitmap.Height;
                for(int x=0;x<w;x++)
                {
                    for(int y=0;y<h;y++)
                    {
                        Color color = bitmap.GetPixel(x, y);
                        newbitmap.SetPixel(w - x - 1, y, color);
                    }
                }
                return newbitmap;
            }
            else
            {
                throw new Exception("未打开图片文件");
            }
        }
        public Bitmap VerticalChange(Bitmap bitmap)
        {
            if(bitmap!=null)
            {
                Bitmap newbitmap = new Bitmap(bitmap, bitmap.Width, bitmap.Height);
                int w = bitmap.Width, h = bitmap.Height;
                for (int x = 0; x < w; x++)
                {
                    for (int y = 0; y < h; y++)
                    {
                        Color color = bitmap.GetPixel(x, y);
                        newbitmap.SetPixel(x, h-1-y, color);
                    }
                }
                return newbitmap;
            }
            else
            {
                throw new Exception("未打开图片文件");
            }
        }
    }
}
