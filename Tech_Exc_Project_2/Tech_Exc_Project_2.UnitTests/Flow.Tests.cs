using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Tech_Exc_Project_2.UnitTests
{
    [TestClass]
    public class FlowTests
    {
        [TestMethod]
        public void flow_Verify_RunsOnce()
        {
            var MockInput = new Mock<ICommandLine>();
            var MockValid = new Mock<IInputValidator>();
            var MockShot = new Mock<IShotCalculator>();
            var MockOutput = new Mock<ITargetGenerator>();
            var MockFinal = new Mock<IFinalShotCounter>();
            var MockTime = new Mock<ITimeTracker>();
            var MockJson = new Mock<IPopulateJson>();

            var MockJudge = new Mock<ITargetJudge>();
            MockJudge.Setup(x => x.HitOrNot(35, 10, false)).Returns(ITargetJudge.Status.Hit);

            var flow = new Flow(MockInput.Object, MockValid.Object, MockShot.Object, MockOutput.Object, MockJudge.Object, MockFinal.Object, MockTime.Object, MockJson.Object);

            flow.Run();

            MockInput.Verify(x => x.SetShotSelection(), Times.Once);

            MockValid.Verify(x => x.ParseShotSelection(null), Times.Once);

            MockInput.Verify(x => x.SetAngle(), Times.Once);
            MockValid.Verify(x => x.CheckAngleRange(null), Times.Once);
            MockValid.Verify(x => x.EnforceMortorAngle(null, null), Times.Once);

            MockInput.Verify(x => x.SetVelocity(), Times.Once);
            MockValid.Verify(x => x.CheckVelocityRange(null), Times.Once);

            MockFinal.Verify(x => x.SetCounter(), Times.Once);

            MockFinal.Verify(x => x.GetCounter(), Times.Exactly(2));

            MockTime.Verify(x => x.StopTimer(), Times.Once);

            MockJson.Verify(x => x.UpdateJson(null, 0, 0), Times.Once);
            MockJson.Verify(x => x.PrintJson(), Times.Once);
        }
    }
}
