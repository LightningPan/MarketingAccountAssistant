using System.Collections.Generic;
using System.IO;
using System.Speech.Synthesis;

namespace Video_generator
{
    class TTS
    {
        //由文案生成语音文件

        public static string SubtitleToXml(List<Subtitle> subtitles)
        {
            string temp = "<speak version=\"1.0\" xml:lang=\"en-US\">";
            int time = 0;
            foreach (Subtitle subtitle in subtitles)
            {
                int ptime = subtitle.BeginTime - time;
                temp += "<break time=\"" + ptime + "ms\"/>";
                temp += subtitle.Content;
                time = subtitle.EndTime;
            }
            temp += "</speak>";
            return temp;

        }
        static public void CreateSpeechFile(string text, string speechFilePath)
        {
            using (SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer())
            {
                speechSynthesizer.SetOutputToWaveFile(speechFilePath);
                Prompt a = new Prompt(text, SynthesisTextFormat.Ssml);
                speechSynthesizer.Speak(a);
            }
        }
        static public string GetSpeechText(string theme, string templatePath)
        {
            string speechText = "";
            string[] lines = File.ReadAllLines(templatePath);
            foreach (string line in lines)
            {
                speechText += line;
            }
            return speechText.Replace("*", theme);
        }

        //由主题生成文案
        static public string getSpeechText(string theme, string templatePath)
        {
            string speechText = "";
            string[] lines = File.ReadAllLines(templatePath);
            foreach (string line in lines)
            {
                speechText += line;
            }
            return speechText.Replace("*", theme);
        }

    }
}
