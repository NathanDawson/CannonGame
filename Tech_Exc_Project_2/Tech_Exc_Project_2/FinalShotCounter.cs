using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
    public class FinalShotCounter : IFinalShotCounter
    {
        private int count;

        public void SetCounter()
        { 
            count++;
        }

        public int GetCounter()
        {
            return count;
        }
    }
}
