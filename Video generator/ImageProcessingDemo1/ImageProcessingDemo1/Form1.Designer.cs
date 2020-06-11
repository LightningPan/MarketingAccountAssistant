namespace ImageProcessingDemo1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ConvertedLabel = new System.Windows.Forms.Label();
            this.OpenImageBtn = new System.Windows.Forms.Button();
            this.SaveImageBtn = new System.Windows.Forms.Button();
            this.DarkCornerBtn = new System.Windows.Forms.Button();
            this.FunctionLabe = new System.Windows.Forms.Label();
            this.BrightnessBtn = new System.Windows.Forms.Button();
            this.DeColorBtn = new System.Windows.Forms.Button();
            this.RelifeBtn = new System.Windows.Forms.Button();
            this.MosaicBtn = new System.Windows.Forms.Button();
            this.SpreadBtn = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.CoefficientScrollBar = new System.Windows.Forms.HScrollBar();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ReverseColorBtn = new System.Windows.Forms.Button();
            this.AtomizationChangeBtn = new System.Windows.Forms.Button();
            this.SharpenChangeBtn = new System.Windows.Forms.Button();
            this.BlurChangeBtn = new System.Windows.Forms.Button();
            this.LevelChangeBtn = new System.Windows.Forms.Button();
            this.CerticalChangeBtn = new System.Windows.Forms.Button();
            this.WaterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.CropBtn = new System.Windows.Forms.Button();
            this.DrowoutBtn = new System.Windows.Forms.Button();
            this.ConvertedImage = new System.Windows.Forms.PictureBox();
            this.RevokeBtn = new System.Windows.Forms.Button();
            this.SourceBtn = new System.Windows.Forms.Button();
            this.AddTextBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ConvertedLabel
            // 
            this.ConvertedLabel.AutoSize = true;
            this.ConvertedLabel.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConvertedLabel.Location = new System.Drawing.Point(454, 50);
            this.ConvertedLabel.Name = "ConvertedLabel";
            this.ConvertedLabel.Size = new System.Drawing.Size(110, 24);
            this.ConvertedLabel.TabIndex = 3;
            this.ConvertedLabel.Text = "修改图像";
            // 
            // OpenImageBtn
            // 
            this.OpenImageBtn.Location = new System.Drawing.Point(820, 124);
            this.OpenImageBtn.Name = "OpenImageBtn";
            this.OpenImageBtn.Size = new System.Drawing.Size(193, 78);
            this.OpenImageBtn.TabIndex = 4;
            this.OpenImageBtn.Text = "打开图片";
            this.OpenImageBtn.UseVisualStyleBackColor = true;
            // 
            // SaveImageBtn
            // 
            this.SaveImageBtn.Location = new System.Drawing.Point(820, 210);
            this.SaveImageBtn.Name = "SaveImageBtn";
            this.SaveImageBtn.Size = new System.Drawing.Size(193, 78);
            this.SaveImageBtn.TabIndex = 5;
            this.SaveImageBtn.Text = "保存图片";
            this.SaveImageBtn.UseVisualStyleBackColor = true;
            this.SaveImageBtn.Click += new System.EventHandler(this.SaveImageBtn_Click);
            // 
            // DarkCornerBtn
            // 
            this.DarkCornerBtn.Location = new System.Drawing.Point(54, 94);
            this.DarkCornerBtn.Name = "DarkCornerBtn";
            this.DarkCornerBtn.Size = new System.Drawing.Size(104, 34);
            this.DarkCornerBtn.TabIndex = 6;
            this.DarkCornerBtn.Text = "添加暗角";
            this.DarkCornerBtn.UseVisualStyleBackColor = true;
            this.DarkCornerBtn.Click += new System.EventHandler(this.DarkCornerBtn_Click);
            // 
            // FunctionLabe
            // 
            this.FunctionLabe.AutoSize = true;
            this.FunctionLabe.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FunctionLabe.Location = new System.Drawing.Point(50, 50);
            this.FunctionLabe.Name = "FunctionLabe";
            this.FunctionLabe.Size = new System.Drawing.Size(110, 24);
            this.FunctionLabe.TabIndex = 7;
            this.FunctionLabe.Text = "修改效果";
            // 
            // BrightnessBtn
            // 
            this.BrightnessBtn.Location = new System.Drawing.Point(54, 144);
            this.BrightnessBtn.Name = "BrightnessBtn";
            this.BrightnessBtn.Size = new System.Drawing.Size(104, 34);
            this.BrightnessBtn.TabIndex = 8;
            this.BrightnessBtn.Text = "降低亮度";
            this.BrightnessBtn.UseVisualStyleBackColor = true;
            this.BrightnessBtn.Click += new System.EventHandler(this.BrightnessBtn_Click);
            // 
            // DeColorBtn
            // 
            this.DeColorBtn.Location = new System.Drawing.Point(54, 195);
            this.DeColorBtn.Name = "DeColorBtn";
            this.DeColorBtn.Size = new System.Drawing.Size(104, 34);
            this.DeColorBtn.TabIndex = 9;
            this.DeColorBtn.Text = "去色";
            this.DeColorBtn.UseVisualStyleBackColor = true;
            this.DeColorBtn.Click += new System.EventHandler(this.DeColorBtn_Click);
            // 
            // RelifeBtn
            // 
            this.RelifeBtn.Location = new System.Drawing.Point(54, 246);
            this.RelifeBtn.Name = "RelifeBtn";
            this.RelifeBtn.Size = new System.Drawing.Size(104, 34);
            this.RelifeBtn.TabIndex = 10;
            this.RelifeBtn.Text = "浮雕效果";
            this.RelifeBtn.UseVisualStyleBackColor = true;
            this.RelifeBtn.Click += new System.EventHandler(this.RelifeBtn_Click);
            // 
            // MosaicBtn
            // 
            this.MosaicBtn.Location = new System.Drawing.Point(54, 298);
            this.MosaicBtn.Name = "MosaicBtn";
            this.MosaicBtn.Size = new System.Drawing.Size(104, 34);
            this.MosaicBtn.TabIndex = 11;
            this.MosaicBtn.Text = "马赛克";
            this.MosaicBtn.UseVisualStyleBackColor = true;
            this.MosaicBtn.Click += new System.EventHandler(this.MosaicBtn_Click);
            // 
            // SpreadBtn
            // 
            this.SpreadBtn.Location = new System.Drawing.Point(54, 351);
            this.SpreadBtn.Name = "SpreadBtn";
            this.SpreadBtn.Size = new System.Drawing.Size(104, 34);
            this.SpreadBtn.TabIndex = 12;
            this.SpreadBtn.Text = "扩散效果";
            this.SpreadBtn.UseVisualStyleBackColor = true;
            this.SpreadBtn.Click += new System.EventHandler(this.SpreadBtn_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.DefaultExt = "jpg";
            this.openImageDialog.Filter = "\"图片文件(jpg,jpeg,bmp,gif,ico,pen,tif)|*.jpg;*.jpeg;*.bmp;*.gif;*.ico;*.png;*.tif;*." +
    "wmf\"";
            this.openImageDialog.Title = "“打开图片”";
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.Filter = "\"图片文件(jpg,jpeg,bmp,gif,ico,pen,tif)|*.jpg;*.jpeg;*.bmp;*.gif;*.ico;*.png;*.tif;*." +
    "wmf\"";
            this.saveImageDialog.Title = "\"保存图片\"";
            // 
            // CoefficientScrollBar
            // 
            this.CoefficientScrollBar.Location = new System.Drawing.Point(54, 418);
            this.CoefficientScrollBar.Name = "CoefficientScrollBar";
            this.CoefficientScrollBar.Size = new System.Drawing.Size(244, 78);
            this.CoefficientScrollBar.TabIndex = 13;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(1040, 124);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(94, 250);
            this.ExitBtn.TabIndex = 14;
            this.ExitBtn.Text = "退出";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ReverseColorBtn
            // 
            this.ReverseColorBtn.Location = new System.Drawing.Point(195, 94);
            this.ReverseColorBtn.Name = "ReverseColorBtn";
            this.ReverseColorBtn.Size = new System.Drawing.Size(104, 34);
            this.ReverseColorBtn.TabIndex = 15;
            this.ReverseColorBtn.Text = "取反色";
            this.ReverseColorBtn.UseVisualStyleBackColor = true;
            this.ReverseColorBtn.Click += new System.EventHandler(this.ReverseColorBtn_Click);
            // 
            // AtomizationChangeBtn
            // 
            this.AtomizationChangeBtn.Location = new System.Drawing.Point(195, 144);
            this.AtomizationChangeBtn.Name = "AtomizationChangeBtn";
            this.AtomizationChangeBtn.Size = new System.Drawing.Size(104, 34);
            this.AtomizationChangeBtn.TabIndex = 16;
            this.AtomizationChangeBtn.Text = "雾化";
            this.AtomizationChangeBtn.UseVisualStyleBackColor = true;
            this.AtomizationChangeBtn.Click += new System.EventHandler(this.AtomizationChangeBtn_Click);
            // 
            // SharpenChangeBtn
            // 
            this.SharpenChangeBtn.Location = new System.Drawing.Point(195, 195);
            this.SharpenChangeBtn.Name = "SharpenChangeBtn";
            this.SharpenChangeBtn.Size = new System.Drawing.Size(104, 34);
            this.SharpenChangeBtn.TabIndex = 17;
            this.SharpenChangeBtn.Text = "锐化";
            this.SharpenChangeBtn.UseVisualStyleBackColor = true;
            this.SharpenChangeBtn.Click += new System.EventHandler(this.SharpenChangeBtn_Click);
            // 
            // BlurChangeBtn
            // 
            this.BlurChangeBtn.Location = new System.Drawing.Point(195, 246);
            this.BlurChangeBtn.Name = "BlurChangeBtn";
            this.BlurChangeBtn.Size = new System.Drawing.Size(104, 34);
            this.BlurChangeBtn.TabIndex = 18;
            this.BlurChangeBtn.Text = "模糊";
            this.BlurChangeBtn.UseVisualStyleBackColor = true;
            this.BlurChangeBtn.Click += new System.EventHandler(this.BlurChangeBtn_Click);
            // 
            // LevelChangeBtn
            // 
            this.LevelChangeBtn.Location = new System.Drawing.Point(195, 298);
            this.LevelChangeBtn.Name = "LevelChangeBtn";
            this.LevelChangeBtn.Size = new System.Drawing.Size(104, 34);
            this.LevelChangeBtn.TabIndex = 19;
            this.LevelChangeBtn.Text = "水平变换";
            this.LevelChangeBtn.UseVisualStyleBackColor = true;
            this.LevelChangeBtn.Click += new System.EventHandler(this.LevelChangeBtn_Click);
            // 
            // CerticalChangeBtn
            // 
            this.CerticalChangeBtn.Location = new System.Drawing.Point(195, 351);
            this.CerticalChangeBtn.Name = "CerticalChangeBtn";
            this.CerticalChangeBtn.Size = new System.Drawing.Size(104, 34);
            this.CerticalChangeBtn.TabIndex = 20;
            this.CerticalChangeBtn.Text = "垂直变换";
            this.CerticalChangeBtn.UseVisualStyleBackColor = true;
            this.CerticalChangeBtn.Click += new System.EventHandler(this.CerticalChangeBtn_Click);
            // 
            // WaterBtn
            // 
            this.WaterBtn.Location = new System.Drawing.Point(368, 418);
            this.WaterBtn.Name = "WaterBtn";
            this.WaterBtn.Size = new System.Drawing.Size(104, 34);
            this.WaterBtn.TabIndex = 22;
            this.WaterBtn.Text = "添加水印";
            this.WaterBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(851, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "运行时间";
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(521, 469);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(104, 34);
            this.InsertBtn.TabIndex = 24;
            this.InsertBtn.Text = "插入图片";
            this.InsertBtn.UseVisualStyleBackColor = true;
            // 
            // CropBtn
            // 
            this.CropBtn.Location = new System.Drawing.Point(368, 469);
            this.CropBtn.Name = "CropBtn";
            this.CropBtn.Size = new System.Drawing.Size(104, 34);
            this.CropBtn.TabIndex = 25;
            this.CropBtn.Text = "剪裁图片";
            this.CropBtn.UseVisualStyleBackColor = true;
            // 
            // DrowoutBtn
            // 
            this.DrowoutBtn.Location = new System.Drawing.Point(521, 418);
            this.DrowoutBtn.Name = "DrowoutBtn";
            this.DrowoutBtn.Size = new System.Drawing.Size(104, 34);
            this.DrowoutBtn.TabIndex = 26;
            this.DrowoutBtn.Text = "选择区域";
            this.DrowoutBtn.UseVisualStyleBackColor = true;
            // 
            // ConvertedImage
            // 
            this.ConvertedImage.Location = new System.Drawing.Point(368, 124);
            this.ConvertedImage.Name = "ConvertedImage";
            this.ConvertedImage.Size = new System.Drawing.Size(407, 250);
            this.ConvertedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ConvertedImage.TabIndex = 27;
            this.ConvertedImage.TabStop = false;
            // 
            // RevokeBtn
            // 
            this.RevokeBtn.Location = new System.Drawing.Point(820, 298);
            this.RevokeBtn.Name = "RevokeBtn";
            this.RevokeBtn.Size = new System.Drawing.Size(193, 78);
            this.RevokeBtn.TabIndex = 28;
            this.RevokeBtn.Text = "撤销";
            this.RevokeBtn.UseVisualStyleBackColor = true;
            this.RevokeBtn.Click += new System.EventHandler(this.RevokeBtn_Click);
            // 
            // SourceBtn
            // 
            this.SourceBtn.Location = new System.Drawing.Point(671, 418);
            this.SourceBtn.Name = "SourceBtn";
            this.SourceBtn.Size = new System.Drawing.Size(104, 34);
            this.SourceBtn.TabIndex = 29;
            this.SourceBtn.Text = "查看原图";
            this.SourceBtn.UseVisualStyleBackColor = true;
            // 
            // AddTextBtn
            // 
            this.AddTextBtn.Location = new System.Drawing.Point(671, 469);
            this.AddTextBtn.Name = "AddTextBtn";
            this.AddTextBtn.Size = new System.Drawing.Size(104, 34);
            this.AddTextBtn.TabIndex = 30;
            this.AddTextBtn.Text = "添加文字";
            this.AddTextBtn.UseVisualStyleBackColor = true;
            this.AddTextBtn.Click += new System.EventHandler(this.AddTextBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 515);
            this.Controls.Add(this.AddTextBtn);
            this.Controls.Add(this.SourceBtn);
            this.Controls.Add(this.RevokeBtn);
            this.Controls.Add(this.ConvertedImage);
            this.Controls.Add(this.DrowoutBtn);
            this.Controls.Add(this.CropBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WaterBtn);
            this.Controls.Add(this.CerticalChangeBtn);
            this.Controls.Add(this.LevelChangeBtn);
            this.Controls.Add(this.BlurChangeBtn);
            this.Controls.Add(this.SharpenChangeBtn);
            this.Controls.Add(this.AtomizationChangeBtn);
            this.Controls.Add(this.ReverseColorBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CoefficientScrollBar);
            this.Controls.Add(this.SpreadBtn);
            this.Controls.Add(this.MosaicBtn);
            this.Controls.Add(this.RelifeBtn);
            this.Controls.Add(this.DeColorBtn);
            this.Controls.Add(this.BrightnessBtn);
            this.Controls.Add(this.FunctionLabe);
            this.Controls.Add(this.DarkCornerBtn);
            this.Controls.Add(this.SaveImageBtn);
            this.Controls.Add(this.OpenImageBtn);
            this.Controls.Add(this.ConvertedLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.ConvertedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ConvertedLabel;
        private System.Windows.Forms.Button OpenImageBtn;
        private System.Windows.Forms.Button SaveImageBtn;
        private System.Windows.Forms.Button DarkCornerBtn;
        private System.Windows.Forms.Label FunctionLabe;
        private System.Windows.Forms.Button BrightnessBtn;
        private System.Windows.Forms.Button DeColorBtn;
        private System.Windows.Forms.Button RelifeBtn;
        private System.Windows.Forms.Button MosaicBtn;
        private System.Windows.Forms.Button SpreadBtn;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.HScrollBar CoefficientScrollBar;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ReverseColorBtn;
        private System.Windows.Forms.Button AtomizationChangeBtn;
        private System.Windows.Forms.Button SharpenChangeBtn;
        private System.Windows.Forms.Button BlurChangeBtn;
        private System.Windows.Forms.Button LevelChangeBtn;
        private System.Windows.Forms.Button CerticalChangeBtn;
        private System.Windows.Forms.Button WaterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button CropBtn;
        private System.Windows.Forms.Button DrowoutBtn;
        private System.Windows.Forms.PictureBox ConvertedImage;
        private System.Windows.Forms.Button RevokeBtn;
        private System.Windows.Forms.Button SourceBtn;
        private System.Windows.Forms.Button AddTextBtn;
    }
}

