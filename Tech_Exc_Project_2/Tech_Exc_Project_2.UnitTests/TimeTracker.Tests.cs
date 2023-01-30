using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2.UnitTests
{
    [TestClass]
    public class TimeTrackerTests
    {
        [TestMethod]
        public void TimeTracker_Given0_Return0()
        {
            var timeTracker = new TimeTracker();

            timeTracker.StartTimer();

            timeTracker.StopTimer();

            Assert.AreEqual(timeTracker.GetTime(), 0);
        }

        [TestMethod]
        public void TimeTracker_Given1_Return1()
        {
            var timeTracker = new TimeTracker();

            timeTracker.StartTimer();

            Thread.Sleep(1000);

            timeTracker.StopTimer();

            Assert.AreEqual(timeTracker.GetTime(), 1);
        }

        [TestMethod]
        public void TimeTracker_Given2_Return2()
        {
            var timeTracker = new TimeTracker();

            timeTracker.StartTimer();

            Thread.Sleep(2000);

            timeTracker.StopTimer();

            Assert.AreEqual(timeTracker.GetTime(), 2);
        }

        [TestMethod]
        public void TimeTracker_Given3_Return3()
        {
            var timeTracker = new TimeTracker();

            timeTracker.StartTimer();

            Thread.Sleep(3000);

            timeTracker.StopTimer();

            Assert.AreEqual(timeTracker.GetTime(), 3);
        }

        [TestMethod]
        public void TimeTracker_Given10_Return10()
        {
            var timeTracker = new TimeTracker();

            timeTracker.StartTimer();

            Thread.Sleep(10000);

            timeTracker.StopTimer();

            Assert.AreEqual(timeTracker.GetTime(), 10);
        }
    }
}
