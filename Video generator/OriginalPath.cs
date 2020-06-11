using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_generator
{
    class OriginalPath
    {
        public static string videoPath { get; set; }
        public static string audioPath { get; set; }


        //从用户上传的音频文件、视频文件中获取
        public static void GetPathFromBoth(string s1,string s2)
        {
            string videoname;
            string bgmname;
            
            if (s1.Contains(".mp4"))
            {
                videoname = s1;
                bgmname = s2;
            }
            else
            {
                videoname = s2;
                bgmname = s1;
            }
              videoPath = VideoPlayer.fileList.Where(o => o.Contains(videoname)).FirstOrDefault();
              audioPath = VideoPlayer.fileList.Where(o => o.Contains(bgmname)).FirstOrDefault();
        }

        //从单个视频文件中获取音频
        public static async void GetAudioPathFromvideo(string videopath)
        {
            string audiopath = await Split.extractaudio(videopath);
            audioPath = audiopath;
            Console.WriteLine(audiopath);
           // Console.WriteLine(videopath);

        }
    }
}
