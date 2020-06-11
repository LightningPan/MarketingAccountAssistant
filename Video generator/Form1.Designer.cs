namespace Video_generator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.odlgMedia = new System.Windows.Forms.OpenFileDialog();
            this.lstPlay = new System.Windows.Forms.ListBox();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnCombine = new System.Windows.Forms.Button();
            this.rd_template1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rd_template2 = new System.Windows.Forms.RadioButton();
            this.rd_template3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.rdbtn_both = new System.Windows.Forms.RadioButton();
            this.rdbtn_video = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lstChoose = new System.Windows.Forms.ListBox();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.tmrMedia = new System.Windows.Forms.Timer(this.components);
            this.trkBar_bgm = new System.Windows.Forms.TrackBar();
            this.trkBar_people = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_vobgm = new System.Windows.Forms.Label();
            this.lbvolpeople = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbsubtitle = new System.Windows.Forms.Label();
            this.tB_srt = new System.Windows.Forms.TextBox();
            this.btnSubtitle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.trk_Start = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trk_Span = new System.Windows.Forms.TrackBar();
            this.lb_start = new System.Windows.Forms.Label();
            this.lbSpan = new System.Windows.Forms.Label();
            this.btn_srt = new System.Windows.Forms.Button();
            this.btnOK3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBar_bgm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBar_people)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Span)).BeginInit();
            this.SuspendLayout();
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(530, 12);
            this.MediaPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(677, 485);
            this.MediaPlayer.TabIndex = 0;
            // 
            // odlgMedia
            // 
            this.odlgMedia.FileName = "openFileDialog1";
            // 
            // lstPlay
            // 
            this.lstPlay.FormattingEnabled = true;
            this.lstPlay.ItemHeight = 18;
            this.lstPlay.Location = new System.Drawing.Point(596, 56);
            this.lstPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPlay.Name = "lstPlay";
            this.lstPlay.Size = new System.Drawing.Size(188, 688);
            this.lstPlay.TabIndex = 1;
            // 
            // btnDelete1
            // 
            this.btnDelete1.Location = new System.Drawing.Point(228, 208);
            this.btnDelete1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(112, 34);
            this.btnDelete1.TabIndex = 2;
            this.btnDelete1.Text = "删除";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(30, 208);
            this.btnAdd1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(112, 34);
            this.btnAdd1.TabIndex = 3;
            this.btnAdd1.Text = "添加";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnCombine
            // 
            this.btnCombine.Location = new System.Drawing.Point(207, 936);
            this.btnCombine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(112, 34);
            this.btnCombine.TabIndex = 4;
            this.btnCombine.Text = "开始合成";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.btnCombine_Click);
            // 
            // rd_template1
            // 
            this.rd_template1.AutoSize = true;
            this.rd_template1.Location = new System.Drawing.Point(12, 314);
            this.rd_template1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_template1.Name = "rd_template1";
            this.rd_template1.Size = new System.Drawing.Size(69, 22);
            this.rd_template1.TabIndex = 5;
            this.rd_template1.TabStop = true;
            this.rd_template1.Text = "自然";
            this.rd_template1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "*自定义模板*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "*内置模板*";
            // 
            // rd_template2
            // 
            this.rd_template2.AutoSize = true;
            this.rd_template2.Location = new System.Drawing.Point(117, 314);
            this.rd_template2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_template2.Name = "rd_template2";
            this.rd_template2.Size = new System.Drawing.Size(69, 22);
            this.rd_template2.TabIndex = 8;
            this.rd_template2.TabStop = true;
            this.rd_template2.Text = "城市";
            this.rd_template2.UseVisualStyleBackColor = true;
            // 
            // rd_template3
            // 
            this.rd_template3.AutoSize = true;
            this.rd_template3.Location = new System.Drawing.Point(228, 314);
            this.rd_template3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_template3.Name = "rd_template3";
            this.rd_template3.Size = new System.Drawing.Size(69, 22);
            this.rd_template3.TabIndex = 9;
            this.rd_template3.TabStop = true;
            this.rd_template3.Text = "人物";
            this.rd_template3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 436);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "-----字幕------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 496);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 11;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(902, 754);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(117, 34);
            this.btnPlay.TabIndex = 17;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1062, 754);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 34);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "上一曲";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(1220, 754);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(112, 34);
            this.btnForward.TabIndex = 19;
            this.btnForward.Text = "下一曲";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnReplay
            // 
            this.btnReplay.Location = new System.Drawing.Point(1380, 754);
            this.btnReplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(111, 34);
            this.btnReplay.TabIndex = 20;
            this.btnReplay.Text = "循环播放";
            this.btnReplay.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1524, 754);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 34);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // rdbtn_both
            // 
            this.rdbtn_both.AutoSize = true;
            this.rdbtn_both.Location = new System.Drawing.Point(158, 92);
            this.rdbtn_both.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtn_both.Name = "rdbtn_both";
            this.rdbtn_both.Size = new System.Drawing.Size(114, 22);
            this.rdbtn_both.TabIndex = 22;
            this.rdbtn_both.TabStop = true;
            this.rdbtn_both.Text = "音频+视频";
            this.rdbtn_both.UseVisualStyleBackColor = true;
            // 
            // rdbtn_video
            // 
            this.rdbtn_video.AutoSize = true;
            this.rdbtn_video.Location = new System.Drawing.Point(18, 92);
            this.rdbtn_video.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtn_video.Name = "rdbtn_video";
            this.rdbtn_video.Size = new System.Drawing.Size(69, 22);
            this.rdbtn_video.TabIndex = 23;
            this.rdbtn_video.TabStop = true;
            this.rdbtn_video.Text = "视频";
            this.rdbtn_video.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "播放列表";
            // 
            // lstChoose
            // 
            this.lstChoose.FormattingEnabled = true;
            this.lstChoose.ItemHeight = 18;
            this.lstChoose.Location = new System.Drawing.Point(12, 124);
            this.lstChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstChoose.Name = "lstChoose";
            this.lstChoose.Size = new System.Drawing.Size(354, 58);
            this.lstChoose.TabIndex = 25;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(596, 754);
            this.btnAdd2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(112, 34);
            this.btnAdd2.TabIndex = 26;
            this.btnAdd2.Text = "添加";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(744, 754);
            this.btnDelete2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(112, 34);
            this.btnDelete2.TabIndex = 27;
            this.btnDelete2.Text = "删除";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "-----模板选择------";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(117, 376);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 34);
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // trkBar_bgm
            // 
            this.trkBar_bgm.Location = new System.Drawing.Point(123, 669);
            this.trkBar_bgm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trkBar_bgm.Maximum = 100;
            this.trkBar_bgm.Name = "trkBar_bgm";
            this.trkBar_bgm.Size = new System.Drawing.Size(156, 69);
            this.trkBar_bgm.TabIndex = 30;
            this.trkBar_bgm.Scroll += new System.EventHandler(this.trkBar_bgm_Scroll);
            // 
            // trkBar_people
            // 
            this.trkBar_people.Location = new System.Drawing.Point(123, 728);
            this.trkBar_people.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trkBar_people.Maximum = 100;
            this.trkBar_people.Name = "trkBar_people";
            this.trkBar_people.Size = new System.Drawing.Size(156, 69);
            this.trkBar_people.TabIndex = 31;
            this.trkBar_people.Scroll += new System.EventHandler(this.trkBar_people_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 674);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "背景音量";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-2, 728);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 33;
            this.label10.Text = "人声音量";
            // 
            // lb_vobgm
            // 
            this.lb_vobgm.AutoSize = true;
            this.lb_vobgm.Location = new System.Drawing.Point(282, 674);
            this.lb_vobgm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_vobgm.Name = "lb_vobgm";
            this.lb_vobgm.Size = new System.Drawing.Size(17, 18);
            this.lb_vobgm.TabIndex = 34;
            this.lb_vobgm.Text = "0";
            // 
            // lbvolpeople
            // 
            this.lbvolpeople.AutoSize = true;
            this.lbvolpeople.Location = new System.Drawing.Point(279, 741);
            this.lbvolpeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbvolpeople.Name = "lbvolpeople";
            this.lbvolpeople.Size = new System.Drawing.Size(17, 18);
            this.lbvolpeople.TabIndex = 35;
            this.lbvolpeople.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-2, 628);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 18);
            this.label11.TabIndex = 36;
            this.label11.Text = "------调节参数-------";
            // 
            // lbsubtitle
            // 
            this.lbsubtitle.AutoSize = true;
            this.lbsubtitle.Location = new System.Drawing.Point(9, 478);
            this.lbsubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsubtitle.Name = "lbsubtitle";
            this.lbsubtitle.Size = new System.Drawing.Size(98, 18);
            this.lbsubtitle.TabIndex = 37;
            this.lbsubtitle.Text = "*字幕文件*";
            // 
            // tB_srt
            // 
            this.tB_srt.Location = new System.Drawing.Point(2, 519);
            this.tB_srt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_srt.Name = "tB_srt";
            this.tB_srt.ReadOnly = true;
            this.tB_srt.Size = new System.Drawing.Size(148, 28);
            this.tB_srt.TabIndex = 38;
            // 
            // btnSubtitle
            // 
            this.btnSubtitle.Location = new System.Drawing.Point(18, 573);
            this.btnSubtitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubtitle.Name = "btnSubtitle";
            this.btnSubtitle.Size = new System.Drawing.Size(112, 34);
            this.btnSubtitle.TabIndex = 39;
            this.btnSubtitle.Text = "上传";
            this.btnSubtitle.UseVisualStyleBackColor = true;
            this.btnSubtitle.Click += new System.EventHandler(this.btnSubtitle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 800);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "视频开始时刻";
            // 
            // trk_Start
            // 
            this.trk_Start.Location = new System.Drawing.Point(123, 790);
            this.trk_Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trk_Start.Maximum = 70;
            this.trk_Start.Name = "trk_Start";
            this.trk_Start.Size = new System.Drawing.Size(156, 69);
            this.trk_Start.TabIndex = 41;
            this.trk_Start.Scroll += new System.EventHandler(this.trk_Start_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 860);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "视频时长";
            // 
            // trk_Span
            // 
            this.trk_Span.Location = new System.Drawing.Point(123, 860);
            this.trk_Span.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trk_Span.Maximum = 50;
            this.trk_Span.Name = "trk_Span";
            this.trk_Span.Size = new System.Drawing.Size(156, 69);
            this.trk_Span.TabIndex = 43;
            this.trk_Span.Scroll += new System.EventHandler(this.trk_Span_Scroll);
            // 
            // lb_start
            // 
            this.lb_start.AutoSize = true;
            this.lb_start.Location = new System.Drawing.Point(282, 800);
            this.lb_start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_start.Name = "lb_start";
            this.lb_start.Size = new System.Drawing.Size(71, 18);
            this.lb_start.TabIndex = 44;
            this.lb_start.Text = "0（秒）";
            // 
            // lbSpan
            // 
            this.lbSpan.AutoSize = true;
            this.lbSpan.Location = new System.Drawing.Point(282, 876);
            this.lbSpan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSpan.Name = "lbSpan";
            this.lbSpan.Size = new System.Drawing.Size(71, 18);
            this.lbSpan.TabIndex = 45;
            this.lbSpan.Text = "0（秒）";
            // 
            // btn_srt
            // 
            this.btn_srt.Location = new System.Drawing.Point(228, 573);
            this.btn_srt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_srt.Name = "btn_srt";
            this.btn_srt.Size = new System.Drawing.Size(112, 34);
            this.btn_srt.TabIndex = 46;
            this.btn_srt.Text = "确认";
            this.btn_srt.UseVisualStyleBackColor = true;
            this.btn_srt.Click += new System.EventHandler(this.btn_srt_Click);
            // 
            // btnOK3
            // 
            this.btnOK3.Location = new System.Drawing.Point(30, 936);
            this.btnOK3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK3.Name = "btnOK3";
            this.btnOK3.Size = new System.Drawing.Size(112, 34);
            this.btnOK3.TabIndex = 47;
            this.btnOK3.Text = "确认";
            this.btnOK3.UseVisualStyleBackColor = true;
            this.btnOK3.Click += new System.EventHandler(this.btnOK3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1828, 1028);
            this.Controls.Add(this.btnOK3);
            this.Controls.Add(this.btn_srt);
            this.Controls.Add(this.lbSpan);
            this.Controls.Add(this.lb_start);
            this.Controls.Add(this.trk_Span);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trk_Start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSubtitle);
            this.Controls.Add(this.tB_srt);
            this.Controls.Add(this.lbsubtitle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbvolpeople);
            this.Controls.Add(this.lb_vobgm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trkBar_people);
            this.Controls.Add(this.trkBar_bgm);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.lstChoose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdbtn_video);
            this.Controls.Add(this.rdbtn_both);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rd_template3);
            this.Controls.Add(this.rd_template2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rd_template1);
            this.Controls.Add(this.btnCombine);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.lstPlay);
            this.Controls.Add(this.MediaPlayer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBar_bgm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBar_people)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_Span)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog odlgMedia;
        private System.Windows.Forms.ListBox lstPlay;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.RadioButton rd_template1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rd_template2;
        private System.Windows.Forms.RadioButton rd_template3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RadioButton rdbtn_both;
        private System.Windows.Forms.RadioButton rdbtn_video;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstChoose;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Timer tmrMedia;
        private System.Windows.Forms.TrackBar trkBar_bgm;
        private System.Windows.Forms.TrackBar trkBar_people;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_vobgm;
        private System.Windows.Forms.Label lbvolpeople;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbsubtitle;
        private System.Windows.Forms.TextBox tB_srt;
        private System.Windows.Forms.Button btnSubtitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trk_Start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trk_Span;
        private System.Windows.Forms.Label lb_start;
        private System.Windows.Forms.Label lbSpan;
        private System.Windows.Forms.Button btn_srt;
        private System.Windows.Forms.Button btnOK3;
    }
}

