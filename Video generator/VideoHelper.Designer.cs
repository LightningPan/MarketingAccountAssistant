namespace Video_generator
{
    partial class VideoHelper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonChooseVideo = new System.Windows.Forms.RadioButton();
            this.radioButtonChooseBoth = new System.Windows.Forms.RadioButton();
            this.buttonChooseVideo = new System.Windows.Forms.Button();
            this.buttonChooseAudio = new System.Windows.Forms.Button();
            this.buttonChooseSubtitle = new System.Windows.Forms.Button();
            this.labelVideoPath = new System.Windows.Forms.Label();
            this.labelChooseAudio = new System.Windows.Forms.Label();
            this.labelChooseSubtitle = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelBgm = new System.Windows.Forms.Label();
            this.trackBarBgm = new System.Windows.Forms.TrackBar();
            this.trackBarPerson = new System.Windows.Forms.TrackBar();
            this.labelPerson = new System.Windows.Forms.Label();
            this.labelBgmVolume = new System.Windows.Forms.Label();
            this.labelPersonVolume = new System.Windows.Forms.Label();
            this.trackBarBeginTime = new System.Windows.Forms.TrackBar();
            this.trackBarEndTime = new System.Windows.Forms.TrackBar();
            this.labelBegin = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelBeginTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.textBoxSubtitlePositionX = new System.Windows.Forms.TextBox();
            this.textBoxSubtitlePositionY = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.labelFont = new System.Windows.Forms.Label();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.labelScale = new System.Windows.Forms.Label();
            this.textBoxThickness = new System.Windows.Forms.TextBox();
            this.labelThickness = new System.Windows.Forms.Label();
            this.comboBoxLineType = new System.Windows.Forms.ComboBox();
            this.labelLineType = new System.Windows.Forms.Label();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.labelR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelRN = new System.Windows.Forms.Label();
            this.labelGN = new System.Windows.Forms.Label();
            this.labelBN = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonMakeSure = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.trackBarAudioPlayer = new System.Windows.Forms.TrackBar();
            this.buttonStop = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.buttonAudio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBgm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeginTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAudioPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonChooseVideo
            // 
            this.radioButtonChooseVideo.AutoSize = true;
            this.radioButtonChooseVideo.Checked = true;
            this.radioButtonChooseVideo.Location = new System.Drawing.Point(23, 38);
            this.radioButtonChooseVideo.Name = "radioButtonChooseVideo";
            this.radioButtonChooseVideo.Size = new System.Drawing.Size(69, 22);
            this.radioButtonChooseVideo.TabIndex = 0;
            this.radioButtonChooseVideo.TabStop = true;
            this.radioButtonChooseVideo.Text = "视频";
            this.radioButtonChooseVideo.UseVisualStyleBackColor = true;
            this.radioButtonChooseVideo.CheckedChanged += new System.EventHandler(this.radioButtonChooseVideo_CheckedChanged);
            // 
            // radioButtonChooseBoth
            // 
            this.radioButtonChooseBoth.AutoSize = true;
            this.radioButtonChooseBoth.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonChooseBoth.Location = new System.Drawing.Point(144, 38);
            this.radioButtonChooseBoth.Name = "radioButtonChooseBoth";
            this.radioButtonChooseBoth.Size = new System.Drawing.Size(114, 22);
            this.radioButtonChooseBoth.TabIndex = 1;
            this.radioButtonChooseBoth.Text = "视频+音频";
            this.radioButtonChooseBoth.UseVisualStyleBackColor = true;
            this.radioButtonChooseBoth.CheckedChanged += new System.EventHandler(this.radioButtonChooseBoth_CheckedChanged);
            // 
            // buttonChooseVideo
            // 
            this.buttonChooseVideo.AutoSize = true;
            this.buttonChooseVideo.Location = new System.Drawing.Point(164, 90);
            this.buttonChooseVideo.Name = "buttonChooseVideo";
            this.buttonChooseVideo.Size = new System.Drawing.Size(94, 28);
            this.buttonChooseVideo.TabIndex = 3;
            this.buttonChooseVideo.Text = "选择视频";
            this.buttonChooseVideo.UseVisualStyleBackColor = true;
            this.buttonChooseVideo.Click += new System.EventHandler(this.buttonChooseVideo_Click);
            // 
            // buttonChooseAudio
            // 
            this.buttonChooseAudio.Enabled = false;
            this.buttonChooseAudio.Location = new System.Drawing.Point(164, 148);
            this.buttonChooseAudio.Name = "buttonChooseAudio";
            this.buttonChooseAudio.Size = new System.Drawing.Size(94, 28);
            this.buttonChooseAudio.TabIndex = 5;
            this.buttonChooseAudio.Text = "选择音频";
            this.buttonChooseAudio.UseVisualStyleBackColor = true;
            this.buttonChooseAudio.Click += new System.EventHandler(this.buttonChooseAudio_Click);
            // 
            // buttonChooseSubtitle
            // 
            this.buttonChooseSubtitle.Location = new System.Drawing.Point(164, 197);
            this.buttonChooseSubtitle.Name = "buttonChooseSubtitle";
            this.buttonChooseSubtitle.Size = new System.Drawing.Size(94, 30);
            this.buttonChooseSubtitle.TabIndex = 6;
            this.buttonChooseSubtitle.Text = "选择字幕";
            this.buttonChooseSubtitle.UseVisualStyleBackColor = true;
            this.buttonChooseSubtitle.Click += new System.EventHandler(this.buttonChooseSubtitle_Click);
            // 
            // labelVideoPath
            // 
            this.labelVideoPath.Location = new System.Drawing.Point(20, 90);
            this.labelVideoPath.Name = "labelVideoPath";
            this.labelVideoPath.Size = new System.Drawing.Size(117, 28);
            this.labelVideoPath.TabIndex = 8;
            this.labelVideoPath.Text = "------------";
            this.labelVideoPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChooseAudio
            // 
            this.labelChooseAudio.Location = new System.Drawing.Point(20, 148);
            this.labelChooseAudio.Name = "labelChooseAudio";
            this.labelChooseAudio.Size = new System.Drawing.Size(117, 28);
            this.labelChooseAudio.TabIndex = 9;
            this.labelChooseAudio.Text = "------------";
            this.labelChooseAudio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChooseSubtitle
            // 
            this.labelChooseSubtitle.Location = new System.Drawing.Point(20, 197);
            this.labelChooseSubtitle.Name = "labelChooseSubtitle";
            this.labelChooseSubtitle.Size = new System.Drawing.Size(117, 26);
            this.labelChooseSubtitle.TabIndex = 10;
            this.labelChooseSubtitle.Text = "------------";
            this.labelChooseSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBgm
            // 
            this.labelBgm.AutoSize = true;
            this.labelBgm.Location = new System.Drawing.Point(77, 251);
            this.labelBgm.Name = "labelBgm";
            this.labelBgm.Size = new System.Drawing.Size(80, 18);
            this.labelBgm.TabIndex = 11;
            this.labelBgm.Text = "背景音量";
            this.labelBgm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarBgm
            // 
            this.trackBarBgm.Location = new System.Drawing.Point(12, 274);
            this.trackBarBgm.Maximum = 100;
            this.trackBarBgm.Name = "trackBarBgm";
            this.trackBarBgm.Size = new System.Drawing.Size(238, 69);
            this.trackBarBgm.TabIndex = 12;
            this.trackBarBgm.Scroll += new System.EventHandler(this.trackBarBgm_Scroll);
            // 
            // trackBarPerson
            // 
            this.trackBarPerson.Location = new System.Drawing.Point(12, 367);
            this.trackBarPerson.Maximum = 100;
            this.trackBarPerson.Name = "trackBarPerson";
            this.trackBarPerson.Size = new System.Drawing.Size(238, 69);
            this.trackBarPerson.TabIndex = 13;
            this.trackBarPerson.Scroll += new System.EventHandler(this.trackBarPerson_Scroll);
            // 
            // labelPerson
            // 
            this.labelPerson.AutoSize = true;
            this.labelPerson.Location = new System.Drawing.Point(77, 337);
            this.labelPerson.Name = "labelPerson";
            this.labelPerson.Size = new System.Drawing.Size(80, 18);
            this.labelPerson.TabIndex = 14;
            this.labelPerson.Text = "人声音量";
            this.labelPerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBgmVolume
            // 
            this.labelBgmVolume.AutoSize = true;
            this.labelBgmVolume.Location = new System.Drawing.Point(256, 286);
            this.labelBgmVolume.Name = "labelBgmVolume";
            this.labelBgmVolume.Size = new System.Drawing.Size(17, 18);
            this.labelBgmVolume.TabIndex = 15;
            this.labelBgmVolume.Text = "0";
            this.labelBgmVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPersonVolume
            // 
            this.labelPersonVolume.AutoSize = true;
            this.labelPersonVolume.Location = new System.Drawing.Point(256, 381);
            this.labelPersonVolume.Name = "labelPersonVolume";
            this.labelPersonVolume.Size = new System.Drawing.Size(17, 18);
            this.labelPersonVolume.TabIndex = 16;
            this.labelPersonVolume.Text = "0";
            this.labelPersonVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarBeginTime
            // 
            this.trackBarBeginTime.Location = new System.Drawing.Point(12, 461);
            this.trackBarBeginTime.Maximum = 0;
            this.trackBarBeginTime.Name = "trackBarBeginTime";
            this.trackBarBeginTime.Size = new System.Drawing.Size(246, 69);
            this.trackBarBeginTime.TabIndex = 17;
            // 
            // trackBarEndTime
            // 
            this.trackBarEndTime.Location = new System.Drawing.Point(12, 555);
            this.trackBarEndTime.Maximum = 0;
            this.trackBarEndTime.Name = "trackBarEndTime";
            this.trackBarEndTime.Size = new System.Drawing.Size(246, 69);
            this.trackBarEndTime.TabIndex = 18;
            // 
            // labelBegin
            // 
            this.labelBegin.AutoSize = true;
            this.labelBegin.Location = new System.Drawing.Point(65, 427);
            this.labelBegin.Name = "labelBegin";
            this.labelBegin.Size = new System.Drawing.Size(116, 18);
            this.labelBegin.TabIndex = 19;
            this.labelBegin.Text = "视频开始时间";
            this.labelBegin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(65, 523);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(116, 18);
            this.labelEnd.TabIndex = 20;
            this.labelEnd.Text = "视频结束时间";
            this.labelEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBeginTime
            // 
            this.labelBeginTime.AutoSize = true;
            this.labelBeginTime.Location = new System.Drawing.Point(256, 471);
            this.labelBeginTime.Name = "labelBeginTime";
            this.labelBeginTime.Size = new System.Drawing.Size(17, 18);
            this.labelBeginTime.TabIndex = 21;
            this.labelBeginTime.Text = "0";
            this.labelBeginTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Location = new System.Drawing.Point(256, 564);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(17, 18);
            this.labelEndTime.TabIndex = 22;
            this.labelEndTime.Text = "0";
            this.labelEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSubtitlePositionX
            // 
            this.textBoxSubtitlePositionX.Location = new System.Drawing.Point(330, 38);
            this.textBoxSubtitlePositionX.Name = "textBoxSubtitlePositionX";
            this.textBoxSubtitlePositionX.Size = new System.Drawing.Size(87, 28);
            this.textBoxSubtitlePositionX.TabIndex = 23;
            this.textBoxSubtitlePositionX.Text = "960";
            this.textBoxSubtitlePositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSubtitlePositionY
            // 
            this.textBoxSubtitlePositionY.Location = new System.Drawing.Point(330, 89);
            this.textBoxSubtitlePositionY.Name = "textBoxSubtitlePositionY";
            this.textBoxSubtitlePositionY.Size = new System.Drawing.Size(87, 28);
            this.textBoxSubtitlePositionY.TabIndex = 24;
            this.textBoxSubtitlePositionY.Text = "800";
            this.textBoxSubtitlePositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(432, 42);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(89, 18);
            this.labelX.TabIndex = 25;
            this.labelX.Text = "字幕坐标X";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(432, 95);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(89, 18);
            this.labelY.TabIndex = 26;
            this.labelY.Text = "字幕坐标Y";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Items.AddRange(new object[] {
            "HersheySimplex",
            "HersheyPlain",
            "HersheyDuplex",
            "HersheyComplex",
            "HersheyTriplex",
            "HersheyComplexSmall",
            "HersheyScriptSimplex",
            "HersheyScriptComplex"});
            this.comboBoxFont.Location = new System.Drawing.Point(750, 45);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(195, 26);
            this.comboBoxFont.TabIndex = 27;
            this.comboBoxFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxFont_SelectedIndexChanged);
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(967, 48);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(80, 18);
            this.labelFont.TabIndex = 28;
            this.labelFont.Text = "字幕字体";
            this.labelFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(544, 89);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(87, 28);
            this.textBoxScale.TabIndex = 29;
            this.textBoxScale.Text = "2";
            this.textBoxScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(648, 95);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(80, 18);
            this.labelScale.TabIndex = 30;
            this.labelScale.Text = "缩放因子";
            this.labelScale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxThickness
            // 
            this.textBoxThickness.Location = new System.Drawing.Point(544, 42);
            this.textBoxThickness.Name = "textBoxThickness";
            this.textBoxThickness.Size = new System.Drawing.Size(87, 28);
            this.textBoxThickness.TabIndex = 31;
            this.textBoxThickness.Text = "2";
            this.textBoxThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelThickness
            // 
            this.labelThickness.AutoSize = true;
            this.labelThickness.Location = new System.Drawing.Point(648, 48);
            this.labelThickness.Name = "labelThickness";
            this.labelThickness.Size = new System.Drawing.Size(80, 18);
            this.labelThickness.TabIndex = 32;
            this.labelThickness.Text = "线条宽度";
            this.labelThickness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxLineType
            // 
            this.comboBoxLineType.FormattingEnabled = true;
            this.comboBoxLineType.Items.AddRange(new object[] {
            "Filled",
            "FourConnected",
            "EightConnected",
            "AntiAlias"});
            this.comboBoxLineType.Location = new System.Drawing.Point(750, 89);
            this.comboBoxLineType.Name = "comboBoxLineType";
            this.comboBoxLineType.Size = new System.Drawing.Size(195, 26);
            this.comboBoxLineType.TabIndex = 33;
            this.comboBoxLineType.SelectedIndexChanged += new System.EventHandler(this.comboBoxLineType_SelectedIndexChanged);
            // 
            // labelLineType
            // 
            this.labelLineType.AutoSize = true;
            this.labelLineType.Location = new System.Drawing.Point(970, 94);
            this.labelLineType.Name = "labelLineType";
            this.labelLineType.Size = new System.Drawing.Size(44, 18);
            this.labelLineType.TabIndex = 34;
            this.labelLineType.Text = "线型";
            this.labelLineType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarG
            // 
            this.trackBarG.Location = new System.Drawing.Point(532, 158);
            this.trackBarG.Maximum = 255;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(174, 69);
            this.trackBarG.TabIndex = 35;
            this.trackBarG.Scroll += new System.EventHandler(this.trackBarG_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(739, 158);
            this.trackBarB.Maximum = 255;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(174, 69);
            this.trackBarB.TabIndex = 36;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // trackBarR
            // 
            this.trackBarR.Location = new System.Drawing.Point(319, 158);
            this.trackBarR.Maximum = 255;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(174, 69);
            this.trackBarR.TabIndex = 37;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(327, 137);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(53, 18);
            this.labelR.TabIndex = 38;
            this.labelR.Text = "颜色R";
            this.labelR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(541, 137);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(53, 18);
            this.labelG.TabIndex = 39;
            this.labelG.Text = "颜色G";
            this.labelG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(747, 137);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(53, 18);
            this.labelB.TabIndex = 40;
            this.labelB.Text = "颜色B";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRN
            // 
            this.labelRN.AutoSize = true;
            this.labelRN.Location = new System.Drawing.Point(396, 137);
            this.labelRN.Name = "labelRN";
            this.labelRN.Size = new System.Drawing.Size(0, 18);
            this.labelRN.TabIndex = 41;
            // 
            // labelGN
            // 
            this.labelGN.AutoSize = true;
            this.labelGN.Location = new System.Drawing.Point(615, 137);
            this.labelGN.Name = "labelGN";
            this.labelGN.Size = new System.Drawing.Size(0, 18);
            this.labelGN.TabIndex = 42;
            // 
            // labelBN
            // 
            this.labelBN.AutoSize = true;
            this.labelBN.Location = new System.Drawing.Point(821, 137);
            this.labelBN.Name = "labelBN";
            this.labelBN.Size = new System.Drawing.Size(0, 18);
            this.labelBN.TabIndex = 43;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(955, 158);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(93, 35);
            this.buttonGenerate.TabIndex = 44;
            this.buttonGenerate.Text = "生成";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonMakeSure
            // 
            this.buttonMakeSure.Enabled = false;
            this.buttonMakeSure.Location = new System.Drawing.Point(54, 593);
            this.buttonMakeSure.Name = "buttonMakeSure";
            this.buttonMakeSure.Size = new System.Drawing.Size(127, 31);
            this.buttonMakeSure.TabIndex = 45;
            this.buttonMakeSure.Text = "确定时间";
            this.buttonMakeSure.UseVisualStyleBackColor = true;
            this.buttonMakeSure.Click += new System.EventHandler(this.buttonMakeSure_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(319, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(729, 391);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(473, 215);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(376, 35);
            this.progressBar.TabIndex = 47;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(883, 230);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(62, 18);
            this.labelProgress.TabIndex = 48;
            this.labelProgress.Text = "......";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(344, 230);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(62, 18);
            this.labelState.TabIndex = 49;
            this.labelState.Text = "......";
            this.labelState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Enabled = false;
            this.buttonPlay.Location = new System.Drawing.Point(294, 675);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(67, 36);
            this.buttonPlay.TabIndex = 51;
            this.buttonPlay.Text = "播放";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Enabled = false;
            this.buttonPause.Location = new System.Drawing.Point(388, 675);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(76, 36);
            this.buttonPause.TabIndex = 52;
            this.buttonPause.Text = "暂停";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // trackBarAudioPlayer
            // 
            this.trackBarAudioPlayer.Enabled = false;
            this.trackBarAudioPlayer.Location = new System.Drawing.Point(618, 666);
            this.trackBarAudioPlayer.Name = "trackBarAudioPlayer";
            this.trackBarAudioPlayer.Size = new System.Drawing.Size(391, 69);
            this.trackBarAudioPlayer.TabIndex = 53;
            this.trackBarAudioPlayer.ValueChanged += new System.EventHandler(this.trackBarAudioPlayer_ValueChanged);
            this.trackBarAudioPlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBarAudioPlayer_MouseDown);
            this.trackBarAudioPlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarAudioPlayer_MouseUp);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(492, 675);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(76, 36);
            this.buttonStop.TabIndex = 54;
            this.buttonStop.Text = "停止";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(1028, 675);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(0, 18);
            this.lblPosition.TabIndex = 55;
            // 
            // buttonAudio
            // 
            this.buttonAudio.Location = new System.Drawing.Point(137, 675);
            this.buttonAudio.Name = "buttonAudio";
            this.buttonAudio.Size = new System.Drawing.Size(136, 38);
            this.buttonAudio.TabIndex = 56;
            this.buttonAudio.Text = "音频预览";
            this.buttonAudio.UseVisualStyleBackColor = true;
            this.buttonAudio.Click += new System.EventHandler(this.buttonAudio_Click);
            // 
            // VideoHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 747);
            this.Controls.Add(this.buttonAudio);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.trackBarAudioPlayer);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMakeSure);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelBN);
            this.Controls.Add(this.labelGN);
            this.Controls.Add(this.labelRN);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.trackBarR);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarG);
            this.Controls.Add(this.labelLineType);
            this.Controls.Add(this.comboBoxLineType);
            this.Controls.Add(this.labelThickness);
            this.Controls.Add(this.textBoxThickness);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.textBoxScale);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.comboBoxFont);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxSubtitlePositionY);
            this.Controls.Add(this.textBoxSubtitlePositionX);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.labelBeginTime);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelBegin);
            this.Controls.Add(this.trackBarEndTime);
            this.Controls.Add(this.trackBarBeginTime);
            this.Controls.Add(this.labelPersonVolume);
            this.Controls.Add(this.labelBgmVolume);
            this.Controls.Add(this.labelPerson);
            this.Controls.Add(this.trackBarPerson);
            this.Controls.Add(this.trackBarBgm);
            this.Controls.Add(this.labelBgm);
            this.Controls.Add(this.labelChooseSubtitle);
            this.Controls.Add(this.labelChooseAudio);
            this.Controls.Add(this.labelVideoPath);
            this.Controls.Add(this.buttonChooseSubtitle);
            this.Controls.Add(this.buttonChooseAudio);
            this.Controls.Add(this.buttonChooseVideo);
            this.Controls.Add(this.radioButtonChooseBoth);
            this.Controls.Add(this.radioButtonChooseVideo);
            this.MaximumSize = new System.Drawing.Size(1138, 803);
            this.MinimumSize = new System.Drawing.Size(1138, 803);
            this.Name = "VideoHelper";
            this.Text = "VideoHelper";
            this.Load += new System.EventHandler(this.VideoHelper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBgm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeginTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAudioPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonChooseVideo;
        private System.Windows.Forms.RadioButton radioButtonChooseBoth;
        private System.Windows.Forms.Button buttonChooseVideo;
        private System.Windows.Forms.Button buttonChooseAudio;
        private System.Windows.Forms.Button buttonChooseSubtitle;
        private System.Windows.Forms.Label labelVideoPath;
        private System.Windows.Forms.Label labelChooseAudio;
        private System.Windows.Forms.Label labelChooseSubtitle;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelBgm;
        private System.Windows.Forms.TrackBar trackBarBgm;
        private System.Windows.Forms.TrackBar trackBarPerson;
        private System.Windows.Forms.Label labelPerson;
        private System.Windows.Forms.Label labelBgmVolume;
        private System.Windows.Forms.Label labelPersonVolume;
        private System.Windows.Forms.TrackBar trackBarBeginTime;
        private System.Windows.Forms.TrackBar trackBarEndTime;
        private System.Windows.Forms.Label labelBegin;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelBeginTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.TextBox textBoxSubtitlePositionX;
        private System.Windows.Forms.TextBox textBoxSubtitlePositionY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ComboBox comboBoxFont;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.TextBox textBoxThickness;
        private System.Windows.Forms.Label labelThickness;
        private System.Windows.Forms.ComboBox comboBoxLineType;
        private System.Windows.Forms.Label labelLineType;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelRN;
        private System.Windows.Forms.Label labelGN;
        private System.Windows.Forms.Label labelBN;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonMakeSure;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.TrackBar trackBarAudioPlayer;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button buttonAudio;
    }
}