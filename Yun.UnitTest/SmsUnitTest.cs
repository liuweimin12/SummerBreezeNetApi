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
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SendShortMessageRequest
                {
                  
                   });
            Assert.IsTrue(req != null);
        }
        
      

    }
    }

