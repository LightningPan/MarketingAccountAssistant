using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_generator
{
    class VideoPlayer
    {
        public static List<string> fileList = new List<string>();                   //记录文件的路径
        public static int numOfMusic = 0;                                                   //播放列表总数
        public static int selectOne;                                                              //选中播放的音视频
        public static bool playOne = false;                                                 //循环播放


        //添加音频文件添加到list
        public static void AddFile(string path)                                 
        {
            if (numOfMusic < 10000)
            {
                numOfMusic += 1;
                Console.WriteLine(numOfMusic);
                fileList.Add(path);
            }
            else
            {
                MessageBox.Show("can't add file,full");
            }
        }

        //删除音频文件
        public static void DelFile(int selcetNum)                                  
        {
            fileList.RemoveAt(selcetNum);
            numOfMusic -= 1;
        }
    }
}
