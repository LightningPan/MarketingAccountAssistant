using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Video_generator
{
    class SubtitleOption
    {
        public static List<Subtitle> subtitles;
        public static List<Subtitle> ParseSubtitle(string SubtitlePath)
        {
            subtitles = new List<Subtitle>();
            string line;
            using (FileStream fs = new FileStream(SubtitlePath, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.Default))
                {
                    StringBuilder sb = new StringBuilder();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!line.Equals(""))
                        {
                            sb.Append(line).Append("@");
                            continue;
                        }
                        string[] parseSubs = sb.ToString().Split('@');
                        if (parseSubs.Length < 3)
                        {
                            sb.Remove(0, sb.Length);
                            continue;
                        }
                        Subtitle sub = new Subtitle();

                        sub.index = int.Parse(parseSubs[0]);
                        string subToTime = parseSubs[1];
                        int beginHour = int.Parse(subToTime.Substring(0, 2));
                        int beginMinute = int.Parse(subToTime.Substring(3, 2));
                        int beginSecond = int.Parse(subToTime.Substring(6, 2));
                        int beginMilli = int.Parse(subToTime.Substring(9, 3));
                        int beginTime = ((beginHour * 3600 + beginMinute * 60 + beginSecond) * 1000 + beginMilli);

                        int endHour = int.Parse(subToTime.Substring(17, 2));
                        int endMinute = int.Parse(subToTime.Substring(20, 2));
                        int endSecond = int.Parse(subToTime.Substring(23, 2));
                        int endMilli = int.Parse(subToTime.Substring(26, 3));
                        int endTime = ((endHour * 3600 + endMinute * 60 + endSecond) * 1000 + endMilli);
                        sub.BeginTime = beginTime;
                        sub.EndTime = endTime;
                        string strContent = null;
                        for (int i = 2; i < parseSubs.Length; i++)
                        {
                            strContent += parseSubs[i];
                        }
                        sub.Content = strContent;
                        subtitles.Add(sub);
                        sb.Remove(0, sb.Length);
                    }
                }
            }
            subtitles.Sort();
            return subtitles;
        }

        public static string GetTimeString(int time)
        {
            string currentTimeText = "";
            if (subtitles != null)
            {
                foreach (Subtitle sub in subtitles)
                {
                    if (time > sub.BeginTime && time < sub.EndTime)
                    {
                        currentTimeText = sub.Content;
                        break;
                    }
                }
            }
            return currentTimeText;
        }

        public static string GetFrameString(int fps, int i)
        {  //fps指视频帧数，i指第i帧
            string curentFrameText = "";
            if (subtitles != null)
            {
                foreach (Subtitle sub in subtitles)
                {
                    if (i < sub.getEndFpsNum(fps) && i > sub.getBeginFpsNum(fps))
                    {
                        curentFrameText = sub.Content;
                        break;
                    }
                }
            }
            return curentFrameText;
        }
    }
}
