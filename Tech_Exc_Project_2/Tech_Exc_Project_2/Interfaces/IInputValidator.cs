using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
    public interface IInputValidator
    {
        int ParseAngle(string angle);
        int ParseVelocity(string velocity);
        void CheckAngleRange(string angle);
        void CheckVelocityRange(string velocity);
        int ParseShotSelection(string shotType);
        bool MortorOrNot(string shotType);
        void EnforceMortorAngle(string angle, string shotType);
    }
}
