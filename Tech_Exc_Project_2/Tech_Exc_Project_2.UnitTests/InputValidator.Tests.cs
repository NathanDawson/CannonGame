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
            var validator = new InputValidator();

            var result = validator.ParseAngle("1");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ParseAngle_StringToInt_ReturnNinty()
        {
            var validator = new InputValidator();

            var result = validator.ParseAngle("90");

            Assert.AreEqual(90, result);
        }

        [TestMethod]
        public void ParseAngle_WordToInt_ThrowFormatException()
        {
            var validator = new InputValidator();

            Assert.ThrowsException<FormatException>(() => validator.ParseAngle("Test"));
        }

        [TestMethod]
        public void ParseAngle_DecimaltoInt_ThrowFormatException()
        {
            var validator = new InputValidator();

            Assert.ThrowsException<FormatException>(() => validator.ParseAngle("5.5"));
        }

        [TestMethod]
        public void ParseVelocity_StringToInt_ReturnOne()
        {
            var validator = new InputValidator();

            var result = validator.ParseVelocity("1");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ParseVelocity_StringToInt_ReturnTwenty()
        {
            var validator = new InputValidator();

            var result = validator.ParseVelocity("20");

            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void ParseVelocity_WordToInt_ThrowFormatException()
        {
            var validator = new InputValidator();

            Assert.ThrowsException<FormatException>(() => validator.ParseVelocity("Test"));
        }

        [TestMethod]
        public void ParseVelocity_DecimaltoInt_ThrowFormatException()
        {
            var validator = new InputValidator();

            Assert.ThrowsException<FormatException>(() => validator.ParseVelocity("5.5"));
        }

        [TestMethod]
        public void ParseShotSelection_stringToInt_ReturnsOne()
        {
            var validator = new InputValidator();

            var result = validator.ParseShotSelection("1");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ParseShotSelection_stringToInt_ReturnsTwo()
        {
            var validator = new InputValidator();

            var result = validator.ParseShotSelection("2");

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ParseShotSelection_stringToInt_ThrowException()
        {
            var validator = new InputValidator();

            Assert.ThrowsException<FormatException>(() => validator.ParseShotSelection("Test"));
        }

        [TestMethod]
        public void MortorOrNot_UserInputsOne_ReturnsFalse()
        {
            var validator = new InputValidator();

            var result = validator.MortorOrNot("1");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void MortorOrNot_UserInputsTwo_ReturnsTrue()
        {
            var validator = new InputValidator();

            var result = validator.MortorOrNot("2");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MortorOrNot_UserInputsThree_ThrowException()
        {
            var validator = new InputValidator();

            Assert.ThrowsException<Exception>(() => validator.MortorOrNot("3"));
        }

        [TestMethod]
        public void CheckAngleRange_InsideLowerRange_ReturnsNoException()
        {
            var validator = new InputValidator();
           
            try
            {
                validator.CheckAngleRange("1");
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void CheckAngleRange_InsideUpperRange_ReturnsNoException()
        {
            var validator = new InputValidator();

            try
            {
                validator.CheckAngleRange("90");
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void CheckAngleRange_OutsideLowerRange_ReturnsException()
        {
            var validator = new InputValidator();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => validator.CheckAngleRange("0"));
        }

        [TestMethod]
        public void CheckAngleRange_OutsideUpperRange_ReturnsException()
        {
            var validator = new InputValidator();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => validator.CheckAngleRange("91"));
        }

        [TestMethod]
        public void CheckVelocityRange_InsideLowerRange_ReturnsNoException()
        {
            var validator = new InputValidator();

            try
            {
                validator.CheckVelocityRange("1");
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void CheckVelocityRange_InsideUpperRange_ReturnsNoException()
        {
            var validator = new InputValidator();

            try
            {
                validator.CheckVelocityRange("20");
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void CheckVelocityRange_OutsideLowerRange_ReturnsException()
        {
            var validator = new InputValidator();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => validator.CheckVelocityRange("0"));
        }

        [TestMethod]
        public void CheckVelocityRange_OutsideUpperRange_ReturnsException()
        {
            var validator = new InputValidator();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => validator.CheckVelocityRange("21"));
        }
    }
}
