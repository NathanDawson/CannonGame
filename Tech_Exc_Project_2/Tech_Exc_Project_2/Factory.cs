﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
    public class Factory : IFactory
    {
        public IFlow GetFlow()
        {
            ICommandLine _command = new CommandLine();
            IInputValidator _validator = new InputValidator(_command);
            IShotCalculator _shotCalculator = new ShotCalculator(_validator);
            ITargetGenerator _targetGenerator = new TargetGenerator();
            ITargetJudge _targetJudge = new TargetJudge(_targetGenerator, _shotCalculator);
            IFinalShotCounter _finalShotCounter = new FinalShotCounter();
            IFlow _flow = new Flow(_command, _targetGenerator, _targetJudge, _finalShotCounter);

            return _flow;
        }
    }
}
