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

        [TestMethod]
        public void GerPermissionUserRequest()
        {
            var req = YunClient.Instance.Execute(new GerPermissionUserRequest {Id = 172586}, YunClient.GetAdminToken());
            Assert.IsTrue(req.User != null);
        }

        [TestMethod]
        public void LoginRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new LoginRequest
                {
                    UserName = "测试网站111",
                    Password = "888999",
                    Ip = "192.168.1.1",
                    AppSecret = YunClient.AppSecret
                });

            Assert.IsTrue(req.UserId>0);
        }
    }
}
