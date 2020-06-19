using Emgu.CV.CvEnum;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using Xabe.FFmpeg;

namespace Video_generator
{
    class Info
    {
        public string VideoPath { get; set; }
        public string AudioPath { get; set; }
        public string SubtitlePath { get; set; }
        public List<Subtitle> subtitles { get; set; }
        public float BgmVolume { get; set; }
        public float PersonVolume { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int BeginTime { get; set; }
        public int EndTime { get; set; }
        public int thickness { get; set; }
        public double scale { get; set; }
        public FontFace fontFace { get; set; }
        public LineType lineType { get; set; }

        public string output { get; set; }
        public int height { get;  set; }
        public int width { get; set; }

        public Bitmap bmp;


        public string bgmTemp = "bgm.wav";
        public string cutVideo = "cutVideo.mp4";
        public string cutAudio = "cutAudio.wav";
        public string speechTemp = "temp.wav";
        public string videoTemp = "temp.avi";
        public string mixed = "mixed.wav";

        public static async Task<double> GetMediaTime(string mediaPath)
        {

            IMediaInfo Info = await FFmpeg.GetMediaInfo(mediaPath);
            return Info.Duration.TotalSeconds;
        }
        public Info(int Width,int Height)
        {

            bmp = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.Black, new Rectangle(0, 0, Width, Height));
        }
    }
}
