using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tech_Exc_Project_2;

namespace Tech_Exc_Project_2
{
    public class TimeTracker : ITimeTracker
    {
        private int time;
        private Stopwatch StopWatch;

        public TimeTracker() 
        {
            this.time = 0;
            StopWatch = new Stopwatch();
        }

        public void StartTimer()
        {
            StopWatch.Start();
        }

        public void StopTimer()
        {
            StopWatch.Stop();
            time = (int)StopWatch.ElapsedMilliseconds / 1000;
        }

        public int GetTime()
        {
            return time;
        }
    }
}
