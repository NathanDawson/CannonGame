﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
    public class Flow : IFlow
    {
        private readonly ICommandLine _command;
        private readonly ITargetGenerator _targetGenerator;
        private readonly ITargetJudge _targetJudge;
        private readonly IFinalShotCounter _finalShotCounter;

        public Flow(ICommandLine command, ITargetGenerator targetGenerator, ITargetJudge targetJudge, IFinalShotCounter finalShotCounter)
        {
            this._command = command;
            this._targetGenerator = targetGenerator;
            this._targetJudge = targetJudge;
            this._finalShotCounter = finalShotCounter;
        }

        public void Run()
        {
            _targetGenerator.SetXCoOrdinates();
            _targetGenerator.SetYCoOrdinates();

            bool loop = true;
            while (loop)
            {
                _command.SetAngle();
                _command.SetVelocity();

                _finalShotCounter.SetCounter();

                if (_targetJudge.HitOrNot())
                {
                    Console.WriteLine("Well done.You hit the target after {0} attempts", _finalShotCounter.GetCounter());
                    loop = false;
                    break;
                }
                else
                {
                    Console.WriteLine("You did not hit the target. Please try again.");
                    continue;
                }
            }
        }
    }
}