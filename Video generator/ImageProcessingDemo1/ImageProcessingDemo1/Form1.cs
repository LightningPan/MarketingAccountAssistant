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

namespace ImageProcessingDemo1
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        private Bitmap newbitmap;
        private PictureProcessing PictureProcessing=new PictureProcessing();
        ImageEffectManager imageManager;
        ImageEventHandlers imageHandlers;
        CtrlCreate CtrlCreate=new CtrlCreate();
        List<Bitmap> bitmaps=new List<Bitmap>();
        public Form1()
        {
            InitializeComponent();
            ConvertedImage.SizeMode = PictureBoxSizeMode.StretchImage; //这里用来设置如何处理图片

            imageHandlers = new ImageEventHandlers();
            imageManager = imageHandlers.ImageManager;//将handler中的manager赋值给form中的manager
            imageHandlers.PictureBox1 = ConvertedImage;//将form中的picturebox赋值给handler中picturebox，不然为空
            imageHandlers.CropBtn = CropBtn;
            imageHandlers.DrowoutBtn = DrowoutBtn;
            imageHandlers.InsertBtn = InsertBtn;
            imageHandlers.OpenImageBtn = OpenImageBtn;
            imageHandlers.SourceBtn = SourceBtn;
            imageHandlers.WaterBtn = WaterBtn;
            imageHandlers.TimeLabel = label1;
            imageHandlers.TimeLabel.DataBindings.Add("Text", imageHandlers, "TimeElapsed");
            //imageHandlers.TimeLabel.Text = "";
            imageHandlers.initialize();
            //各种事件
            imageHandlers.PictureBox1.AllowDrop = true;
            //pictureBox2.AllowDrop = true;
            //图片事件
            //MouseWheel += new MouseEventHandler();
            //按钮事件
            OpenImageBtn.Click += GetBitmap;

        }

        private void SourceBtn_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GetBitmap(object sender, EventArgs e)
        { 
            bitmap = imageManager.oldBitmap;
            bitmaps.Add(bitmap);
        }
        /*private void OpenImageBtn_Click(object sender, EventArgs e)
        {
            if(openImageDialog.ShowDialog()==DialogResult.OK)
            {
                string path = openImageDialog.FileName;
                bitmap = (Bitmap)Image.FromFile(path);
                ConvertedImage.Image = bitmap.Clone() as Image;
            }
        }*/

        private void SaveImageBtn_Click(object sender, EventArgs e)
        {
            bool isSave = true;
            if(saveImageDialog.ShowDialog()==DialogResult.OK)
            {
                string fileName = saveImageDialog.FileName.ToString();
                if(fileName!=""&&fileName!=null)
                {
                    string fileExtName = fileName.Substring(fileName.LastIndexOf(".") + 1).ToString();
                    System.Drawing.Imaging.ImageFormat imageFormat = null;
                    if(fileExtName !="")
                    {
                        switch (fileExtName) 
                        {
                            case "jpg":
                                imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                            case"bmp":
                                imageFormat = System.Drawing.Imaging.ImageFormat.Bmp;
                                break;
                            case "gif":
                                imageFormat = System.Drawing.Imaging.ImageFormat.Gif;
                                break;
                            default:
                                MessageBox.Show("只能存取为：jpg、bmp、gif格式");
                                isSave = false;
                                break;
                        }
                    }
                    if(imageFormat==null)
                    {
                        imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                    }
                    if(isSave)
                    {
                        try
                        {
                            Double Factor = 1.5;
                            int SizeX = Convert.ToInt32(ConvertedImage.Size.Width * Factor);
                            int SizeY = Convert.ToInt32(ConvertedImage.Size.Height * Factor);
                            Bitmap bit = new Bitmap(SizeX, SizeY);
                            Point p = ConvertedImage.PointToScreen(new Point(0, 0));
                            int x = Convert.ToInt32(p.X * Factor);
                            int y = Convert.ToInt32(p.Y * Factor);
                            Graphics g = Graphics.FromImage(bit);
                            g.CopyFromScreen(x, y, 0, 0, new Size(SizeX, SizeY));
                            g.CompositingQuality = CompositingQuality.HighQuality;
                            bit.Save(fileName, imageFormat);
                            MessageBox.Show("保存成功！");
                        }
                        catch
                        {
                            MessageBox.Show("保存失败！");
                        }
                    }
                }
            }
        }

        private void DarkCornerBtn_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.DarkCorner(bitmap,CoefficientScrollBar.Value);
            ConvertedImage.Image = bitmap.Clone() as Image;
            bitmaps.Add(bitmap);
        }

        private void BrightnessBtn_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.BrightNess(bitmap, CoefficientScrollBar.Value);
            ConvertedImage.Image = bitmap.Clone() as Image;
            bitmaps.Add(bitmap);
        }

        private void DeColorBtn_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.DeColor(bitmap);
            ConvertedImage.Image = bitmap.Clone() as Image;
            bitmaps.Add(bitmap);
        }

        private void RelifeBtn_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.Relife(bitmap);
            ConvertedImage.Image = bitmap.Clone() as Image;
            bitmaps.Add(bitmap);
        }

        private void MosaicBtn_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.Mosic(bitmap,CoefficientScrollBar.Value);
            ConvertedImage.Image = bitmap.Clone() as Image;
            bitmaps.Add(bitmap);
        }

        private void SpreadBtn_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.Spread(bitmap);
            ConvertedImage.Image = bitmap.Clone() as Image;
            bitmaps.Add(bitmap);
        }
        private void ReverseColorBtn_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.ReverseColor(bitmap);
            ConvertedImage.Image = bitmap.Clone() as Image;
            bitmaps.Add(bitmap);
        }
        private void AtomizationChangeBtn_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.AtomizationChange(bitmap);
            ConvertedImage.Image = bitmap.Clone() as Image;
            bitmaps.Add(bitmap);

        }

        private void SharpenChangeBtn_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.SharpenChange(bitmap);
            ConvertedImage.Image = bitmap.Clone() as Image;
            bitmaps.Add(bitmap);
        }
        private void BlurChangeBtn_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.BlurChange(bitmap);
            ConvertedImage.Image = bitmap.Clone() as Image;
            bitmaps.Add(bitmap);
        }

        private void LevelChangeBtn_Click(object sender, EventArgs e)
        { 
            bitmap = PictureProcessing.LevelChange(bitmap);
            ConvertedImage.Image = bitmap.Clone() as Image;
            bitmaps.Add(bitmap);
        }

        private void CerticalChangeBtn_Click(object sender, EventArgs e)
        {
            bitmap = PictureProcessing.VerticalChange(bitmap);
            ConvertedImage.Image = bitmap.Clone() as Image;
            bitmaps.Add(bitmap);
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RevokeBtn_Click(object sender, EventArgs e)
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
        }

        private void AddTextBtn_Click(object sender, EventArgs e)
        {
            RichTextBoxEx rtb = CtrlCreate.CreateRtb();
            FlowLayoutPanel panel = CtrlCreate.CreatePanel(rtb);
            this.Controls.Add(rtb);
            this.Controls.Add(panel);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
    }