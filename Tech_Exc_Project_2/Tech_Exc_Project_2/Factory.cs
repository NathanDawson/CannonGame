using System;
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
            IInputValidator _validator = new InputValidator();
            IShotCalculator _shotCalculator = new ShotCalculator();
            ITargetGenerator _targetGenerator = new TargetGenerator();
            ITargetJudge _targetJudge = new TargetJudge(_targetGenerator, _shotCalculator);
            IFinalShotCounter _finalShotCounter = new FinalShotCounter();
            ITimeTracker _timeTracker = new TimeTracker();
            IPopulateJson _populateJson = new PopulateJson();
            IFlow _flow = new Flow(_command, _validator, _shotCalculator, _targetGenerator, _targetJudge, _finalShotCounter, _timeTracker, _populateJson);

            return _flow;
        }
    }
}
