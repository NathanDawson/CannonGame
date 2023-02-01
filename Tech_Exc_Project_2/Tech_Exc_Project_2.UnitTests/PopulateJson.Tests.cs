using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2.UnitTests
{
    [TestClass]
    public class PopulateJsonTests
    {
        [TestMethod]
        public void PopulateJson_JsonFileExists_ReturnTrue()
        {
            Assert.IsTrue(File.Exists(@"C:\Users\Nathan.Dawson\OneDrive - Apexon\Documents\Tech-Track\Tech-Exc\Project_2\Tech_Exc_Project_2\Tech_Exc_Project_2\UserData.json"));
        }
    }
}
