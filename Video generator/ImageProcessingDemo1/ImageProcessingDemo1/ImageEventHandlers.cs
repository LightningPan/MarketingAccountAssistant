using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageProcessingDemo1
{
    class ImageEventHandlers
    {
        public PictureBox PictureBox1, PictureBox2;
        public ImageEffectManager ImageManager;
        public Bitmap oldbitmap;
        public Label TimeLabel;
        public Button OpenImageBtn, WaterBtn, CropBtn, InsertBtn, DrowoutBtn,SourceBtn;
        //以上是需要在form中实现对接的控件，必须赋值才能使用
        //字段、属性
        public string TimeElapsed { get; set; }
        public bool IsDrawOut { get; set; }
        public Point MouseDownedPoint;
        public Point MouseUpedPoint;
        public Point MouseMoveDownPoint;
        public Point MouseMoveUpPoint;
        public bool IsMouseUp { get; set; }
        public float FactorWidth { get; set; }
        public float FactorHeight { get; set; }
        public ImageEventHandlers()
        {
            ImageManager = new ImageEffectManager();
            //初始化
            IsDrawOut = false;

        }
        public void initialize()
        {
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //这里用来设置如何处理图片            

            //各种事件
            PictureBox1.AllowDrop = true;
            //pictureBox2.AllowDrop = true;
            //图片事件
            PictureBox1.MouseWheel += pic1_MouseWheel;
            PictureBox1.MouseMove += pictureBox1_MouseMove;
            PictureBox1.MouseDown += pictureBox1_MouseDown;
            PictureBox1.MouseUp += pictureBox1_MouseUp;
            PictureBox1.DragEnter += pictureBox1_DragEnterLoad;
            PictureBox1.DragDrop += pictureBox1_DragDropLoad;
            //MouseWheel += new MouseEventHandler();
            //按钮事件
            WaterBtn.Click += waterPic_Click;
            CropBtn.Click += cropPic_Click;
            InsertBtn.Click += insertPic_Click;
            DrowoutBtn.Click += drawOut_Click;
            OpenImageBtn.Click += loadImage_Click;
            SourceBtn.MouseDown += sourcePic_MouseDown;
            SourceBtn.MouseUp += sourcePic_MouseUp;
        }
        public void facoterComputes()
        {
            FactorHeight = (float)PictureBox1.Image.Height / PictureBox1.Height;
            FactorWidth = (float)PictureBox1.Image.Width / PictureBox1.Width;

        }
        public void pictureBox1_DragEnterLoad(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
            TimeCounter.Start();
        }
        public void pictureBox1_DragDropLoad(object sender, DragEventArgs e)
        {
            //string path = e.Data.GetData(DataFormats.FileDrop).ToString();
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            if (path == null) return;
            try
            {
                Image image = Image.FromFile(path);
                Bitmap bitmap = new Bitmap(image, PictureBox1.Width, PictureBox1.Height);
                ImageManager.oldBitmap = bitmap;
                PictureBox1.Image = bitmap;
                TimeElapsed = TimeCounter.Seconds.ToString();
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
        public void loadImage_Click(object sender, EventArgs e)
        {
            Bitmap bitmap;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TimeCounter.Start();
                Image image = (Bitmap)Image.FromFile(openFileDialog.FileName);
                //bitmap = new Bitmap(image, pictureBox1.Width, pictureBox1.Height);
                bitmap = new Bitmap(image);
                ImageManager.oldBitmap = bitmap.Clone() as Bitmap;
                PictureBox1.Image = bitmap;
                TimeCounter.Stop();
                TimeElapsed = TimeCounter.Seconds.ToString();
                Console.WriteLine(TimeElapsed);
            }
        }
        public void saveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog == null) return;
            saveFileDialog.Filter = "Jepg文件(*.jpg)|*.jpg|Png文件(*.png)|*.png";
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                TimeCounter.Start();
                if (saveFileDialog.FilterIndex == 1)
                {

                    PictureBox1.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                }
                else
                    PictureBox1.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                TimeCounter.Stop();
                TimeElapsed = TimeCounter.Seconds.ToString();
                /*Bitmap bit = new Bitmap(pic.width,pic.height);//有时候可能显示的和保存的不一样，可以直接用类似截图的copy保存
                 * Graphics g = Graphics.FromImage(bit);
                 * g.CompositingQuality = CompositingQuality.HighQuality;
                 * g.CopyFromSreen(this.Left,this.top,0, 0, new Size(panel2.Width, panel2.Height));//保存整个窗体为图片
                 * g.CopyFromScreen(picturePhoto.PointToScreen(Point.Empty), Point.Empty, picturePhoto.Size);//只保存某个控件（这里是panel游戏区）
                 * bit.Save(sa.FileName);//默认保存格式为PNG，保存成jpg格式质量不是很好
                 */
            }
        }
        public void sourcePic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oldbitmap = PictureBox1.Image.Clone() as Bitmap;
                PictureBox1.Image = ImageManager.oldBitmap;

            }
        }
        public void sourcePic_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox1.Image = oldbitmap;
        }
        public void pic1_MouseWheel(object sender, MouseEventArgs e)
        {

            // Point point = pictureBox1.
            int VX, VY;
            Point point = e.Location;

            Size t = PictureBox1.Size;

            VX = e.X * (e.Delta / (4 * t.Width));
            VY = e.Y * (e.Delta / (4 * t.Height));
            t.Width += e.Delta / 4;
            t.Height += e.Delta / 4;
            PictureBox1.Size = t;
            PictureBox1.Location = new Point(PictureBox1.Location.X + VX, PictureBox1.Location.Y + VY);


        }
        public void drawOut_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (IsDrawOut == false)
            {
                IsDrawOut = true;
                button.BackColor = Color.Black;
            }
            else
            {
                IsDrawOut = false;
                button.BackColor = Color.Transparent;
            }
        }
        public void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Point point = e.Location;
            MouseUpedPoint.X = Convert.ToInt32(point.X * FactorWidth);
            MouseUpedPoint.Y = Convert.ToInt32(point.Y * FactorHeight);
            MouseMoveUpPoint = point;

            //MouseUpedPoint = point;
            IsMouseUp = true;

            Console.WriteLine(MouseDownedPoint.Y - MouseUpedPoint.Y);//336
            //MouseUpedPoint.X = point.X;
            //MouseUpedPoint.Y =point.Y;

        }
        public void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = e.Location;
            //MouseDownedPoint = point;
            IsMouseUp = false;
            facoterComputes();
            MouseDownedPoint.X = Convert.ToInt32(point.X * FactorWidth);
            MouseDownedPoint.Y = Convert.ToInt32(point.Y * FactorHeight);
            MouseMoveDownPoint = point;
            
            //MouseDownedPoint.X = point.X;
            //MouseDownedPoint.Y = point.Y;

        }
        public void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            PictureBox box = sender as PictureBox;
            Point point = e.Location;
            int width, height;

            if (box == null) return;
            
            //width = point.X - MouseDownedPoint.X;
            //height = point.Y - MouseDownedPoint.Y;
            if (e.Button == MouseButtons.Left && IsDrawOut == true && IsMouseUp == false)
            {
                //point.X = Convert.ToInt32(point.X * FactorWidth);
                //point.Y = Convert.ToInt32(point.Y * FactorHeight);
                width = Convert.ToInt32(point.X * FactorWidth) - MouseDownedPoint.X;
                height = Convert.ToInt32(point.Y * FactorHeight) - MouseDownedPoint.Y;//这里可能需要判断一下这个width和height是否是大于0的，因为可能有多种画图方式
                Image image = PictureBox1.Image.Clone() as Image;
                PictureBox1.Image = ImageManager.DrawOutCropArea(image, MouseDownedPoint.X, MouseDownedPoint.Y, width, height);
                // Bitmap bitmap = box.Image.Clone() as Bitmap;
                //  box.DoDragDrop(bitmap, DragDropEffects.Copy | DragDropEffects.Link);

            }
            else if (e.Button == MouseButtons.Left && IsDrawOut == false && IsMouseUp == false)
            {
                width = point.X - MouseMoveDownPoint.X;
                height = point.Y - MouseMoveDownPoint.Y;
                PictureBox1.Location = new Point(PictureBox1.Location.X + width, PictureBox1.Location.Y + height);
            }
        }
        public void cropPic_Click(object sender, EventArgs e)
        {
            TimeCounter.Start();
            int width, height;
            width = MouseUpedPoint.X - MouseDownedPoint.X;
            height = MouseUpedPoint.Y - MouseDownedPoint.Y;
            PictureBox1.Image = ImageManager.Crop(MouseDownedPoint.X, MouseDownedPoint.Y, width, height);
            ImageManager.oldBitmap = PictureBox1.Image.Clone() as Bitmap;
            TimeCounter.Stop();
            TimeElapsed = TimeCounter.Seconds.ToString();

        }
        public void insertPic_Click(object sender, EventArgs e)
        {
            int width, height;
            Bitmap bitmap;
            OpenFileDialog insertDialog = new OpenFileDialog();
            if (insertDialog.ShowDialog() == DialogResult.OK)
            {
                TimeCounter.Start();
                width = MouseUpedPoint.X - MouseDownedPoint.X;
                height = MouseUpedPoint.Y - MouseDownedPoint.Y;
                Image image = (Bitmap)Image.FromFile(insertDialog.FileName);
                bitmap = new Bitmap(image, width, height);//这里调整好大小，insert函数插入的rect就是多大
                PictureBox1.Image = ImageManager.InsertImage(bitmap, MouseDownedPoint.X, MouseDownedPoint.Y);
                TimeCounter.Stop();
                TimeElapsed = TimeCounter.Seconds.ToString();
            }
        }
        public void waterPic_Click(object sender, EventArgs e)
        {
            TimeCounter.Start();
            PictureBox1.Image = ImageManager.MakeWaterMark(PictureBox1.Image);
            TimeCounter.Stop();
            TimeElapsed = TimeCounter.Seconds.ToString();
        }
    }
}
