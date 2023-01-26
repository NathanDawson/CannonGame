using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
    public class ShotCalculator : IShotCalculator
    {
        private IInputValidator _validator;

        public ShotCalculator(IInputValidator validator)
        {
            _validator = validator;
        }

        public int xCoOrdinate()
        {
            int angle = _validator.ParseAngle();
            _validator.CheckAngleRange();

            int velocity = _validator.ParseVelocity();
            _validator.CheckVelocityRange();

            return (int) Math.Round(Math.Cos(angle * (Math.PI / 180)) * velocity, MidpointRounding.AwayFromZero);
        }

        public int yCoOrdinate()
        {
            int angle = _validator.ParseAngle();
            _validator.CheckAngleRange();

            int velocity = _validator.ParseVelocity();
            _validator.CheckVelocityRange();

            return (int) Math.Round(Math.Sin(angle * (Math.PI / 180)) * velocity, MidpointRounding.AwayFromZero);
        }
    }
}
