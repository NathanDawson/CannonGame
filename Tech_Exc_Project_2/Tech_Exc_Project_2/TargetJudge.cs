using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static Tech_Exc_Project_2.ITargetJudge;

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

        public Status HitOrNot(int angle, int velocity, bool MortorOrNot)
        {
            if (!MortorOrNot)
            {
                return (_targetGenerator.GetXCoOrdinates() == _shotCalculator.xCoOrdinate(angle, velocity)) && (_targetGenerator.GetYCoOrdinates() == _shotCalculator.yCoOrdinate(angle, velocity)) ? Status.Hit : Status.Miss;
            } else
            {
                return (_targetGenerator.GetXCoOrdinates() == _shotCalculator.xCoOrdinate(angle, velocity)) && (_targetGenerator.GetYCoOrdinates() == _shotCalculator.yCoOrdinate(angle, velocity)) ? Status.Hit 
                : (_targetGenerator.GetXCoOrdinates() == _shotCalculator.xCoOrdinate(angle, velocity) - 1) && (_targetGenerator.GetYCoOrdinates() == _shotCalculator.yCoOrdinate(angle, velocity) - 1) ? Status.Hit
                : (_targetGenerator.GetXCoOrdinates() == _shotCalculator.xCoOrdinate(angle, velocity) - 1) && (_targetGenerator.GetYCoOrdinates() == _shotCalculator.yCoOrdinate(angle, velocity)) ? Status.Hit
                : (_targetGenerator.GetXCoOrdinates() == _shotCalculator.xCoOrdinate(angle, velocity)) && (_targetGenerator.GetYCoOrdinates() == _shotCalculator.yCoOrdinate(angle, velocity) - 1) ? Status.Hit
                : Status.Miss;
            }
        }
    }
}
