using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
    public class Generator
    {
        public static void Main(string[] args)
        { 
            new Factory().GetFlow().Run();
        }
    }
}
