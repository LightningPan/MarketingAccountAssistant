using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xabe.FFmpeg;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Resources;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Windows.Forms;
using System.Drawing;

namespace Video_generator
{
    class Merge
    {

        public delegate void progressDelegate(int i);
        public static progressDelegate progressdelegate;

        public delegate void progressState(string a);
        public static  progressState progressstate;
        public static void MergeAll(Info info) {
         
            progressstate("正在合成音频");
            if (!File.Exists(info.mixed))
            {
                MixBgmAndSpeech(info);
            }
            progressstate("正在合成字幕");
            MergeSubtitle(info);
            progressstate("正在生成视频");
            Addaudio(info);
            progressstate("成功");
        }



        public static void MergeSubtitle(Info info)
        {
            string output = info.videoTemp;
            System.Drawing.Point point = new Point(info.X,info.Y);
            FontFace fontface = info.fontFace;
            double fontscale = info.scale;
            MCvScalar color = new Bgr(info.B, info.G, info.R).MCvScalar;
            int thickness = info.thickness;
            LineType lineType = info.lineType;
            bool bottomLeftOrigin = false;



            VideoCapture cap = new VideoCapture(info.VideoPath);
            if (!cap.IsOpened)
            {
                MessageBox.Show("打开视频失败");
            }
            int fps = (int)cap.GetCaptureProperty(CapProp.Fps);
            int width = (int)cap.GetCaptureProperty(CapProp.FrameWidth);
            int height = (int)cap.GetCaptureProperty(CapProp.FrameHeight);
            int frameNum = (int)cap.GetCaptureProperty(CapProp.FrameCount);
            VideoWriter writer = new VideoWriter(output, 0x7634706d, 24, new System.Drawing.Size(width, height), true);
            Mat mat = new Mat();
            int i = 0;
            while (i<frameNum)
            {
                cap.SetCaptureProperty(CapProp.PosFrames,i);
                cap.Read(mat);
                if (mat.IsEmpty)
                {
                    break;
                }
                string text;
                if ((text = SubtitleOption.GetFrameString(fps, i)) != "")
                {
                   
                    CvInvoke.PutText(mat, text, point, fontface, fontscale, color, thickness, lineType, bottomLeftOrigin);
                }
                writer.Write(mat);
                i++;
                progressdelegate(i*100/frameNum);
            }
        }


        //获取视频时长


        //音视频合成
        public static async void Addaudio(Info info)
        {
            string output = info.output;
            string videoPath = info.videoTemp;
            string audioPath = info.mixed;
            //output = Path.ChangeExtension(, ".mp4");
            var conversion=await FFmpeg.Conversions.FromSnippet.AddAudio(videoPath, audioPath, output+".mp4");
            //await Conversion.AddAudio(videoPath, audioPath, outputPath).Start();
            IConversionResult result = await conversion.Start();
            //return (output);
        }

        //添加字幕
        //public static async Task<string> Addsrt(string videoPath, string srtPath)
        //{

        //    string outputPath = Path.ChangeExtension(Path.GetTempFileName(), ".mp4");
        //    IConversion conversion = await FFmpeg.Conversions.FromSnippet.AddSubtitle(videoPath,outputPath,srtPath);
        //    //await Conversion.AddSubtitles(videoPath, outputPath, srtPath).Start();
        //    IConversionResult result = await conversion.Start();
        //    return outputPath;
        //}

        //音频混合
        static public void MixBgmAndSpeech(Info info)
        {
            float bgmVolume = info.BgmVolume;
            float speechVolume = info.PersonVolume;
            string bgmFilePath = info.AudioPath;
            string speechFilePath = info.speechTemp;
            string tempPath1 = Path.ChangeExtension(Path.GetTempFileName(), ".wav");
            string tempPath2 = Path.ChangeExtension(Path.GetTempFileName(), ".wav");
            //string outputFilePath = Path.ChangeExtension(Path.GetTempFileName(), ".wav");
            string audio1FilePath = tempPath1;
            string audio2FilePath = tempPath2;
            using (var bgmReader = new AudioFileReader(bgmFilePath))
            using (var speechReader = new AudioFileReader(speechFilePath)) {

                using (var resampler = new MediaFoundationResampler(speechReader, bgmReader.WaveFormat)) {
                    WaveFileWriter.CreateWaveFile(audio2FilePath,resampler);
                    audio1FilePath = bgmFilePath;
                }

            }

            //混音
            using (var reader1 = new AudioFileReader(audio1FilePath))
            using (var reader2 = new AudioFileReader(audio2FilePath))
            {
                reader1.Volume = bgmVolume;
                reader2.Volume = speechVolume;
                var mixer = new MixingSampleProvider(new[] { reader1, reader2 });
                WaveFileWriter.CreateWaveFile16(info.mixed, mixer);
                
            }

            //删除临时文件
            if (File.Exists(tempPath1)) File.Delete(tempPath1);
            if (File.Exists(tempPath2)) File.Delete(tempPath2);
            
        }

     


    }
}