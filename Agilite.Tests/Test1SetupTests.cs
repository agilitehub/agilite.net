using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Agilite.Tests {
    [TestClass()]
    public class Test1SetupTests {

        //Check API Server URL is valid
        [TestMethod]
        public void Setup_0_CheckAPIServerURLIsEmpty() {          
            Assert.AreNotEqual(Constants.ApiServerUrl, "");           
        }

        //Check API Server URL is valid
        [TestMethod]
        public void Setup_1_CheckAPIServerURLIsValid() {           
            Uri uriResult;
 
            bool result = Uri.TryCreate(Constants.ApiServerUrl, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            Assert.IsTrue(result);
        }

        //Check API Key is valid
        [TestMethod]
        public void Setup_2_CheckAPIKeyIsValid() {
            Assert.AreNotEqual(Constants.ApiKey, "");
        }
    }
}
