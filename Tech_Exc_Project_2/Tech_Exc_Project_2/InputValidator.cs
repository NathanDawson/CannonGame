using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
    public class InputValidator : IInputValidator
    {
        public int ParseAngle(string angle)
        {
            try
            {
                return int.Parse(angle);
            }
            catch (FormatException)
            {

                throw new FormatException("Please enter a whole number between 1 and 90");
            }
        }

        public int ParseVelocity(string velocity)
        {
            try
            {
                return int.Parse(velocity);
            }
            catch (FormatException)
            {
                throw new FormatException("Please enter a whole number between 1 and 90");
            }
        }

        public int ParseShotSelection(string shotType)
        {
            try
            {
                return int.Parse(shotType);
            }
            catch (FormatException)
            {
                throw new FormatException("Please enter 1 for Cannon or 2 for Mortor");
            }
        }

        public bool MortorOrNot(string shotType)
        {
            if (shotType == "1")
            {
                return false;
            }
            else if (shotType == "2")
            {
                return true;
            }
            else
            {
                throw new Exception("Please enter 1 for Cannon or 2 for Mortor");
            }
        }

        public void EnforceMortorAngle(string angle, string shotType)
        {
            if (MortorOrNot(shotType) && ParseAngle(angle) % 5 != 0)
            {
                throw new FormatException("Please enter an angle that is divisible by 5");
            }
        }

        public void CheckAngleRange(string angle)
        {
            if (int.Parse(angle) < 1 || int.Parse(angle) > 90)
            { 
                throw new ArgumentOutOfRangeException("Please enter a whole number between 1 and 90");
            }
        }

        public void CheckVelocityRange(string velocity)
        {
            if (int.Parse(velocity) < 1 || int.Parse(velocity) > 20)
            {
                throw new ArgumentOutOfRangeException("Please enter a whole number between 1 and 20");
            }
        }
    }
}
