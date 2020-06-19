using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using Image = System.Drawing.Image;
using Button = System.Windows.Forms.Button;

namespace ImageProcessingDemo1
{
    public partial class Image : Form
    {
        private Bitmap bitmap;
        public Bitmap oldbitmap;
        public bool IsDrawOut=false;
        public bool IsMouseUp;
        public bool isSave = false;
        bool IsCrop = false;
        bool IsInsert = false;
        int flag = 0;
        public float FactorWidth;
        public float FactorHeight;
        private PictureProcessing PictureProcessing=new PictureProcessing();
        ImageEffectManager imageManager;
        CtrlCreate CtrlCreate=new CtrlCreate();
        List<Bitmap> bitmaps=new List<Bitmap>();
        public Point MouseDownedPoint;
        public Point MouseUpedPoint;
        public Point MouseMoveDownPoint;
        public Point MouseMoveUpPoint;
        public Image()
        {
            InitializeComponent();            
            ConvertedImage.MouseWheel += ConvertedImage_MouseWheel;
            imageManager = new ImageEffectManager();
            Rectangle rect = Screen.GetWorkingArea(this);
            int width = rect.Width;
            int height = rect.Height;
            Size = new Size(width, height);
            Location = new Point((width - this.Width) / 2, (height - this.Height) / 2);  //用于固定启动程序是窗口的左上角的位置，
            ConvertedImage.Location = new Point(17, 76);
        }

