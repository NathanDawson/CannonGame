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
            var MockShot = new Mock<IShotCalculator>();
            var MockOutput = new Mock<ITargetGenerator>();
            var MockFinal = new Mock<IFinalShotCounter>();
            var MockTime = new Mock<ITimeTracker>();
            var MockUser = new Mock<IUserData>();
            var MockJson = new Mock<IPopulateJson>();

            var MockValid = new Mock<IInputValidator>();
            MockValid.Setup(x => x.ParseAngle()).Returns(35);
            MockValid.Setup(x => x.ParseVelocity()).Returns(10);

            var MockJudge = new Mock<ITargetJudge>();
            MockJudge.Setup(x => x.HitOrNot(35, 10)).Returns(ITargetJudge.Status.Hit);

            var flow = new Flow(MockInput.Object, MockValid.Object, MockShot.Object, MockOutput.Object, MockJudge.Object, MockFinal.Object, MockTime.Object, MockJson.Object, MockUser.Object);

            flow.Run();

            MockOutput.Verify(x => x.SetXCoOrdinates(), Times.Once);
            MockOutput.Verify(x => x.SetYCoOrdinates(), Times.Once);

            MockUser.Verify(x => x.SetPlayerName(), Times.Once);

            MockTime.Verify(x=> x.StartTimer(), Times.Once);

            MockOutput.Verify(x => x.GetXCoOrdinates(), Times.Once);
            MockOutput.Verify(x => x.GetYCoOrdinates(), Times.Once);

            MockInput.Verify(x => x.SetAngle(), Times.Once());
            MockInput.Verify(x => x.SetVelocity(), Times.Once());

            MockValid.Verify(x => x.ParseAngle(), Times.Once);
            MockValid.Verify(x => x.ParseVelocity(), Times.Once);
            MockValid.Verify(x => x.CheckAngleRange(), Times.Once);
            MockValid.Verify(x => x.CheckVelocityRange(), Times.Once);

            MockFinal.Verify(x => x.SetCounter(), Times.Once);
            MockFinal.Verify(x => x.GetCounter(), Times.Exactly(2));

            MockJudge.Verify(x => x.HitOrNot(35, 10), Times.Once);

            MockTime.Verify(x => x.StopTimer(), Times.Once);

            MockJson.Verify(x => x.PrintJson(), Times.Once);
        }
    }
}
