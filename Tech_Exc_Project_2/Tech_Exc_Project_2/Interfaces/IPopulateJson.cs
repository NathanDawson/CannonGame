using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
    public interface IPopulateJson
    {
        void UpdateJson(string PlayerName, int Score, int TotalTime);

        void PrintJson();


    }
}
