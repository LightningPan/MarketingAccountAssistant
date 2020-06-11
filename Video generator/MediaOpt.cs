using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xabe.FFmpeg;

namespace Video_generator
{
    class MediaOpt
    {
        //获取视频时长
        public static async Task<double> MediaTime(string mediaPath)
        {
            IMediaInfo Info = await MediaInfo.Get (mediaPath);
            Console.WriteLine(Info.Duration.TotalSeconds);
            return Info.Duration.TotalSeconds;
        }

        /*------------??????----------------*/
        //显示音频采样率
        public static int   showSampleRete(string inPath)
        {
            var reader1 = new AudioFileReader(inPath);
            return reader1.WaveFormat.SampleRate;
        }

        //改变音频采样率
        public static string change(string inFile)
        {
            int outRate = 44100;         //44.1kHz
            string outFile = Path.ChangeExtension(Path.GetTempFileName(), ".mp3");
            using (var reader = new AudioFileReader(inFile))
            {
                var resampler = new WdlResamplingSampleProvider(reader, outRate);
                WaveFileWriter.CreateWaveFile16(outFile, resampler);
            }
            return outFile;
        }

    }
}
