using Emgu.CV;
using Emgu.CV.Cuda;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using NAudio.Wave;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using Xabe.FFmpeg;
using Xabe.FFmpeg.Downloader;
using Timer = System.Windows.Forms.Timer;

namespace Video_generator
{
    public partial class VideoHelper : Form
    {
        Info info;

        public VideoHelper()
        {
            InitializeComponent();
            info = new Info(pictureBox1.Width,pictureBox1.Height);
          
           
            this.labelBgmVolume.DataBindings.Add("Text", trackBarBgm, "Value");
            this.labelPersonVolume.DataBindings.Add("Text", trackBarPerson, "Value");
            this.labelEndTime.DataBindings.Add("Text", trackBarEndTime, "Value");
            this.labelBeginTime.DataBindings.Add("Text", trackBarBeginTime, "Value");
            this.trackBarEndTime.DataBindings.Add("Minimum", trackBarBeginTime, "Value");
            this.trackBarEndTime.DataBindings.Add("Maximum", trackBarBeginTime, "Maximum");
            this.textBoxThickness.DataBindings.Add("Text", info, "thickness");
            this.textBoxScale.DataBindings.Add("Text", info, "scale");
            this.trackBarBeginTime.DataBindings.Add("Value", info, "BeginTime");
            this.trackBarEndTime.DataBindings.Add("Value", info, "EndTime");
            this.textBoxSubtitlePositionX.DataBindings.Add("Text",info,"X");
            this.textBoxSubtitlePositionY.DataBindings.Add("Text",info,"Y");
            this.pictureBox1.BackColor = Color.Black;
            this.labelSub.MouseDown += new MouseEventHandler(labelSub_MouseDown);
            this.labelSub.MouseMove += new MouseEventHandler(labelSub_MouseMove);
            this.labelSub.MouseUp += new MouseEventHandler(labelSub_MouseUp);
            //this.labelSub.Parent = pictureBox1;
            pictureBox1.Image = info.bmp;
            pictureBox1.Controls.Add(labelSub);
            this.labelSub.BackColor = Color.White;
            modeVideoToolStripMenuItem.Checked = true;
            importAudioFileToolStripMenuItem.Enabled = false;
            this.labelSub.Location = new Point(0,0);
            if (File.Exists(info.mixed))
            {
                System.IO.File.Delete(info.mixed);
            }
            if (File.Exists(info.bgmTemp)) {
                System.IO.File.Delete(info.bgmTemp);
            }
            if (File.Exists(info.speechTemp))
            {
                System.IO.File.Delete(info.speechTemp);
            }
            if (!File.Exists("ffmpeg.exe")) {
                FFmpegDownloader.GetLatestVersion(FFmpegVersion.Full);
            }
        }

