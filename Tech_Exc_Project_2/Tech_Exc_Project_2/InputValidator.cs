using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
    public class InputValidator : IInputValidator
    {
        private ICommandLine _command;

        public InputValidator(ICommandLine command)
        {
            _command = command;
        }

        public int ParseAngle()
        {
            try
            {
                return int.Parse(_command.GetAngle());
            }
            catch (FormatException)
            {

                throw new FormatException("Please enter a whole number between 1 and 90");
            }
        }

        public int ParseVelocity()
        {
            try
            {
                return int.Parse(_command.GetVelocity());
            }
            catch (FormatException)
            {
                throw new FormatException("Please enter a whole number between 1 and 90");
            }
        }

        public int ParseShotSelection()
        {
            try
            {
                return int.Parse(_command.GetShotSelection());
            }
            catch (FormatException)
            {
                throw new FormatException("Please enter 1 for Cannon or 2 for Mortor");
            }
        }

        public bool MortorOrNot()
        {
            if (_command.GetShotSelection() == "1")
            {
                return false;
            }
            else if (_command.GetShotSelection() == "2")
            {
                return true;
            }
            else
            {
                throw new Exception("Please enter 1 for Cannon or 2 for Mortor");
            }
        }

        public void EnforceMortorAngle()
        {
            if (MortorOrNot() && ParseAngle() % 5 != 0)
            {
                throw new FormatException("Please enter an angle that is divisible by 5");
            }
        }

        public void CheckAngleRange()
        {
            if (int.Parse(_command.GetAngle()) < 1 || int.Parse(_command.GetAngle()) > 90)
            { 
                throw new ArgumentOutOfRangeException("Please enter a whole number between 1 and 90");
            }
        }

        public void CheckVelocityRange()
        {
            if (int.Parse(_command.GetVelocity()) < 1 || int.Parse(_command.GetVelocity()) > 20)
            {
                throw new ArgumentOutOfRangeException("Please enter a whole number between 1 and 20");
            }
        }
    }
}
