using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Private.Request;

namespace Yun.UnitTest
{
    /// <summary>
    /// PrivateUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class PrivateUnitTest
    {
        [TestMethod]
        public void AddSiteRequest()
        {
            var req =
                YunClient.Instance.Execute(new AddSiteRequest
                {
                    Email = "chengjie.shen@hotmail.com",
                    MobilePhone = "17186393785",
                    SiteName = "夏日微风开放平台",
                    Password = "888999",
                    Secret = YunClient.AppSecret,
                    Ip = "192.168.1.1"
                });

            Assert.IsTrue(req.UserId > 0);
        }
    }
}
