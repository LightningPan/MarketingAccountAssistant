using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Xabe.FFmpeg;
using System.Speech.Synthesis;
using System.Xml.Serialization;

namespace Video_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();             
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPlay.Enabled = false;
            btnBack.Enabled = false;
            btnForward.Enabled = false;
            btnSubtitle.Enabled = false;
            btn_srt.Enabled = false;
            btnOK3.Enabled = false;
            btnCombine.Enabled = false;
        }

        /*---------自定义模板-----------*/

        //上传素材模板
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            odlgMedia.FileName = "";
            odlgMedia.InitialDirectory = "C:\\";
            odlgMedia.Filter = "所有文件|*.*|mp3文件|*.mp3|mp4文件|*.mp4";
            if (odlgMedia.ShowDialog() == DialogResult.OK)
            {
                string path = odlgMedia.FileName;
                FileInfo f = new FileInfo(path);
                VideoPlayer.AddFile(f.FullName);
                string strFile = f.Name;
                lstPlay.Items.Add(strFile);
                lstChoose.Items.Add(strFile);
            }
            if (lstPlay.Items.Count > 0)
            {
                btnPlay.Enabled = true;
                btnBack.Enabled = true;
                btnForward.Enabled = true;
            }
        }
     
        //删除上传模板
        private void btnDelete1_Click(object sender, EventArgs e)
        {
            int i = lstChoose.SelectedIndex;
            lstChoose.Items.RemoveAt(i);
        }
        
     
        //确认上传素材
        private  void btnOK_Click(object sender, EventArgs e)
        {
            if (rdbtn_video.Checked == true)
            {
                if (lstChoose.Items.Count > 1 || lstChoose.Items.Count == 0 || (lstChoose.Items[0].ToString().Contains(".mp3")))
                {
                    Console.WriteLine(lstChoose.Items.ToString());
                    MessageBox.Show("错误！只能添加一个视频文件");
                }
                else
                {
                    btnSubtitle.Enabled = true;
                    MessageBox.Show("确认添加");
                }
            }
            else if (rdbtn_both.Checked == true)
            {
                if (lstChoose.Items.Count != 2 ||
                  (lstChoose.Items[0].ToString().Contains(".mp4") && lstChoose.Items[1].ToString().Contains(".mp4"))
                   || (lstChoose.Items[0].ToString().Contains(".mp3") && lstChoose.Items[1].ToString().Contains(".mp3")))
                {
                   
                    MessageBox.Show("错误！只能添加一个音频文件和一个视频文件");
                }

                else
                {
                    btnSubtitle.Enabled = true;
                    MessageBox.Show("确认添加");
                }
            }
            else if (rd_template1.Checked == true)
            {
                btnSubtitle.Enabled = true;
                MessageBox.Show("确认添加");
            }
            else if (rd_template2.Checked == true)
            {
                btnSubtitle.Enabled = true;
                MessageBox.Show("确认添加");
            }
            else if (rd_template2.Checked == true)
            {
                btnSubtitle.Enabled = true;
                MessageBox.Show("确认添加");
            }
            else {
                MessageBox.Show("错误！请选择添加模式"); }
        }


        /*---------播放器----------*/
   
        //上传播放媒体
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            odlgMedia.FileName = "";
            odlgMedia.InitialDirectory = "C:\\";
            odlgMedia.Filter = "所有文件|*.*|mp3文件|*.mp3|mp4文件|*.mp4";
            if (odlgMedia.ShowDialog() == DialogResult.OK)
            {
                string path = odlgMedia.FileName;
                FileInfo f = new FileInfo(path);
                VideoPlayer.AddFile(f.FullName);
                string strFile = f.Name;
                lstPlay.Items.Add(strFile);
            }
            if (lstPlay.Items.Count > 0)
            {
                btnPlay.Enabled = true;
                btnBack.Enabled = true;
                btnForward.Enabled = true;
            }
        }

        //删除播放媒体
        private void btnDelete2_Click(object sender, EventArgs e)
        {
            int i = lstPlay.SelectedIndex;
            if (lstPlay.SelectedIndex >= 0)
            {
                if ((VideoPlayer.selectOne == lstPlay.SelectedIndex + 1) && (MediaPlayer.URL != ""))
                {
                    MessageBox.Show("不能删除正在播放的文件", "错误");
                }
                else
                {
                    VideoPlayer.DelFile(i + 1);
                    lstPlay.Items.RemoveAt(i);
                    if (i < lstPlay.Items.Count)
                    {
                        lstPlay.SelectedIndex = i;
                    }
                    else if (lstPlay.Items.Count == 0)
                    {
                        btnPlay.Enabled = false;
                        btnBack.Enabled = false;
                        btnForward.Enabled = false;
                    }
                    else
                    {
                        lstPlay.SelectedIndex = 0;
                    }
                }

            }
        }

        //播放
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (lstPlay.SelectedIndex < 0)
            {
                VideoPlayer.selectOne = 0;
                lstPlay.SelectedIndex = 0;
            }
            else
            {
                MediaPlayer.URL = VideoPlayer.fileList[lstPlay.SelectedIndex];
                this.Text = "正在播放 --" + lstPlay.SelectedIndex.ToString();
            }

            tmrMedia.Enabled = true;
            btnStop.Enabled = true;
            btnReplay.Enabled = true;
        }

        /*----------字幕------------*/

        //上传字幕文件
        private void btnSubtitle_Click(object sender, EventArgs e)
        {
            odlgMedia.FileName = "";
            odlgMedia.InitialDirectory = "C:\\";
            odlgMedia.Filter = "srt文件|*.srt|所有文件|*.*";
            if (odlgMedia.ShowDialog() == DialogResult.OK)
            {
                string path = odlgMedia.FileName;
                FileInfo f = new FileInfo(path);
                tB_srt.Text = f.FullName;
                btn_srt.Enabled = true;
            }           
       
        }

        //确认字幕
        private async void btn_srt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确认添加");
            btnOK3.Enabled = true;
            Choosepath();                                                                                                     
            trk_Start.Maximum = (int)await MediaOpt.MediaTime(OriginalPath.videoPath);       //根据视频设置视频滑动条最大值
            trk_Span.Maximum = (int)await MediaOpt.MediaTime(OriginalPath.videoPath);  
        }

        /*----------参数调节------------*/

        //音量调节
        private  void trkBar_bgm_Scroll(object sender, EventArgs e)
        {
         
            lb_vobgm.Text = trkBar_bgm.Value.ToString();
        }

        private void trkBar_people_Scroll(object sender, EventArgs e)
        {
            lbvolpeople.Text = trkBar_people.Value.ToString();
        }

        //视频参数

       
        private   void trk_Start_Scroll(object sender, EventArgs e)
        {
           
            lb_start.Text = trk_Start.Value.ToString();
        }
        private  void trk_Span_Scroll(object sender, EventArgs e)
        {
          
            lbSpan.Text = trk_Span.Value.ToString();
        }


        //确认
        private void btnOK3_Click(object sender, EventArgs e)
        {
            if (trk_Start.Value + trk_Span.Value > trk_Start.Maximum)
            {
                MessageBox.Show("超出最大时长");
                btnCombine.Enabled = false;
            }
            else
            {
                btnCombine.Enabled = true;
            }
        }


        /*---------开始合成---------*/

        //选择最初视频文件路径、背景乐文件路径
        public  void Choosepath()
        {
            //自定义模板
            if (rdbtn_both.Checked == true)
            {
                OriginalPath.GetPathFromBoth(lstChoose.Items[0].ToString(), lstChoose.Items[1].ToString());
            }
            else if (rdbtn_video.Checked == true)
            {
                string s = lstChoose.Items[0].ToString();
                string videoPath = VideoPlayer.fileList.Where(o => o.Contains(s)).FirstOrDefault();
                Console.WriteLine(videoPath);
                OriginalPath.videoPath = videoPath;
                OriginalPath.GetAudioPathFromvideo(videoPath);
            }
            //内置模板(还没有在 bin中加模板视频）
            else if (rd_template1.Checked == true)
            {
                string videoPath1 = "";
                OriginalPath.videoPath = videoPath1;
                OriginalPath.GetAudioPathFromvideo(videoPath1);
            }
            else if (rd_template2.Checked == true)
            {
                string videoPath2 = "";
                OriginalPath.videoPath = videoPath2;
                OriginalPath.GetAudioPathFromvideo(videoPath2);
            }
            else if (rd_template3.Checked == true)
            {
                string videoPath3 = "";
                OriginalPath.videoPath = videoPath3;
                OriginalPath.GetAudioPathFromvideo(videoPath3);
            }
            else
            {
                MessageBox.Show("请选择模板");
            }
        }

       

        private async void btnCombine_Click(object sender, EventArgs e)
        {
           //获取最初视频、背景乐文件路径
         //   Choosepath();

            //字幕合人声
            string vocalsPath = "X:\\Music\\MOM.mp3";      //随便搞个音乐实验


             //视频、背景乐剪裁
            string cutvideoPath = await  Split.SplitVideo(OriginalPath.videoPath, trk_Start.Value, trk_Span.Value);
            string cutbgmPath = await Split.SplitAudio(OriginalPath.audioPath, trk_Span.Value);      //音频都从0秒开始
            string  cutvocalsPath = await Split.SplitAudio(vocalsPath, trk_Span.Value);
           
          //  Console.WriteLine(OriginalPath.audioPath);
            //Console.WriteLine(cutbgmPath);

            //人声背景乐合成
            float bgmvolume = (float)(trkBar_bgm.Value * 0.01);
            float peoplevolume= (float)(trkBar_people.Value * 0.01);             
            string  mixedaudio=   Combine.mixmusic(bgmvolume, peoplevolume,cutbgmPath, cutvocalsPath);
             

                //视频音频合成                         
                 string mixedvideo = await Combine.addaudio(cutvideoPath, mixedaudio);


                //添加字幕
                string strPath = tB_srt.Text;
                string output = await Combine.Addsrt(mixedvideo,strPath);
                VideoPlayer.fileList.Add(output);           
                lstPlay.Items.Add(output);            //将生成路径添加到播放列表

            //  清除中间文件 ，都在用户temp文件夹
                File.Delete(cutvideoPath);  
                File.Delete(cutbgmPath);
                File.Delete(cutvocalsPath);
                File.Delete(mixedaudio);
                File.Delete(mixedvideo);
   
        }

      
    }
}

