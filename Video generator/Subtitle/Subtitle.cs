using System;

namespace Video_generator
{
    class Subtitle : IComparable<Subtitle>
    {
        public int BeginTime { get; set; }      //微秒
        public int EndTime { get; set; }
        public string Content { get; set; }
        public int index { get; set; }

        public int CompareTo(Subtitle other)
        {
            return this.BeginTime.CompareTo(other.BeginTime);
        }

        public int getBeginFpsNum(int fps)
        {
            return fps * BeginTime / 1000;
        }

        public int getEndFpsNum(int fps)
        {
            return fps * EndTime / 1000;
        }
    }
}
