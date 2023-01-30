using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
     public interface ITimeTracker
    {
        void StartTimer();
        void StopTimer();
        int GetTime();

    }
}
