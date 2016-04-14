using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Site.Request;
using Yun.Util;

namespace Yun.UnitTest
{
    /// <summary>
    /// SiteUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class SiteUnitTest
    {
        [TestMethod]
        public void AddSiteElementImageTextRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new AddSiteElementImageTextRequest
                {
                    Title = "网站图文信息",
                    Display = true,
                    HyperLink = "http://open.oodso.com/home/api/17347",
                    Image =new FileItem("D:/TEMP.JPG"),
                    ModuleId = 1,
                    ParentId = 1,
                    SortOrder = 0,
                    Thumb = "XX",
                });

            Assert.IsTrue(req != null);
        }
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
        [TestMethod]
        public void GetTextSiteElementRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new GetTextSiteElementRequest
                {

                });

            Assert.IsTrue(req != null);
        }
        
    }
}
