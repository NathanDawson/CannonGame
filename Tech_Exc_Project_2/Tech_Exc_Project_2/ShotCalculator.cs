﻿using System;
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

        public int Degrees()
        {
            int angle = _validator.ParseAngle();
            _validator.CheckAngleRange();

            return (int) Math.Round(angle * (Math.PI / 180), MidpointRounding.AwayFromZero);
        }

        public int xCoOrdinate()
        {
            int velocity = _validator.ParseVelocity();
            _validator.CheckVelocityRange();

            int angle = _validator.ParseAngle();

            return (int)Math.Round(Math.Cos(angle * (Math.PI / 180)) * velocity, MidpointRounding.AwayFromZero);
        }

        public int yCoOrdinate()
        {
            int velocity = _validator.ParseVelocity();
            _validator.CheckVelocityRange();

            int angle = _validator.ParseAngle();

            return (int)Math.Round(Math.Sin(angle * (Math.PI / 180)) * velocity, MidpointRounding.AwayFromZero);
        }
    }
}