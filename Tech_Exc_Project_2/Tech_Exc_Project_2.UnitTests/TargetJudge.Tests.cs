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
            var MockOutput = new Mock<ITargetGenerator>();
            MockOutput.Setup(x => x.GetXCoOrdinates()).Returns(12);
            MockOutput.Setup(x => x.GetYCoOrdinates()).Returns(9);

            var shotCalculator = new ShotCalculator();
            var targetGenerator = new TargetGenerator();
            var targetJudge = new TargetJudge(MockOutput.Object, shotCalculator);

            var result = targetJudge.HitOrNot(35, 15, false);

            Assert.AreEqual(ITargetJudge.Status.Hit, result);
        }

        [TestMethod]
        public void HitOrNot_Miss_ReturnFalse()
        {
            var MockOutput = new Mock<ITargetGenerator>();
            MockOutput.Setup(x => x.GetXCoOrdinates()).Returns(12);
            MockOutput.Setup(x => x.GetYCoOrdinates()).Returns(9);

            var shotCalculator = new ShotCalculator();
            var targetGenerator = new TargetGenerator();
            var targetJudge = new TargetJudge(MockOutput.Object, shotCalculator);

            var result = targetJudge.HitOrNot(25, 15, false);

            Assert.AreEqual(ITargetJudge.Status.Miss, result);
        }
    }
}
