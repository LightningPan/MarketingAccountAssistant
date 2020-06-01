using Emgu.CV.CvEnum;
using System.Collections.Generic;
using System.ComponentModel;
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
    }
}
