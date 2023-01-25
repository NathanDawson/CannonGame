using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
    public class TargetJudge : ITargetJudge
    {
        private ITargetGenerator _targetGenerator;
        private IShotCalculator _shotCalculator;

        public TargetJudge(ITargetGenerator targetGenerator, IShotCalculator shotCalculator) 
        {
            _targetGenerator = targetGenerator;
            _shotCalculator = shotCalculator;
        }

        public bool HitOrNot()
        {
            return (_targetGenerator.GetXCoOrdinates() == _shotCalculator.xCoOrdinate()) && (_targetGenerator.GetYCoOrdinates() == _shotCalculator.yCoOrdinate());
        }
    }
}
