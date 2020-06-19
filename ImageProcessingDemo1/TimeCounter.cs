using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ImageProcessingDemo1
{
    class TimeCounter
    {
        private static long startCount = 0;
        private static long elapsedCount = 0;
        #region Properties
        public static float Seconds
        {
            get
            {
                long freq = 0;
                float retValue = 0.0f;
                QueryPerformanceFrequency(ref freq);
                if (freq != 0)
                {
                    retValue = (float)elapsedCount / (float)freq;
                }
                return retValue;
            }
        }
        #endregion
        #region Methods
        public static void Start()
        {
            startCount = 0;
            QueryPerformanceCounter(ref startCount);
        }
        public static void Stop()
        {
            long stopCount = 0;
            QueryPerformanceCounter(ref stopCount);
            elapsedCount = (stopCount - startCount);
        }
        #endregion
        #region Import API
        [DllImport("kernel32.dll")]
        private static extern bool QueryPerformanceCounter(
            ref long lpPerformanceCount);
        [DllImport("kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(
            ref long lpFrequency);

        #endregion
    }
}
