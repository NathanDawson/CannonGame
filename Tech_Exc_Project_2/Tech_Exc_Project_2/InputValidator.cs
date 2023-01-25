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
