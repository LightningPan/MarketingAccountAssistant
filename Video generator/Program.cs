using System;
using System.Windows.Forms;

namespace Video_generator
{
    static class Programa
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VideoHelper());
            //string fileName = "<speak version=\"1.0\" ";
            ////fileName += "xmlns=\"http://www.w3.org/2001/10/synthesis\" ";
            //fileName += "xml:lang=\"zh-CN\">";
            //fileName += "Say a name for the new file ";
            //fileName += "<break time=\"50000ms\"/>";
            //fileName += "你好<mark name=\"fileName\" />.";
            //fileName += "</speak>";
            //Speech.CreateSpeechFile(fileName, "C:/Users/tp103/Desktop/a.wav"); 
            //await Split.extractaudio("C:/Users/tp103/Desktop/test.mp4");


        }
    }
}
