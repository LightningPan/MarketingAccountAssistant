using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ImageProcessingDemo1
{
    class ImageEffectManager:Control
    {
        public Bitmap newBitmap = null;
        public Bitmap oldBitmap = null;
        #region Properties

        #endregion
        #region Methods

        public ImageEffectManager()
        {

        }
        public void DisposeBitmap()
        {
            if (newBitmap != null)
            {
                newBitmap.Dispose();
                newBitmap = null;
            }
        }
        public System.Drawing.Image MakeWaterMark(System.Drawing.Image sourceImage)
        {
            int width = sourceImage.Width, height = sourceImage.Height;
            //获取要生成水印的图片
            int centerX = width / 2 - 5;
            int centerY = height / 2 - 10;
            //获取中心,后面减去的是水印的长度和宽度的一半，让水印中心和图片中心重合
            Bitmap newBitmap = new Bitmap(sourceImage);
            //定义绘图对象
            Graphics g = Graphics.FromImage(newBitmap);
            g.DrawImage(newBitmap, 0, 0);

            //定义水印字的字体
            Font font = new Font("Arial", 10, FontStyle.Bold);
            //定义水印字的格式刷
            LinearGradientBrush brush = new LinearGradientBrush(
                        new Rectangle(0, 0, 10, 20),
                        Color.Red,
                        Color.Blue,
                        10f,
                        true
                        );

            //给照片打上水印

            g.DrawString("Gavin", font, brush, centerX, centerY);
            g.Dispose();

            //保存为新的输出图片
            //newBitmap.Save(@"C:\Users\asus\Desktop\gavin2.jpeg",sourceImage.RawFormat);
            return newBitmap;
        }
        public System.Drawing.Image resizeImage(System.Drawing.Image sourceImage, int targetWidth, int targetHeight)
        {
            int width;//图片最终的宽
            int height;//图片最终的高
            try
            {
                ImageFormat format = sourceImage.RawFormat;
                Bitmap targetPicture = new Bitmap(targetWidth, targetHeight);
                Graphics g = Graphics.FromImage(targetPicture);
                g.Clear(Color.White);

                //计算缩放图片的大小
                if (sourceImage.Width > targetWidth && sourceImage.Height <= targetHeight)
                {
                    width = targetWidth;
                    height = (width * sourceImage.Height) / sourceImage.Width;
                }
                else if (sourceImage.Width <= targetWidth && sourceImage.Height > targetHeight)
                {
                    height = targetHeight;
                    width = (height * sourceImage.Width) / sourceImage.Height;
                }
                else if (sourceImage.Width <= targetWidth && sourceImage.Height <= targetHeight)
                {
                    width = sourceImage.Width;
                    height = sourceImage.Height;
                }
                else
                {
                    width = targetWidth;
                    height = (width * sourceImage.Height) / sourceImage.Width;
                    if (height > targetHeight)
                    {
                        height = targetHeight;
                        width = (height * sourceImage.Width) / sourceImage.Height;
                    }
                }
                g.DrawImage(sourceImage, (targetWidth - width) / 2, (targetHeight - height) / 2, width, height);
                sourceImage.Dispose();
                g.Dispose();
                return targetPicture;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }


        public System.Drawing.Image DrawOutCropArea(System.Drawing.Image image, int xPosition, int yPosition, int width, int height)

        {
            Bitmap _bitmapPrevCropArea = image.Clone() as Bitmap;
            //Bitmap bmap = (Bitmap)_bitmapPrevCropArea.Clone();
            Graphics gr = Graphics.FromImage(_bitmapPrevCropArea);
            Brush cBrush = new Pen(Color.FromArgb(150, Color.White)).Brush;
            //用笔刷把没有选择的各个区域刷出来，这里是白色笔刷，这样就能画出出要裁剪的部分
            Rectangle rect1 = new Rectangle(0, 0, _bitmapPrevCropArea.Width, yPosition);//这里是最上面
            Rectangle rect2 = new Rectangle(0, yPosition, xPosition, height);//这里是左边中间部分
            Rectangle rect3 = new Rectangle(0, (yPosition + height), _bitmapPrevCropArea.Width, _bitmapPrevCropArea.Height);//这里是下面，简单起见高度直接大一点就行
            Rectangle rect4 = new Rectangle((xPosition + width), yPosition, (_bitmapPrevCropArea.Width - xPosition - width), height);//这里是右边中间部分
            gr.FillRectangle(cBrush, rect1);
            gr.FillRectangle(cBrush, rect2);
            gr.FillRectangle(cBrush, rect3);
            gr.FillRectangle(cBrush, rect4);
            gr.Dispose();
            return _bitmapPrevCropArea;
            //oldBitmap = (Bitmap)bmap.Clone();

        }
        public System.Drawing.Image Crop(System.Drawing.Image image, int xPosition, int yPosition, int width, int height)
        {
            Bitmap bmap = image.Clone() as Bitmap;

            if (xPosition + width > bmap.Width)

                width = bmap.Width - xPosition;

            if (yPosition + height > bmap.Height)

                height = bmap.Height - yPosition;

            Rectangle rect = new Rectangle(xPosition, yPosition, width, height);
            if ((width > 0) && (height > 0))
            {
                bmap = (Bitmap)bmap.Clone(rect, bmap.PixelFormat);

            }
            return bmap;


        }


        public System.Drawing.Image InsertImage(System.Drawing.Image sourceImage, System.Drawing.Image insertImage, int xPosition, int yPosition)
        {
            //   Bitmap temp = oldBitmap;
            Bitmap bmap = (Bitmap)sourceImage.Clone();
            Graphics gr = Graphics.FromImage(bmap);
            Rectangle rect = new Rectangle(xPosition, yPosition, insertImage.Width, insertImage.Height);
            gr.DrawImage(insertImage, rect);
            gr.Dispose();
            return bmap;
        }


        private void MakeGrayScale(int width, int height)
        {
            Color c;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    c = this.oldBitmap.GetPixel(x, y);
                    ///////////////////////////////////////////////////////
                    //
                    // Average
                    // int value = (c.R + c.G + c.B) / 3;
                    //
                    ///////////////////////////////////////////////////////
                    // Weighted average
                    int value = (int)(0.7 * c.R) +
                        (int)(0.2 * c.G) + (int)(0.1 * c.B);
                    this.newBitmap.SetPixel(x, y,
                        Color.FromArgb(c.A, value, value, value));
                }
            }
        }
        private void MakeSharpenEffect(int width, int height)
        {
            Color pixel;
            //拉普拉斯模板
            int[] Laplacian = { -1, -1, -1, -1, 9, -1, -1, -1, -1 };
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int r = 0, g = 0, b = 0;
                    int Index = 0;
                    for (int col = -1; col <= 1; col++)
                    {
                        for (int row = -1; row <= 1; row++)
                        {
                            pixel = this.oldBitmap.GetPixel(x + row, y + col);
                            r += pixel.R * Laplacian[Index];
                            g += pixel.G * Laplacian[Index];
                            b += pixel.B * Laplacian[Index];
                            Index++;
                        }
                    }
                    //处理颜色值溢出
                    r = r > 255 ? 255 : r;
                    r = r < 0 ? 0 : r;
                    g = g > 255 ? 255 : g;
                    g = g < 0 ? 0 : g;
                    b = b > 255 ? 255 : b;
                    b = b < 0 ? 0 : b;
                    this.newBitmap.SetPixel(x - 1, y - 1,
                        Color.FromArgb(r, g, b));
                }
            }
        }
        #endregion
    }
}
