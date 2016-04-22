using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Sms.Request;

namespace Yun.UnitTest
{
    [TestClass]
    public class SmsTest
    {
        [TestMethod]
        public void SendShortMessageRequest()
        {
            var req =
                YunClient.Instance.Execute(new SendShortMessageRequest
                {
                    CompanyId = 3,
                    Content = "您正在进行注册操作，验证码为：123456",
                    Mobile = "15958805628"
                });

            Assert.IsTrue(req.Result);
        }
    }
}
