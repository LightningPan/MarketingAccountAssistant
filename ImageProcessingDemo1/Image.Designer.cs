namespace ImageProcessingDemo1
{
    partial class Image
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Image));
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.CoefficientScrollBar = new System.Windows.Forms.HScrollBar();
            this.ConvertedImage = new System.Windows.Forms.PictureBox();
            this.SourceBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤消UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.剪切TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.全选AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.特殊效果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浮雕效果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平变换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浮雕效果ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.取反色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.雾化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锐化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模糊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.去色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.调节ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.扩散ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.降低亮度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.马赛克ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.马赛克ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.剪裁图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加水印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入文本框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.CropBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertedImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.CoefficientScrollBar.Location = new System.Drawing.Point(230, 35);
            this.CoefficientScrollBar.Minimum = 1;
            this.CoefficientScrollBar.Name = "CoefficientScrollBar";
            this.CoefficientScrollBar.Size = new System.Drawing.Size(426, 39);
            this.CoefficientScrollBar.TabIndex = 17;
            this.CoefficientScrollBar.Value = 1;
            this.CoefficientScrollBar.Visible = false;
            // 
            // ConvertedImage
            // 
            this.ConvertedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertedImage.BackColor = System.Drawing.SystemColors.Control;
            this.ConvertedImage.Location = new System.Drawing.Point(31, 131);
            this.ConvertedImage.Name = "ConvertedImage";
            this.ConvertedImage.Size = new System.Drawing.Size(824, 577);
            this.ConvertedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConvertedImage.TabIndex = 27;
            this.ConvertedImage.TabStop = false;
            this.ConvertedImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.ConvertedImage_DragDrop);
            this.ConvertedImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.ConvertedImage_DragEnter);
            this.ConvertedImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConvertedImage_MouseDown);
            this.ConvertedImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConvertedImage_MouseMove);
            this.ConvertedImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ConvertedImage_MouseUp);
            // 
            // SourceBtn
            // 
            this.SourceBtn.Location = new System.Drawing.Point(31, 35);
            this.SourceBtn.Name = "SourceBtn";
            this.SourceBtn.Size = new System.Drawing.Size(166, 39);
            this.SourceBtn.TabIndex = 8;
            this.SourceBtn.Text = "查看原图";
            this.SourceBtn.UseVisualStyleBackColor = true;
            this.SourceBtn.Visible = false;
            this.SourceBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SourceBtn_MouseDown_1);
            this.SourceBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SourceBtn_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.插入文本框ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 32);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "Menu";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开OToolStripMenuItem,
            this.toolStripSeparator,
            this.另存为AToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            this.文件FToolStripMenuItem.Click += new System.EventHandler(this.文件FToolStripMenuItem_Click);
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新建NToolStripMenuItem.Image")));
            this.新建NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.新建NToolStripMenuItem.Text = "新建(&N)";
            this.新建NToolStripMenuItem.Click += new System.EventHandler(this.新建NToolStripMenuItem_Click);
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打开OToolStripMenuItem.Image")));
            this.打开OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(267, 6);
            // 
            // 另存为AToolStripMenuItem
            // 
            this.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem";
            this.另存为AToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.另存为AToolStripMenuItem.Text = "另存为(&A)";
            this.另存为AToolStripMenuItem.Click += new System.EventHandler(this.另存为AToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(267, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤消UToolStripMenuItem,
            this.toolStripSeparator3,
            this.剪切TToolStripMenuItem,
            this.复制CToolStripMenuItem,
            this.粘贴PToolStripMenuItem,
            this.toolStripSeparator4,
            this.全选AToolStripMenuItem});
            this.编辑EToolStripMenuItem.Enabled = false;
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 撤消UToolStripMenuItem
            // 
            this.撤消UToolStripMenuItem.Name = "撤消UToolStripMenuItem";
            this.撤消UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.撤消UToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.撤消UToolStripMenuItem.Text = "撤消(&U)";
            this.撤消UToolStripMenuItem.Click += new System.EventHandler(this.撤消UToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(233, 6);
            // 
            // 剪切TToolStripMenuItem
            // 
            this.剪切TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("剪切TToolStripMenuItem.Image")));
            this.剪切TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem";
            this.剪切TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪切TToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.剪切TToolStripMenuItem.Text = "剪切(&T)";
            // 
            // 复制CToolStripMenuItem
            // 
            this.复制CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("复制CToolStripMenuItem.Image")));
            this.复制CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
            this.复制CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制CToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.复制CToolStripMenuItem.Text = "复制(&C)";
            // 
            // 粘贴PToolStripMenuItem
            // 
            this.粘贴PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("粘贴PToolStripMenuItem.Image")));
            this.粘贴PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem";
            this.粘贴PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴PToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.粘贴PToolStripMenuItem.Text = "粘贴(&P)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(233, 6);
            // 
            // 全选AToolStripMenuItem
            // 
            this.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem";
            this.全选AToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.全选AToolStripMenuItem.Text = "全选(&A)";
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.特殊效果ToolStripMenuItem,
            this.调节ToolStripMenuItem,
            this.剪裁图片ToolStripMenuItem,
            this.插入图片ToolStripMenuItem,
            this.添加水印ToolStripMenuItem});
            this.工具TToolStripMenuItem.Enabled = false;
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 特殊效果ToolStripMenuItem
            // 
            this.特殊效果ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.浮雕效果ToolStripMenuItem,
            this.水平变换ToolStripMenuItem,
            this.浮雕效果ToolStripMenuItem1,
            this.取反色ToolStripMenuItem,
            this.雾化ToolStripMenuItem,
            this.锐化ToolStripMenuItem,
            this.模糊ToolStripMenuItem,
            this.去色ToolStripMenuItem});
            this.特殊效果ToolStripMenuItem.Name = "特殊效果ToolStripMenuItem";
            this.特殊效果ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.特殊效果ToolStripMenuItem.Text = "特殊效果";
            // 
            // 浮雕效果ToolStripMenuItem
            // 
            this.浮雕效果ToolStripMenuItem.Name = "浮雕效果ToolStripMenuItem";
            this.浮雕效果ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.浮雕效果ToolStripMenuItem.Text = "垂直变换";
            this.浮雕效果ToolStripMenuItem.Click += new System.EventHandler(this.垂直变换ToolStripMenuItem_Click);
            // 
            // 水平变换ToolStripMenuItem
            // 
            this.水平变换ToolStripMenuItem.Name = "水平变换ToolStripMenuItem";
            this.水平变换ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.水平变换ToolStripMenuItem.Text = "水平变换";
            this.水平变换ToolStripMenuItem.Click += new System.EventHandler(this.水平变换ToolStripMenuItem_Click);
            // 
            // 浮雕效果ToolStripMenuItem1
            // 
            this.浮雕效果ToolStripMenuItem1.Name = "浮雕效果ToolStripMenuItem1";
            this.浮雕效果ToolStripMenuItem1.Size = new System.Drawing.Size(182, 34);
            this.浮雕效果ToolStripMenuItem1.Text = "浮雕效果";
            this.浮雕效果ToolStripMenuItem1.Click += new System.EventHandler(this.浮雕效果ToolStripMenuItem1_Click);
            // 
            // 取反色ToolStripMenuItem
            // 
            this.取反色ToolStripMenuItem.Name = "取反色ToolStripMenuItem";
            this.取反色ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.取反色ToolStripMenuItem.Text = "取反色";
            this.取反色ToolStripMenuItem.Click += new System.EventHandler(this.取反色ToolStripMenuItem_Click);
            // 
            // 雾化ToolStripMenuItem
            // 
            this.雾化ToolStripMenuItem.Name = "雾化ToolStripMenuItem";
            this.雾化ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.雾化ToolStripMenuItem.Text = "雾化";
            this.雾化ToolStripMenuItem.Click += new System.EventHandler(this.雾化ToolStripMenuItem_Click);
            // 
            // 锐化ToolStripMenuItem
            // 
            this.锐化ToolStripMenuItem.Name = "锐化ToolStripMenuItem";
            this.锐化ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.锐化ToolStripMenuItem.Text = "锐化";
            this.锐化ToolStripMenuItem.Click += new System.EventHandler(this.锐化ToolStripMenuItem_Click);
            // 
            // 模糊ToolStripMenuItem
            // 
            this.模糊ToolStripMenuItem.Name = "模糊ToolStripMenuItem";
            this.模糊ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.模糊ToolStripMenuItem.Text = "模糊";
            this.模糊ToolStripMenuItem.Click += new System.EventHandler(this.模糊ToolStripMenuItem_Click);
            // 
            // 去色ToolStripMenuItem
            // 
            this.去色ToolStripMenuItem.Name = "去色ToolStripMenuItem";
            this.去色ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.去色ToolStripMenuItem.Text = "去色";
            this.去色ToolStripMenuItem.Click += new System.EventHandler(this.去色ToolStripMenuItem_Click);
            // 
            // 调节ToolStripMenuItem
            // 
            this.调节ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.扩散ToolStripMenuItem,
            this.降低亮度ToolStripMenuItem,
            this.马赛克ToolStripMenuItem,
            this.马赛克ToolStripMenuItem1});
            this.调节ToolStripMenuItem.Name = "调节ToolStripMenuItem";
            this.调节ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.调节ToolStripMenuItem.Text = "调节";
            // 
            // 扩散ToolStripMenuItem
            // 
            this.扩散ToolStripMenuItem.Name = "扩散ToolStripMenuItem";
            this.扩散ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.扩散ToolStripMenuItem.Text = "添加暗角";
            this.扩散ToolStripMenuItem.Click += new System.EventHandler(this.添加暗角ToolStripMenuItem_Click);
            // 
            // 降低亮度ToolStripMenuItem
            // 
            this.降低亮度ToolStripMenuItem.Name = "降低亮度ToolStripMenuItem";
            this.降低亮度ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.降低亮度ToolStripMenuItem.Text = "降低亮度";
            this.降低亮度ToolStripMenuItem.Click += new System.EventHandler(this.降低亮度ToolStripMenuItem_Click);
            // 
            // 马赛克ToolStripMenuItem
            // 
            this.马赛克ToolStripMenuItem.Name = "马赛克ToolStripMenuItem";
            this.马赛克ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.马赛克ToolStripMenuItem.Text = "扩散效果";
            this.马赛克ToolStripMenuItem.Click += new System.EventHandler(this.扩散效果ToolStripMenuItem_Click);
            // 
            // 马赛克ToolStripMenuItem1
            // 
            this.马赛克ToolStripMenuItem1.Name = "马赛克ToolStripMenuItem1";
            this.马赛克ToolStripMenuItem1.Size = new System.Drawing.Size(182, 34);
            this.马赛克ToolStripMenuItem1.Text = "马赛克";
            this.马赛克ToolStripMenuItem1.Click += new System.EventHandler(this.马赛克ToolStripMenuItem1_Click);
            // 
            // 剪裁图片ToolStripMenuItem
            // 
            this.剪裁图片ToolStripMenuItem.Name = "剪裁图片ToolStripMenuItem";
            this.剪裁图片ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.剪裁图片ToolStripMenuItem.Text = "剪裁图片";
            this.剪裁图片ToolStripMenuItem.Click += new System.EventHandler(this.剪裁图片ToolStripMenuItem_Click);
            // 
            // 插入图片ToolStripMenuItem
            // 
            this.插入图片ToolStripMenuItem.Name = "插入图片ToolStripMenuItem";
            this.插入图片ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.插入图片ToolStripMenuItem.Text = "插入图片";
            this.插入图片ToolStripMenuItem.Click += new System.EventHandler(this.插入图片ToolStripMenuItem_Click);
            // 
            // 添加水印ToolStripMenuItem
            // 
            this.添加水印ToolStripMenuItem.Name = "添加水印ToolStripMenuItem";
            this.添加水印ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.添加水印ToolStripMenuItem.Text = "添加水印";
            this.添加水印ToolStripMenuItem.Click += new System.EventHandler(this.添加水印ToolStripMenuItem_Click);
            // 
            // 插入文本框ToolStripMenuItem
            // 
            this.插入文本框ToolStripMenuItem.Enabled = false;
            this.插入文本框ToolStripMenuItem.Name = "插入文本框ToolStripMenuItem";
            this.插入文本框ToolStripMenuItem.Size = new System.Drawing.Size(116, 28);
            this.插入文本框ToolStripMenuItem.Text = "插入文本框";
            this.插入文本框ToolStripMenuItem.Click += new System.EventHandler(this.插入文本框ToolStripMenuItem_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(689, 35);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(166, 39);
            this.ChangeBtn.TabIndex = 29;
            this.ChangeBtn.Text = "调节";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Visible = false;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // CropBtn
            // 
            this.CropBtn.BackColor = System.Drawing.Color.White;
            this.CropBtn.Location = new System.Drawing.Point(776, 94);
            this.CropBtn.Name = "CropBtn";
            this.CropBtn.Size = new System.Drawing.Size(69, 31);
            this.CropBtn.TabIndex = 30;
            this.CropBtn.UseVisualStyleBackColor = false;
            this.CropBtn.Visible = false;
            this.CropBtn.Click += new System.EventHandler(this.CropBtn_Click);
            // 
            // Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 751);
            this.Controls.Add(this.CropBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.SourceBtn);
            this.Controls.Add(this.CoefficientScrollBar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ConvertedImage);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Image";
            this.Text = "海报生成";
            ((System.ComponentModel.ISupportInitialize)(this.ConvertedImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.HScrollBar CoefficientScrollBar;
        private System.Windows.Forms.PictureBox ConvertedImage;
        private System.Windows.Forms.Button SourceBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 另存为AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤消UToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 全选AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 特殊效果ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浮雕效果ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平变换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浮雕效果ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 取反色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 雾化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锐化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模糊ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 去色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 调节ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 扩散ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 降低亮度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 马赛克ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 马赛克ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 剪裁图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加水印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入文本框ToolStripMenuItem;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Button CropBtn;
    }
}

