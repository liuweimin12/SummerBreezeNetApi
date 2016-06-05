using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Sms.Request;

namespace Yun.UnitTest
{
    [TestClass]
    public class SmsUnitTest
    {
        [TestMethod]
        public void SendShortMessageRequest()
        {
            var req =
                YunClient.Instance.Execute(new SendShortMessageRequest
                {
                    CompanyId = 3,
                    Content = new Random().Next(10000,99999)+ "（手机登录验证码，请完成验证），如非本人操作，请忽略本信息。",
                    Mobile = "15958805628"
                });

            Assert.IsTrue(req.Result);
        }
    }
}
