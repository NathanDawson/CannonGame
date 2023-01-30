using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Tech_Exc_Project_2.UnitTests
{
    [TestClass]
    public class TargetJudgeTests
    {
        [TestMethod]
        public void HitOrNot_Hit_ReturnTrue()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("35");
            MockInput.Setup(x => x.GetVelocity()).Returns("15");

            var MockOutput = new Mock<ITargetGenerator>();
            MockOutput.Setup(x => x.GetXCoOrdinates()).Returns(12);
            MockOutput.Setup(x => x.GetYCoOrdinates()).Returns(9);

            var validator = new InputValidator(MockInput.Object);
            var shotCalculator = new ShotCalculator(validator);
            var targetGenerator = new TargetGenerator();
            var targetJudge = new TargetJudge(MockOutput.Object, shotCalculator);

            var result = targetJudge.HitOrNot(35, 15);

            Assert.AreEqual(ITargetJudge.Status.Hit, result);
        }

        [TestMethod]
        public void HitOrNot_Miss_ReturnFalse()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("25");
            MockInput.Setup(x => x.GetVelocity()).Returns("15");

            var MockOutput = new Mock<ITargetGenerator>();
            MockOutput.Setup(x => x.GetXCoOrdinates()).Returns(12);
            MockOutput.Setup(x => x.GetYCoOrdinates()).Returns(9);

            var validator = new InputValidator(MockInput.Object);
            var shotCalculator = new ShotCalculator(validator);
            var targetGenerator = new TargetGenerator();
            var targetJudge = new TargetJudge(MockOutput.Object, shotCalculator);

            var result = targetJudge.HitOrNot(25, 15);

            Assert.AreEqual(ITargetJudge.Status.Miss, result);
        }
    }
}
