using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
    public class TargetGenerator : ITargetGenerator
    {
        Random r = new Random();

        private int XCoOrds;
        private int YCoOrds;
        
        public void SetXCoOrdinates()
        {
            //XCoOrds = r.Next(10);
            XCoOrds = 0;
        }
        public int GetXCoOrdinates()
        {
            return XCoOrds;
        }

        public void SetYCoOrdinates()
        {
            //YCoOrds = r.Next(10);
            YCoOrds = 3;
        }

        public int GetYCoOrdinates()
        { 
            return YCoOrds;
        }
    }
}
