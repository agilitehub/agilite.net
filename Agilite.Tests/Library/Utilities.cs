using Agilite.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agilite.Tests.Library {
    public class Utilities {
        public static void CheckError(BaseModel.AgiliteError error) {
            if (error != null) {
                Assert.Fail(error.ErrorMessage);
            }

        }
    }
}
