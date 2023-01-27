using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Tech_Exc_Project_2.UnitTests
{
    [TestClass]
    public class ShotCalculatorTests
    {
        [TestMethod]
        public void xCoOrdinate_CaculateX_ReturnX()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("20");
            MockInput.Setup(x => x.GetVelocity()).Returns("5");

            var validator = new InputValidator(MockInput.Object);
            var shotCalculator = new ShotCalculator(validator);
            var result = shotCalculator.xCoOrdinate(20, 5);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void yCoOrdinate_CaculateY_ReturnY()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("20");
            MockInput.Setup(x => x.GetVelocity()).Returns("5");

            var validator = new InputValidator(MockInput.Object);
            var shotCalculator = new ShotCalculator(validator);
            var result = shotCalculator.yCoOrdinate(20, 5);

            Assert.AreEqual(2, result);
        }

        public void xCoOrdinate_CaculateMaxX_ReturnMaxX()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("90");
            MockInput.Setup(x => x.GetVelocity()).Returns("20");

            var validator = new InputValidator(MockInput.Object);
            var shotCalculator = new ShotCalculator(validator);
            var result = shotCalculator.xCoOrdinate(90, 20);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void yCoOrdinate_CaculateMaxY_ReturnMaxY()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("90");
            MockInput.Setup(x => x.GetVelocity()).Returns("20");

            var validator = new InputValidator(MockInput.Object);
            var shotCalculator = new ShotCalculator(validator);
            var result = shotCalculator.yCoOrdinate(90, 20);

            Assert.AreEqual(20, result);
        }
    }
}
