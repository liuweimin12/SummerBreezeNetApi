using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.User.Request;

namespace Yun.UnitTest
{
    [TestClass]
    public class UserUnitTest
    {
        [TestMethod]
        public void ResetFunctionsRequest()
        {
           var req = YunClient.Instance.Execute(new ResetFunctionsRequest(), YunClient.GetAdminToken()).Result;
            Assert.IsTrue(req);
        }
    }
}
