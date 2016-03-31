using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Item.Request;

namespace Yun.UnitTest
{
    /// <summary>
    /// ItemUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class ItemUnitTest
    {
        [TestMethod]
        public void GetItemsRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemsRequest {PageSize = 20, PageNum = 1});

            Assert.IsTrue(req.Items != null);
        }

    }
}