        private void ConvertedImage_MouseWheel1(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void facoterComputes()
        {
            if (ConvertedImage.Image != null)
            {
                FactorHeight = (float)ConvertedImage.Image.Height / ConvertedImage.Height;
                FactorWidth = (float)ConvertedImage.Image.Width / ConvertedImage.Width;
            }
        }
        private void SourceBtn_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
             
        private void CerticalChangeBtn_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.VerticalChange(bitmap);
            ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
            bitmaps.Add(bitmap);
        }
        private void SourceBtn_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oldbitmap = ConvertedImage.Image.Clone() as Bitmap;
                ConvertedImage.Image = imageManager.oldBitmap;

            }
        }

        private void SourceBtn_MouseUp(object sender, MouseEventArgs e)
        {
            ConvertedImage.Image = oldbitmap;
        }

        private void ConvertedImage_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = e.Location;
            //MouseDownedPoint = point;
            IsMouseUp = false;
            facoterComputes();
            MouseDownedPoint.X = Convert.ToInt32(point.X * FactorWidth);
            MouseDownedPoint.Y = Convert.ToInt32(point.Y * FactorHeight);
            MouseMoveDownPoint = point;
            if (IsCrop || IsInsert)
            {
                CropBtn.Visible = false;

            }

        }

        private void ConvertedImage_MouseUp(object sender, MouseEventArgs e)
        {
            Point point = e.Location;
            MouseUpedPoint.X = Convert.ToInt32(point.X * FactorWidth);
            MouseUpedPoint.Y = Convert.ToInt32(point.Y * FactorHeight);
            MouseMoveUpPoint = point;
            if (IsCrop || IsInsert)
            {
                CropBtn.Visible = true;
                CropBtn.Location = MouseMoveUpPoint;

            }
            //MouseUpedPoint = point;
            IsMouseUp = true;

            Console.WriteLine(MouseDownedPoint.Y - MouseUpedPoint.Y);//336
            //MouseUpedPoint.X = point.X;
            //MouseUpedPoint.Y =point.Y;
        }
        private void ConvertedImage_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox box = sender as PictureBox;
            Point point = e.Location;
            int width, height;

            if (box == null) return;

            //width = point.X - MouseDownedPoint.X;
            //height = point.Y - MouseDownedPoint.Y;
            if (e.Button == MouseButtons.Left && (IsCrop == true || IsInsert == true )&& IsMouseUp == false)
            {
                //point.X = Convert.ToInt32(point.X * FactorWidth);
                //point.Y = Convert.ToInt32(point.Y * FactorHeight);
                width = Convert.ToInt32(point.X * FactorWidth) - MouseDownedPoint.X;
                height = Convert.ToInt32(point.Y * FactorHeight) - MouseDownedPoint.Y;//这里可能需要判断一下这个width和height是否是大于0的，因为可能有多种画图方式
                System.Drawing.Image image = bitmap;
                ConvertedImage.Image = imageManager.DrawOutCropArea(image, MouseDownedPoint.X, MouseDownedPoint.Y, width, height);
                // Bitmap bitmap = box.Image.Clone() as Bitmap;
                //  box.DoDragDrop(bitmap, DragDropEffects.Copy | DragDropEffects.Link);

            }
            else if (e.Button == MouseButtons.Left && IsCrop == false && IsInsert == false && IsMouseUp == false)
            {
                width = point.X - MouseMoveDownPoint.X;
                height = point.Y - MouseMoveDownPoint.Y;
                ConvertedImage.Location = new Point(ConvertedImage.Location.X + width, ConvertedImage.Location.Y + height);
            }
        }

        private void ConvertedImage_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            if (path == null) return;
            try
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(path);
                Bitmap bitmap = new Bitmap(image, ConvertedImage.Width, ConvertedImage.Height);
                imageManager.oldBitmap = bitmap;
                ConvertedImage.Image = bitmap;
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }

        private void ConvertedImage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        public void ConvertedImage_MouseWheel(object sender, MouseEventArgs e)
        {
            // Point point = pictureBox1.
            int VX, VY;
            Point point = e.Location;

            Size t =ConvertedImage.Size;

            VX = e.X * (e.Delta / (4 * t.Width));
            VY = e.Y * (e.Delta / (4 * t.Height));
            t.Width += e.Delta / 4;
            t.Height += e.Delta / 4;
            ConvertedImage.Size = t;
            ConvertedImage.Location = new Point(ConvertedImage.Location.X + VX, ConvertedImage.Location.Y + VY);
        }
        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSave&&ConvertedImage.Image!=null)
            {
                if (MessageBox.Show( "是否放弃当前文件", "当前文件未保存", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bitmap = PictureProcessing.OpenFile(openImageDialog.ShowDialog() == DialogResult.OK, openImageDialog.FileName);
                    imageManager.oldBitmap = bitmap.Clone() as Bitmap;
                    ConvertedImage.Image = bitmap;
                    bitmaps.Clear();
                    bitmaps.Add(imageManager.oldBitmap);
                }
            }
            else
            {
                
                if (openImageDialog.ShowDialog() == DialogResult.OK) {
                   bitmap = PictureProcessing.OpenFile(true,openImageDialog.FileName);
                    imageManager.oldBitmap = bitmap.Clone() as Bitmap;
                    ConvertedImage.Image = bitmap;
                    bitmaps.Clear();
                    bitmaps.Add(imageManager.oldBitmap);
                    编辑EToolStripMenuItem.Enabled = true;
                    工具TToolStripMenuItem.Enabled = true;
                    插入文本框ToolStripMenuItem.Enabled = true;
                    SourceBtn.Visible = true;
                }
                //Bitmap bitmap = PictureProcessing.OpenFile(openImageDialog.ShowDialog() == DialogResult.OK, openImageDialog.FileName);
                //imageManager.oldBitmap = bitmap.Clone() as Bitmap;
                //ConvertedImage.Image = bitmap;
                //bitmaps.Clear();
                //bitmaps.Add(imageManager.oldBitmap);
                //编辑EToolStripMenuItem.Enabled = true;
                //工具TToolStripMenuItem.Enabled = true;
                //插入文本框ToolStripMenuItem.Enabled= true ;
                //SourceBtn.Visible = true;
            }

        }

        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap Bit = PictureProcessing.GetBit(ConvertedImage.Size, ConvertedImage.PointToScreen(new Point(0, 0)));
            PictureProcessing.SaveFile(saveImageDialog.ShowDialog() == DialogResult.OK, saveImageDialog.FileName,Bit, out isSave);
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void New()
        {
            Bitmap bitmap = PictureProcessing.OpenFile(false, "");
            imageManager.oldBitmap = bitmap.Clone() as Bitmap;
            ConvertedImage.Image = bitmap;
            bitmaps.Clear();
            bitmaps.Add(imageManager.oldBitmap);
            编辑EToolStripMenuItem.Enabled = true;
            工具TToolStripMenuItem.Enabled = true;
            插入文本框ToolStripMenuItem.Enabled = true;
            SourceBtn.Visible = true;
        }
        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSave)
                New();
            else if (!isSave && ConvertedImage.Image != null)
            {
                if (MessageBox.Show("是否保存文件后再新建", "当前文件未保存", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    New();
                else
                    New();
            }
            else New();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (!isSave&&ConvertedImage.Image!=null)
            {
                if (MessageBox.Show( "是否保存文件后再退出", "当前文件未保存", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Bitmap Bit = PictureProcessing.GetBit(ConvertedImage.Size, ConvertedImage.PointToScreen(new Point(0, 0)));
                    PictureProcessing.SaveFile(saveImageDialog.ShowDialog() == DialogResult.OK, saveImageDialog.FileName, Bit, out isSave);
                }
                else
                {
                    isSave = true;         
                }                    
            }
        }

        private void 撤消UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bitmaps.Count != 1 && bitmaps.Count >= 2)
            {
                ConvertedImage.Image = bitmaps[bitmaps.Count - 2];
                bitmaps.RemoveAt(bitmaps.Count - 1);
                bitmap = ConvertedImage.Image.Clone() as Bitmap;
            }
            else
            {
                ConvertedImage.Image = bitmaps[0];
                bitmap = ConvertedImage.Image.Clone() as Bitmap;
            }
            if (IsCrop == true || IsInsert == true)
            {
                IsCrop = false;
                IsInsert = false;
                CropBtn.Visible = false;
                if (bitmaps.Count != 1 && bitmaps.Count >= 2)
                {
                    ConvertedImage.Image = bitmaps[bitmaps.Count - 2];
                }
                else
                    ConvertedImage.Image = bitmaps[0];
                //imageManager.DrawOutCropArea(PictureBox1, PictureBox1.Location.X, PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height);

                //这里需要把原图片还原一下,这里我是简单的处理了一下,最好是用还原操作
            }
        }

        private void 垂直变换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.VerticalChange(bitmap);
            ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
            bitmaps.Add(bitmap);
        }

        private void 水平变换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.LevelChange(bitmap);
            ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
            bitmaps.Add(bitmap);
        }

        private void 浮雕效果ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.Relife(bitmap);
            ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
            bitmaps.Add(bitmap);
        }

        private void 取反色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.DeColor(bitmap);
            ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
            bitmaps.Add(bitmap);
        }

        private void 雾化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.AtomizationChange(bitmap);
            ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
            bitmaps.Add(bitmap);
        }

        private void 锐化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.SharpenChange(bitmap);
            ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
            bitmaps.Add(bitmap);
        }

        private void 模糊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureProcessing.BlurChange(bitmap);
            ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
            bitmaps.Add(bitmap);
        }

        private void 去色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.ReverseColor(bitmap);
            ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
            bitmaps.Add(bitmap);
        }

        private void 添加暗角ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoefficientScrollBar.Visible = true;ChangeBtn.Visible = true;
            flag = 1;
        }

        private void 降低亮度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoefficientScrollBar.Visible = true; ChangeBtn.Visible = true;
            flag = 2;
        }

        private void 扩散效果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoefficientScrollBar.Visible = true; ChangeBtn.Visible = true;
            flag = 3;
        }

        private void 马赛克ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CoefficientScrollBar.Visible = true; ChangeBtn.Visible = true;
            flag = 4;
        }

        private void 添加水印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmap = (Bitmap)imageManager.MakeWaterMark(ConvertedImage.Image);
            ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
            bitmaps.Add(bitmap);
        }

        private void 插入文本框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBoxEx rtb = CtrlCreate.CreateRtb();
            FlowLayoutPanel panel = CtrlCreate.CreatePanel(rtb);
            this.Controls.Add(rtb);
            rtb.BringToFront();
            this.Controls.Add(panel);
        }

        private void 剪裁图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int width, height;

            if (IsCrop == false)//IsCrop判断是否按下剪裁，第一次按下时，选一个默认的区域，point，这样无论是否划区域都不为空
            {
                IsCrop = true;
                IsInsert = false;
            }

            width = Convert.ToInt32(ConvertedImage.Width / 4);
            height = Convert.ToInt32(ConvertedImage.Height / 4);
            MouseDownedPoint = new Point(width, height);
            MouseUpedPoint = new Point(width * 3, height * 3);
            bitmap = (Bitmap)ConvertedImage.Image;
            ConvertedImage.Image = imageManager.DrawOutCropArea(bitmap, width, height, width * 2, height * 2).Clone() as Bitmap;
            //ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
            //bitmaps.Add(bitmap);
            CropBtn.Location = MouseUpedPoint;
            CropBtn.Visible = true;
            CropBtn.Text = "确认剪裁";

            /*
            else
            {
                IsCrop = false;
                CropBtn.Visible = false;
                width = MouseUpedPoint.X - MouseDownedPoint.X;
                height = MouseUpedPoint.Y - MouseDownedPoint.Y;
                bitmap = imageManager.Crop(ConvertedImage.Image,MouseDownedPoint.X, MouseDownedPoint.Y, width, height).Clone() as Bitmap;
                ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
                bitmaps.Add(bitmap);
              // imageManager.oldBitmap = ConvertedImage.Image.Clone() as Bitmap;
            }
            */
        }

        private void 插入图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int width, height;

            if (IsInsert == false)
            {
                IsInsert = true;
                IsCrop = false;

            }
            width = Convert.ToInt32(ConvertedImage.Width / 4);
            height = Convert.ToInt32(ConvertedImage.Height / 4);
            MouseDownedPoint = new Point(width, height);
            MouseUpedPoint = new Point(width * 3, height * 3);
            bitmap = (Bitmap)ConvertedImage.Image;
            ConvertedImage.Image = imageManager.DrawOutCropArea(bitmap, width, height, width * 2, height * 2);
            CropBtn.Location = MouseUpedPoint;
            CropBtn.Visible = true;
            CropBtn.Text = "确认插入";

            /*
            else
            {

                if (insertDialog.ShowDialog() == DialogResult.OK)
                {
                    IsInsert = false;
                    CropBtn.Visible = false;
                    width = MouseUpedPoint.X - MouseDownedPoint.X;
                    height = MouseUpedPoint.Y - MouseDownedPoint.Y;
                    System.Drawing.Image image = (Bitmap)System.Drawing.Image.FromFile(insertDialog.FileName);
                    bitmap = new Bitmap(image, width, height);//这里调整好大小，insert函数插入的rect就是多大
                    bitmap = imageManager.InsertImage(ConvertedImage.Image, bitmap, MouseDownedPoint.X, MouseDownedPoint.Y).Clone() as Bitmap;
                    ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
                    bitmaps.Add(bitmap);
                }
            }
            */
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            Task a;
            switch (flag)
            {
                case 1:
                    a= new Task(new Action(() => {
                        bitmap = PictureProcessing.DarkCorner(bitmap, CoefficientScrollBar.Value);
                    }));
                    a.Start();
                    a.Wait();
                    //bitmap = PictureProcessing.DarkCorner(bitmap, CoefficientScrollBar.Value);
                    break;
                case 2:
                    a = new Task(new Action(() => {
                        PictureProcessing.BrightNess(bitmap, CoefficientScrollBar.Value);
                    }));
                    //PictureProcessing.BrightNess(bitmap, CoefficientScrollBar.Value);
                    a.Start();
                    a.Wait();
                    break;
                case 3:
                    a = new Task(new Action(() => {
                        bitmap = PictureProcessing.Spread(bitmap);
                    }));
                    // bitmap = PictureProcessing.Spread(bitmap);
                    a.Start();
                    a.Wait();
                    break;
                case 4:
                    a = new Task(new Action(() => {
                        bitmap = PictureProcessing.Mosic(bitmap, CoefficientScrollBar.Value);
                    }));
                    //bitmap = PictureProcessing.Mosic(bitmap, CoefficientScrollBar.Value);
                    a.Start();
                    a.Wait();
                    break;
                default:
                    flag = 0;
                    break;
            }
            if (flag != 0)
            {
                Task b = new Task(new Action(() => {
                    ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
                    bitmaps.Add(bitmap);
                }));
                b.Start();
                b.Wait();
                //ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
               
            }
        }

        private void CropBtn_Click(object sender, EventArgs e)
        {
            int width, height;
            if (IsCrop)
            {
                IsCrop = false;
                CropBtn.Visible = false;
                width = MouseUpedPoint.X - MouseDownedPoint.X;
                height = MouseUpedPoint.Y - MouseDownedPoint.Y;
                bitmap = imageManager.Crop(ConvertedImage.Image, MouseDownedPoint.X, MouseDownedPoint.Y, width, height).Clone() as Bitmap;
                ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
                bitmaps.Add(bitmap);
                // imageManager.oldBitmap = ConvertedImage.Image.Clone() as Bitmap;

            }
            else if (IsInsert)
            {
                OpenFileDialog insertDialog = new OpenFileDialog();

                if (insertDialog.ShowDialog() == DialogResult.OK)
                {
                    IsInsert = false;
                    CropBtn.Visible = false;
                    width = MouseUpedPoint.X - MouseDownedPoint.X;
                    height = MouseUpedPoint.Y - MouseDownedPoint.Y;
                    System.Drawing.Image image = (Bitmap)System.Drawing.Image.FromFile(insertDialog.FileName);
                    bitmap = new Bitmap(image, width, height);//这里调整好大小，insert函数插入的rect就是多大
                    bitmap = imageManager.InsertImage(bitmaps[bitmaps.Count-1], bitmap, MouseDownedPoint.X, MouseDownedPoint.Y).Clone() as Bitmap;
                    ConvertedImage.Image = bitmap.Clone() as System.Drawing.Image;
                    bitmaps.Add(bitmap);
                }

            }
            else return;
        }
    }

}
