﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tech_Exc_Project_2
{
    public class Flow : IFlow
    {
        private readonly ICommandLine _command;
        private readonly IInputValidator _validator;
        private readonly IShotCalculator _shotCalculator;
        private readonly ITargetGenerator _targetGenerator;
        private readonly ITargetJudge _targetJudge;
        private readonly IFinalShotCounter _finalShotCounter;
        private readonly ITimeTracker _timeTracker;
        private readonly IPopulateJson _populateJson;
        private readonly IUserData _userData;

        public Flow(ICommandLine command, IInputValidator validator, IShotCalculator shotCalc, ITargetGenerator targetGenerator, ITargetJudge targetJudge, IFinalShotCounter finalShotCounter,
            ITimeTracker timeTracker, IPopulateJson populateJson, IUserData userData)
        {
            this._command = command;
            this._validator = validator;
            this._shotCalculator = shotCalc;
            this._targetGenerator = targetGenerator;
            this._targetJudge = targetJudge;
            this._finalShotCounter = finalShotCounter;
            this._timeTracker = timeTracker;
            this._populateJson = populateJson;
            this._userData = userData;
        }

        public void Run()
        {
            _targetGenerator.SetXCoOrdinates();
            _targetGenerator.SetYCoOrdinates();

            _userData.SetPlayerName();

            _timeTracker.StartTimer();

            Console.WriteLine("Your target can be found at: ");
            Console.WriteLine("X: {0}", _targetGenerator.GetXCoOrdinates());
            Console.WriteLine("Y: {0}", _targetGenerator.GetYCoOrdinates());

            bool loop = true;
            while (loop)
            {
                _command.SetAngle();
                _command.SetVelocity();

                int angle = _validator.ParseAngle();
                _validator.CheckAngleRange();

                int velocity = _validator.ParseVelocity();
                _validator.CheckVelocityRange();

                _finalShotCounter.SetCounter();

                if (_targetJudge.HitOrNot(angle, velocity) == ITargetJudge.Status.Hit)
                {
                    Console.WriteLine("Well done.You hit the target after {0} attempts", _finalShotCounter.GetCounter());
                    loop = false;
                    break;
                }
                else
                {
                    Console.WriteLine("You did not hit the target. Your shot landed at: ");
                    Console.WriteLine("X: {0}", _shotCalculator.xCoOrdinate(angle, velocity));
                    Console.WriteLine("Y: {0}", _shotCalculator.yCoOrdinate(angle, velocity) + Environment.NewLine);
                    continue;
                }
            }

            _timeTracker.StopTimer();
            
            _populateJson.UpdateJson(_userData.GetPlayerName(), _finalShotCounter.GetCounter(), _timeTracker.GetTime());

            _populateJson.PrintJson();
        }
    }
}
