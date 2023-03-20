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
            DotNetEnv.Env.Load();
            var populate = new PopulateJson();

            Assert.IsTrue(File.Exists(populate.GetFilePath()));
        }
    }
}
