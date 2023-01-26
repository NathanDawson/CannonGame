using System;
using System.Collections.Generic;
using System.Linq;
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
            var result = shotCalculator.xCoOrdinate();

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
            var result = shotCalculator.yCoOrdinate();

            Assert.AreEqual(2, result);
        }

        public void xCoOrdinate_CaculateMaxX_ReturnMaxX()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("90");
            MockInput.Setup(x => x.GetVelocity()).Returns("20");

            var validator = new InputValidator(MockInput.Object);
            var shotCalculator = new ShotCalculator(validator);
            var result = shotCalculator.xCoOrdinate();

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
            var result = shotCalculator.yCoOrdinate();

            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void xCoOrdinate_AngleOverRange_ThrowException()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("100");
            MockInput.Setup(x => x.GetVelocity()).Returns("5");

            var validator = new InputValidator(MockInput.Object);
            var shotCalculator = new ShotCalculator(validator);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => shotCalculator.xCoOrdinate());
        }

        [TestMethod]
        public void xCoOrdinate_VelocityOverRange_ThrowException()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("45");
            MockInput.Setup(x => x.GetVelocity()).Returns("35");

            var validator = new InputValidator(MockInput.Object);
            var shotCalculator = new ShotCalculator(validator);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => shotCalculator.xCoOrdinate());
        }

        [TestMethod]
        public void yCoOrdinate_AngleOverRange_ThrowException()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("100");
            MockInput.Setup(x => x.GetVelocity()).Returns("5");

            var validator = new InputValidator(MockInput.Object);
            var shotCalculator = new ShotCalculator(validator);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => shotCalculator.yCoOrdinate());
        }

        [TestMethod]
        public void yCoOrdinate_VelocityOverRange_ThrowException()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("45");
            MockInput.Setup(x => x.GetVelocity()).Returns("35");

            var validator = new InputValidator(MockInput.Object);
            var shotCalculator = new ShotCalculator(validator);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => shotCalculator.yCoOrdinate());
        }




    }
}