        private void VideoHelper_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);

        }

        private void labelSub_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.CreateGraphics().DrawImage(info.bmp, new System.Drawing.Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            //textBoxSubtitlePositionX.Text= (Control.MousePosition.X / pictureBox1.Width * info.width).ToString();
            //textBoxSubtitlePositionY.Text=(Control.MousePosition.Y / pictureBox1.Height * info.height).ToString();
            
        }

        private void labelSub_MouseDown(object sender, MouseEventArgs e) {
            m_lastMPoint = Control.MousePosition;
            m_lastPoint = (sender as Label).Location;

        }
        private Point m_lastPoint;
        private Point m_lastMPoint;
        private void labelSub_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
            {
                labelSub.Location = new Point(m_lastPoint.X + Control.MousePosition.X - m_lastMPoint.X, m_lastPoint.Y + Control.MousePosition.Y - m_lastMPoint.Y);
                pictureBox1.CreateGraphics().DrawImage(info.bmp, new System.Drawing.Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                info.X = (m_lastPoint.X + Control.MousePosition.X - m_lastMPoint.X ) * info.width / pictureBox1.Width;
                info.Y = (m_lastPoint.Y + Control.MousePosition.Y - m_lastMPoint.Y) * info.height / pictureBox1.Height;
                textBoxSubtitlePositionX.Text = info.X.ToString();
                textBoxSubtitlePositionY.Text = info.Y.ToString();
            }
        
        }

        private void trackBarBgm_Scroll(object sender, EventArgs e)
        {
            info.BgmVolume = ((float)trackBarBgm.Value) / 100;
            if (File.Exists(info.mixed)) {
                Merge.MixBgmAndSpeech(info);
            }
        }

        private void trackBarPerson_Scroll(object sender, EventArgs e)
        {

            info.PersonVolume = ((float)trackBarPerson.Value) / 100;
            if (File.Exists(info.mixed))
            {
                Merge.MixBgmAndSpeech(info);
            }
        }




        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (buttonStop.Enabled) {
                StopAction();
                buttonPlay.Enabled = false;
                buttonPause.Enabled = false;
                buttonStop.Enabled = false;
                trackBarBgm.Enabled = true;
                trackBarPerson.Enabled = true;
            }

            saveFileDialog.Filter = "mp4文件|*.mp4";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                    if (info.subtitles == null) {
                        MessageBox.Show("请选择字幕文件");
                        return;
                    }
                    if (info.VideoPath == null) {
                        MessageBox.Show("请选择视频文件");
                        return;
                    }
                    if (modeBothToolStripMenuItem.Checked && (info.AudioPath == null)) {
                        MessageBox.Show("请选择音频文件");
                        return;
                    }
                    info.output = saveFileDialog.FileName;
                    if (modeVideoToolStripMenuItem.Checked)
                    {

                        info.AudioPath = info.bgmTemp;

                    }
                    progressBar.Value = 0;
                    labelProgress.Text = "";
                    labelState.Text = "";
                    Merge.progressdelegate = new Merge.progressDelegate(refreshProgressBar);
                    Merge.progressstate = new Merge.progressState(refreshProgressState);
                    Task.Run(new Action(() => {
                        Merge.MergeAll(info);
                    }));
                    GC.Collect();
 

            }
        }

        public void refreshProgressBar(int i) {
            if (this.progressBar.InvokeRequired)
            {
                Merge.progressdelegate = new Merge.progressDelegate(refreshProgressBar);
                this.Invoke(Merge.progressdelegate, new object[] { i });
            }
            else
            {
                progressBar.Value = i;

            }
            if (this.labelProgress.InvokeRequired)
            {
                Merge.progressdelegate = new Merge.progressDelegate(refreshProgressBar);
                this.Invoke(Merge.progressdelegate, new object[] { i });
            }
            else
            {
                labelProgress.Text = i.ToString() + "%";
            }

        }

        public void refreshProgressState(string a) {
            if (this.labelProgress.InvokeRequired)
            {
                Merge.progressstate = new Merge.progressState(refreshProgressState);
                this.Invoke(Merge.progressstate, new object[] { a });
            }
            else {
                labelState.Text = a;
            }
        }

        private void buttonMakeSure_Click(object sender, EventArgs e)
        {
            Task a = new Task(new Action(() => {
                Split.SplitVideo(info);
            }));
            a.Start();
            a.Wait();
            info.VideoPath = info.cutVideo;

            Task b = new Task(new Action(() =>
            {
                Split.SplitAudio(info);
            }));
            b.Start();
            b.Wait();
            info.AudioPath = info.cutAudio;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try { labelSub.Location = new Point(info.X * pictureBox1.Width / info.width , info.Y * pictureBox1.Height / info.height ); }
            catch (Exception) {
                
            }
            //labelSub.Refresh();
            //if (info.VideoPath == null) return;
            //VideoCapture cap = new VideoCapture(info.VideoPath);
            //Mat mat = new Mat();
            //cap.Read(mat);
            //CvInvoke.PutText(mat, "Test", new Point(info.X,info.Y), info.fontFace, info.scale, new Bgr(info.B,info.G,info.R).MCvScalar, info.thickness, info.lineType, false);
            //pictureBox1.CreateGraphics().DrawImage(mat.ToBitmap(), new System.Drawing.Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            //cap.Dispose();


        }


        private void buttonPlay_Click(object sender, EventArgs e)
        {
            PlayAction();

        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            PauseAction();
        }

       
        private IWavePlayer _device;
        private AudioFileReader _reader;
        private CancellationTokenSource _cts;
        private bool _sliderLock; // 逻辑锁，当为true时不更新界面上的进度

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopAction();
            buttonPlay.Enabled = false;
            buttonPause.Enabled = false;
            buttonStop.Enabled = false;
            trackBarBgm.Enabled = true;
            trackBarPerson.Enabled = true;
        }

        private void trackBarAudioPlayer_MouseDown(object sender, MouseEventArgs e)
        {
            _sliderLock = true; // 拖动开始，停止更新界面
        }

        private void trackBarAudioPlayer_MouseUp(object sender, MouseEventArgs e)
        {
            // 释放鼠标时，应用目标进度
            _reader.CurrentTime = TimeSpan.FromMilliseconds(trackBarAudioPlayer.Value);
            UpdateProgress();
            _sliderLock = false; // 拖动结束，恢复更新界面
        }

        private void trackBarAudioPlayer_ValueChanged(object sender, EventArgs e)
        {
            if (_sliderLock)
            {
                // 拖动时可以直观看到目标进度
                lblPosition.Text = TimeSpan.FromMilliseconds(trackBarAudioPlayer.Value).ToString(@"mm\:ss");
            }
        }

        private void Device_OnPlaybackStopped(object obj, StoppedEventArgs arg)
        {
            StopAction();
        }
        private void StartUpdateProgress()
        {
            Task.Run(() =>
            {
                while (!_cts.IsCancellationRequested)
                {
                    if (_device.PlaybackState == PlaybackState.Playing)
                    {
                        // 若为播放状态，持续更新界面
                        BeginInvoke(new Action(UpdateProgress));
                        Thread.Sleep(100);
                    }
                    else
                    {
                        Thread.Sleep(50);
                    }
                }
            });
        }
        private void StopAction()
        {
            //_device?.Stop();
            //if (_reader != null) _reader.Position = 0;
            //UpdateProgress();
            DisposeAll();
            trackBarAudioPlayer.Value = 0;
            lblPosition.Text = "00:00";
            trackBarAudioPlayer.Enabled = false;
        }

        private void PlayAction()
        {
            _device?.Play();
        }

        private void PauseAction()
        {
            _device?.Pause();
        }

        private void UpdateProgress()
        {
            var currentTime = _reader?.CurrentTime ?? TimeSpan.Zero; // 当前时间
            Console.WriteLine(currentTime);

            if (!_sliderLock)
            {
                trackBarAudioPlayer.Value = (int)currentTime.TotalMilliseconds;
                lblPosition.Text = currentTime.ToString(@"mm\:ss");
            }
        }
        private void DisposeDevice()
        {
            if (_device != null)
            {
                _device.PlaybackStopped -= Device_OnPlaybackStopped;
                _device.Dispose();
            }
        }
        private void DisposeAll()
        {
            _cts?.Cancel();
            _cts?.Dispose();
            _reader?.Dispose();
            DisposeDevice();
        }

        private void buttonAudio_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(info.mixed)) {
                trackBarAudioPlayer.Enabled = true;
                trackBarBgm.Enabled = false;
                trackBarPerson.Enabled = false;
                buttonPlay.Enabled = true;
                buttonPause.Enabled = true;
                buttonStop.Enabled = true;
                _device = new WaveOutEvent();
                _reader = new AudioFileReader(info.mixed);
                _device.Init(_reader);
                var duration = _reader.TotalTime;
                trackBarAudioPlayer.Maximum = (int)duration.TotalMilliseconds;
                lblPosition.Text=duration.ToString(@"mm\:ss");
                _cts = new CancellationTokenSource();
                StartUpdateProgress(); // 界面更新线程
                _device.PlaybackStopped += Device_OnPlaybackStopped;

            }
        }

        private void contextMenuStripOnPicBox_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }

        private void hershySimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.fontFace = FontFace.HersheySimplex;
        }

        private void hersheyPlainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.fontFace = FontFace.HersheyPlain;
        }

        private void hersheyDuplexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.fontFace = FontFace.HersheyDuplex;
        }

        private void hersheyComplexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.fontFace = FontFace.HersheyComplex;
        }

        private void hersheyTriplexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.fontFace = FontFace.HersheyTriplex;
        }

        private void hersheyComplexSmallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.fontFace = FontFace.HersheyComplexSmall;
        }

        private void hersheyScriptSimplexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.fontFace = FontFace.HersheyScriptSimplex;
        }

        private void hersheyScriptComplexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.fontFace = FontFace.HersheyScriptComplex;
        }

        private void filledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.lineType = LineType.Filled;
        }

        private void fourConnectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.lineType = LineType.FourConnected;
        }

        private void eghitConnectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.lineType = LineType.EightConnected;
        }

        private void antiAliasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.lineType = LineType.AntiAlias;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialogSubtitle.ShowDialog() == DialogResult.OK) {
                info.R = colorDialogSubtitle.Color.R;
                info.G = colorDialogSubtitle.Color.G;
                info.B = colorDialogSubtitle.Color.B;
                buttonColor.BackColor = colorDialogSubtitle.Color;
            }
        }

        private void modeVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modeVideoToolStripMenuItem.Checked = true;
            modeBothToolStripMenuItem.Checked = false;
            importAudioFileToolStripMenuItem.Enabled = false;
            if (info.VideoPath != null && info.subtitles != null)
            {
                info.AudioPath = info.bgmTemp;
                Merge.MixBgmAndSpeech(info);
            }
        }

        private async void importVideoFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "mp4文件|*.mp4|avi文件|*avi|所有文件|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                info.VideoPath = openFileDialog.FileName;
                labelVideoPath.Text = openFileDialog.SafeFileName;
                trackBarBeginTime.Maximum = (int)await Info.GetMediaTime(info.VideoPath);
                buttonMakeSure.Enabled = true;
                if (trackBarBeginTime.Maximum == 0)
                {
                    MessageBox.Show("无法读取视频长度，长度调节暂不可用");
                }
                Task a = new Task(new Action(() => {
                    Split.ExtractAudio(info);
                }));
                a.Start();
                a.Wait();
                VideoCapture cap = new VideoCapture(info.VideoPath);
                info.width = (int)cap.GetCaptureProperty(CapProp.FrameWidth);
                info.height = (int)cap.GetCaptureProperty(CapProp.FrameHeight);
                info.bmp = cap.QueryFrame().ToBitmap();
                pictureBox1.CreateGraphics().DrawImage(info.bmp, new System.Drawing.Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                cap.Dispose();
                if (modeVideoToolStripMenuItem.Checked && info.subtitles != null)
                {
                    info.AudioPath = info.bgmTemp;
                    Merge.MixBgmAndSpeech(info);
                }

            }
        }

        private void importAudioFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "mp3文件|*.mp3|所有文件|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                info.AudioPath = openFileDialog.FileName;
                labelChooseAudio.Text = openFileDialog.SafeFileName;

            }
            if (info.subtitles != null)
            {
                Merge.MixBgmAndSpeech(info);
            }
        }

        private void importSubtitleFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "srt文件|*.srt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                info.SubtitlePath = openFileDialog.FileName;
                info.subtitles = SubtitleOption.ParseSubtitle(info.SubtitlePath);
                labelChooseSubtitle.Text = openFileDialog.SafeFileName;
                TTS.CreateSpeechFile(TTS.SubtitleToXml(info.subtitles), info.speechTemp);
            }
            if (modeVideoToolStripMenuItem.Checked)
            {

                info.AudioPath = info.bgmTemp;

            }
            else
            {
                if (info.AudioPath == null) return;
            }
            Merge.MixBgmAndSpeech(info);

        }

        private void modeBothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modeBothToolStripMenuItem.Checked = true;
            modeVideoToolStripMenuItem.Checked = false;
            importAudioFileToolStripMenuItem.Enabled = true;
            info.AudioPath = null;
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (buttonStop.Enabled)
            {
                StopAction();
                buttonPlay.Enabled = false;
                buttonPause.Enabled = false;
                buttonStop.Enabled = false;
                trackBarBgm.Enabled = true;
                trackBarPerson.Enabled = true;
            }

            saveFileDialog.Filter = "mp4文件|*.mp4";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                if (info.subtitles == null)
                {
                    MessageBox.Show("请选择字幕文件");
                    return;
                }
                if (info.VideoPath == null)
                {
                    MessageBox.Show("请选择视频文件");
                    return;
                }
                if (modeBothToolStripMenuItem.Checked && (info.AudioPath == null))
                {
                    MessageBox.Show("请选择音频文件");
                    return;
                }
                info.output = saveFileDialog.FileName;
                if (modeVideoToolStripMenuItem.Checked)
                {

                    info.AudioPath = info.bgmTemp;

                }
                progressBar.Value = 0;
                labelProgress.Text = "";
                labelState.Text = "";
                Merge.progressdelegate = new Merge.progressDelegate(refreshProgressBar);
                Merge.progressstate = new Merge.progressState(refreshProgressState);
                Task.Run(new Action(() => {
                    Merge.MergeAll(info);
                }));
                GC.Collect();


            }
        }

        private void buttonPlay_Click_1(object sender, EventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
