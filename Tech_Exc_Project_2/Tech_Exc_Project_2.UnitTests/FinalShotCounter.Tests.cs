using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2.UnitTests
{
    [TestClass]
    public class FinalShotCounterTests
    {
        [TestMethod]
        public void FinalShotCounter_AddOne_ReturnOne()
        {
            var shotCounter = new FinalShotCounter();

            shotCounter.SetCounter();

            Assert.AreEqual(1, shotCounter.GetCounter());
        }

        [TestMethod]
        public void FinalShotCounter_AddTwo_ReturnTwo()
        {
            var shotCounter = new FinalShotCounter();

            shotCounter.SetCounter();
            shotCounter.SetCounter();

            Assert.AreEqual(2, shotCounter.GetCounter());
        }

        [TestMethod]
        public void FinalShotCounter_AddThree_ReturnThree()
        {
            var shotCounter = new FinalShotCounter();

            shotCounter.SetCounter();
            shotCounter.SetCounter();
            shotCounter.SetCounter();

            Assert.AreEqual(3, shotCounter.GetCounter());
        }
    }
}
