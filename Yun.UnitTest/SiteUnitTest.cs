using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Site.Request;

namespace Yun.UnitTest
{
    /// <summary>
    /// SiteUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class SiteUnitTest
    {
        [TestMethod]
        public void GetImageTextsSiteElementRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new GetImageTextsSiteElementRequest
                {
                    
                });

            Assert.IsTrue(req != null);
        }
    }
}
