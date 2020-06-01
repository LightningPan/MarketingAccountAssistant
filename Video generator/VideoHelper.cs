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
            info = new Info();
            this.labelBgmVolume.DataBindings.Add("Text", trackBarBgm, "Value");
            this.labelPersonVolume.DataBindings.Add("Text", trackBarPerson, "Value");
            this.labelEndTime.DataBindings.Add("Text", trackBarEndTime, "Value");
            this.labelBeginTime.DataBindings.Add("Text", trackBarBeginTime, "Value");
            this.trackBarEndTime.DataBindings.Add("Minimum", trackBarBeginTime, "Value");
            this.trackBarEndTime.DataBindings.Add("Maximum", trackBarBeginTime, "Maximum");
            this.labelRN.DataBindings.Add("Text", trackBarR, "Value");
            this.labelGN.DataBindings.Add("Text", trackBarG, "Value");
            this.labelBN.DataBindings.Add("Text", trackBarB, "Value");
            this.textBoxSubtitlePositionX.DataBindings.Add("Text", info, "X");
            this.textBoxSubtitlePositionY.DataBindings.Add("Text", info, "Y");
            this.textBoxThickness.DataBindings.Add("Text", info, "thickness");
            this.textBoxScale.DataBindings.Add("Text", info, "scale");
            this.trackBarBeginTime.DataBindings.Add("Value", info, "BeginTime");
            this.trackBarEndTime.DataBindings.Add("Value", info, "EndTime");
            pictureBox1.BackColor = Color.Black;
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

        }

        private void radioButtonChooseVideo_CheckedChanged(object sender, EventArgs e)
        {
            buttonChooseAudio.Enabled = false;
            if (info.VideoPath != null && info.subtitles != null) {
                info.AudioPath = info.bgmTemp;
                Merge.MixBgmAndSpeech(info);
            }
        }

        private void radioButtonChooseBoth_CheckedChanged(object sender, EventArgs e)
        {
            buttonChooseAudio.Enabled = true;
            info.AudioPath = null;
        }

        private async void buttonChooseVideo_Click(object sender, EventArgs e)
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
                    Split.extractaudio(info);
                }));
                a.Start();
                a.Wait();
                VideoCapture cap = new VideoCapture(info.VideoPath);
                pictureBox1.CreateGraphics().DrawImage(cap.QueryFrame().ToBitmap(), new System.Drawing.Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height)) ;
                cap.Dispose();
                if (radioButtonChooseVideo.Checked&&info.subtitles!=null) {
                    info.AudioPath = info.bgmTemp;
                    Merge.MixBgmAndSpeech(info);
                }

            }
        }

        private void buttonChooseAudio_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "mp3文件|*.mp3|所有文件|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                info.AudioPath = openFileDialog.FileName;
                labelChooseAudio.Text = openFileDialog.SafeFileName;

            }
            if (info.subtitles != null) {
                Merge.MixBgmAndSpeech(info);
            }
        }

        private void buttonChooseSubtitle_Click(object sender, EventArgs e)
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
            if (radioButtonChooseVideo.Checked)
            {

                info.AudioPath = info.bgmTemp;

            }
            else {
                if (info.AudioPath == null) return;
            }
            Merge.MixBgmAndSpeech(info);

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


        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFont.SelectedIndex)
            {
                case 0:
                    info.fontFace = FontFace.HersheySimplex;
                    break;
                case 1:
                    info.fontFace = FontFace.HersheyPlain;
                    break;
                case 2:
                    info.fontFace = FontFace.HersheyDuplex;
                    break;
                case 3:
                    info.fontFace = FontFace.HersheyComplex;
                    break;
                case 4:
                    info.fontFace = FontFace.HersheyTriplex;
                    break;
                case 5:
                    info.fontFace = FontFace.HersheyComplexSmall;
                    break;
                case 6:
                    info.fontFace = FontFace.HersheyScriptSimplex;
                    break;
                case 7:
                    info.fontFace = FontFace.HersheyScriptComplex;
                    break;
            }
        }

        private void comboBoxLineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxLineType.SelectedIndex)
            {
                case 0:
                    info.lineType = LineType.Filled;
                    break;
                case 1:
                    info.lineType = LineType.FourConnected;
                    break;
                case 2:
                    info.lineType = LineType.EightConnected;
                    break;
                case 3:
                    info.lineType = LineType.AntiAlias;
                    break;

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
                if (radioButtonChooseVideo.Checked == true)
                {
                    if (info.subtitles == null) {
                        MessageBox.Show("请选择字幕文件");
                        return;
                    }
                    if (info.VideoPath == null) {
                        MessageBox.Show("请选择视频文件");
                        return;
                    }
                    if (radioButtonChooseBoth.Checked && (info.AudioPath == null)) {
                        MessageBox.Show("请选择音频文件");
                        return;
                    }
                    info.output = saveFileDialog.FileName;
                    if (radioButtonChooseVideo.Checked)
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
            if (info.VideoPath == "") return;
            VideoCapture cap = new VideoCapture(info.VideoPath);
            Mat mat = new Mat();
            cap.Read(mat);
            CvInvoke.PutText(mat, "Test", new Point(info.X,info.Y), info.fontFace, info.scale, new Bgr(info.B,info.G,info.R).MCvScalar, info.thickness, info.lineType, false);
            pictureBox1.CreateGraphics().DrawImage(mat.ToBitmap(), new System.Drawing.Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            cap.Dispose();


        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            info.R = trackBarR.Value;
        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            info.G = trackBarG.Value;
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            info.B = trackBarB.Value;
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
    }

}
