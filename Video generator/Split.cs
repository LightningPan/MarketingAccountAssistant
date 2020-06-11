using System;
using System.IO;
using System.Threading.Tasks;
using Xabe.FFmpeg;

namespace Video_generator
{
    class Split
    {
        //拆分音频文件
        public static async void SplitAudio(Info info)
        {
            double start = info.BeginTime;
            double span = info.EndTime - info.BeginTime;
            if (File.Exists(info.cutAudio))
            {
                System.IO.File.Delete(info.cutAudio);
            }
            IConversion conversion = await FFmpeg.Conversions.FromSnippet.Split(info.bgmTemp,info.cutAudio, TimeSpan.FromSeconds(start), TimeSpan.FromSeconds(span));
            IConversionResult result = await conversion.Start();
      

        }

        //拆分视频文件
        public static async void SplitVideo(Info info)
        {
            string videoPath = info.VideoPath;
            double start = info.BeginTime;
            double span = info.EndTime - info.BeginTime;
            string output = info.cutVideo;
            if (File.Exists(output))
            {
                System.IO.File.Delete(output);
            }
            IConversion conversion = await FFmpeg.Conversions.FromSnippet.Split(videoPath, output, TimeSpan.FromSeconds(start), TimeSpan.FromSeconds(start + span));
            IConversionResult result = await conversion.Start();
        }

        //从视频中提取音频文件
        public static async void ExtractAudio(Info info)
        {
          
            IConversion conversion = await FFmpeg.Conversions.FromSnippet.ExtractAudio(info.VideoPath, info.bgmTemp);
            if (File.Exists(info.bgmTemp)) {
                System.IO.File.Delete(info.bgmTemp);
            }
            IConversionResult result = await conversion.Start();
        }



    }
}
