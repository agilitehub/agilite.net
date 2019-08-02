using System;
using Agilite.Tests.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Agilite.Tests
{
    [TestClass()]
    public class Test4ConnectorsTests : BaseClass
    {
        [TestMethod]
        public void RunAllConnectorsTests()
        {
            Keywords1ExecuteTest();
        }

        private void Keywords1ExecuteTest()
        {
            try
            {

                var result = Agilite.Connectors.Execute("testconnectorprofile", "posts");
                Utilities.CheckError(result.Error);
                Assert.AreEqual( JsonConvert.SerializeObject(result.ResponseData[0].userId) , "1");

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}