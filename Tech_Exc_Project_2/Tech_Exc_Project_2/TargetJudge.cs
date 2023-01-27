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

        public bool HitOrNot(int angle, int velocity)
        {
            return (_targetGenerator.GetXCoOrdinates() == _shotCalculator.xCoOrdinate(angle, velocity)) && (_targetGenerator.GetYCoOrdinates() == _shotCalculator.yCoOrdinate(angle, velocity));
        }
    }
}
