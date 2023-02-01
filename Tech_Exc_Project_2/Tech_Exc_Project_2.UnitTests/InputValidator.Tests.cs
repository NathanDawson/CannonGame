using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Moq;
using Tech_Exc_Project_2;

namespace Tech_Exc_Project_2.UnitTests
{
    [TestClass]
    public class InputValidatorTests
    {
        [TestMethod]
        public void ParseAngle_StringToInt_ReturnOne()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("1");

            var validator = new InputValidator(MockInput.Object);
            var result = validator.ParseAngle();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ParseAngle_StringToInt_ReturnNinty()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("90");

            var validator = new InputValidator(MockInput.Object);
            var result = validator.ParseAngle();

            Assert.AreEqual(90, result);
        }

        [TestMethod]
        public void ParseAngle_WordToInt_ThrowFormatException()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("Ten");

            var validator = new InputValidator(MockInput.Object);

            Assert.ThrowsException<FormatException>(() => validator.ParseAngle());
        }

        [TestMethod]
        public void ParseAngle_DecimaltoInt_ThrowFormatException()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("5.5");

            var validator = new InputValidator(MockInput.Object);

            Assert.ThrowsException<FormatException>(() => validator.ParseAngle());
        }

        [TestMethod]
        public void ParseVelocity_StringToInt_ReturnOne()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetVelocity()).Returns("1");

            var validator = new InputValidator(MockInput.Object);
            var result = validator.ParseVelocity();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ParseVelocity_StringToInt_ReturnTwenty()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetVelocity()).Returns("20");

            var validator = new InputValidator(MockInput.Object);
            var result = validator.ParseVelocity();

            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void ParseVelocity_WordToInt_ThrowFormatException()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetVelocity()).Returns("Ten");

            var validator = new InputValidator(MockInput.Object);

            Assert.ThrowsException<FormatException>(() => validator.ParseVelocity());
        }

        [TestMethod]
        public void ParseVelocity_DecimaltoInt_ThrowFormatException()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetVelocity()).Returns("5.5");

            var validator = new InputValidator(MockInput.Object);

            Assert.ThrowsException<FormatException>(() => validator.ParseVelocity());
        }

        [TestMethod]
        public void ParseShotSelection_stringToInt_ReturnsOne()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetShotSelection()).Returns("1");

            var validator = new InputValidator(MockInput.Object);
            var result = validator.ParseShotSelection();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ParseShotSelection_stringToInt_ReturnsTwo()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetShotSelection()).Returns("2");

            var validator = new InputValidator(MockInput.Object);
            var result = validator.ParseShotSelection();

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ParseShotSelection_stringToInt_ThrowException()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetShotSelection()).Returns("Test");

            var validator = new InputValidator(MockInput.Object);

            Assert.ThrowsException<FormatException>(() => validator.ParseShotSelection());
        }

        [TestMethod]
        public void MortorOrNot_UserInputsOne_ReturnsFalse()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetShotSelection()).Returns("1");

            var validator = new InputValidator(MockInput.Object);
            validator.ParseShotSelection();
            var result = validator.MortorOrNot();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void MortorOrNot_UserInputsTwo_ReturnsTrue()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetShotSelection()).Returns("2");

            var validator = new InputValidator(MockInput.Object);
            validator.ParseShotSelection();
            var result = validator.MortorOrNot();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MortorOrNot_UserInputsThree_ThrowException()
        {
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetShotSelection()).Returns("3");

            var validator = new InputValidator(MockInput.Object);
            validator.ParseShotSelection();

            Assert.ThrowsException<Exception>(() => validator.MortorOrNot());
        }

        [TestMethod]
        public void CheckAngleRange_InsideLowerRange_ReturnsNoException()
        {
            // Arrange
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("1");

            // Act
            var validator = new InputValidator(MockInput.Object);

            // Assert
            try
            {
                validator.CheckAngleRange();
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void CheckAngleRange_InsideUpperRange_ReturnsNoException()
        {
            // Arrange
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("90");

            // Act
            var validator = new InputValidator(MockInput.Object);

            // Assert
            try
            {
                validator.CheckAngleRange();
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void CheckAngleRange_OutsideLowerRange_ReturnsException()
        {
            // Arrange
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("0");

            // Act
            var validator = new InputValidator(MockInput.Object);

            // Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => validator.CheckAngleRange());
        }

        [TestMethod]
        public void CheckAngleRange_OutsideUpperRange_ReturnsException()
        {
            // Arrange
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetAngle()).Returns("91");

            // Act
            var validator = new InputValidator(MockInput.Object);

            // Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => validator.CheckAngleRange());
        }

        [TestMethod]
        public void CheckVelocityRange_InsideLowerRange_ReturnsNoException()
        {
            // Arrange
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetVelocity()).Returns("1");

            // Act
            var validator = new InputValidator(MockInput.Object);

            // Assert
            try
            {
                validator.CheckVelocityRange();
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void CheckVelocityRange_InsideUpperRange_ReturnsNoException()
        {
            // Arrange
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetVelocity()).Returns("20");

            // Act
            var validator = new InputValidator(MockInput.Object);

            // Assert
            try
            {
                validator.CheckVelocityRange();
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void CheckVelocityRange_OutsideLowerRange_ReturnsException()
        {
            // Arrange
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetVelocity()).Returns("0");

            // Act
            var validator = new InputValidator(MockInput.Object);

            // Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => validator.CheckVelocityRange());
        }

        [TestMethod]
        public void CheckVelocityRange_OutsideUpperRange_ReturnsException()
        {
            // Arrange
            var MockInput = new Mock<ICommandLine>();
            MockInput.Setup(x => x.GetVelocity()).Returns("21");

            // Act
            var validator = new InputValidator(MockInput.Object);

            // Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => validator.CheckVelocityRange());
        }
    }
}
