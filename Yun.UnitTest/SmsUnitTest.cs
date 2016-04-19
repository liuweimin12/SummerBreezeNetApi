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
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new SendShortMessageRequest
                {
                    Mobile = "18606683125",
                    CompanyId = 1,
                    Content = "chashouduanxin"
                  
                   });
            Assert.IsTrue(req != null);
        }
        
      

    }
    }

