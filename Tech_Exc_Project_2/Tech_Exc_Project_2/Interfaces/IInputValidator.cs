using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
    public interface IInputValidator
    {
        int ParseAngle();
        int ParseVelocity();
        void CheckAngleRange();
        void CheckVelocityRange();
        int ParseShotSelection();
        bool MortorOrNot();
        void EnforceMortorAngle();
    }
}
