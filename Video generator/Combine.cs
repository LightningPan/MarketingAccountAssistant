using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xabe.FFmpeg;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using Xabe.FFmpeg.Streams;
using System.Resources;

namespace Video_generator
{
    class Combine
    {

        //音视频合成
        public static async Task<string > addaudio(string videoPath, string audioPath)
        {
            string outputPath = Path.ChangeExtension(Path.GetTempFileName(), ".mp4");
            await Conversion.AddAudio(videoPath, audioPath, outputPath).Start();
            return (outputPath);
        }

        //音频混合
        public static  string mixmusic(float  bgmvolume,float  peoplevolum, string bgmPath,string vocalsPath)
        {
            using (var reader1 = new AudioFileReader(bgmPath))
            using (var reader2 = new AudioFileReader(vocalsPath))
            {
                string outputPath = Path.ChangeExtension(Path.GetTempFileName(), ".mp3");
                reader1.Volume = bgmvolume;
                reader2.Volume = peoplevolum;
                var mixer = new MixingSampleProvider(new[] { reader1, reader2 });
                WaveFileWriter.CreateWaveFile16(outputPath, mixer);
                return outputPath;
            }
        }
        
     

        //添加字幕
        public static async Task<string> Addsrt(string videoPath,string srtPath)
        {
           
            string outputPath = Path.ChangeExtension(Path.GetTempFileName(), ".mp4");
            await Conversion.AddSubtitles(videoPath, outputPath, srtPath).Start();
            return outputPath;
        }
    }
}
