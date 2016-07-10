using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Shop.Request;

namespace Yun.UnitTest
{
    /// <summary>
    /// ShopUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class ShopUnitTest
    {

        [TestMethod]
        public void SearchShopsRequest()
        {
            var req = YunClient.Instance.Execute(new SearchShopsRequest
            {
                PageNum = 1,
                PageSize = 20,
                CompanyId = 100,
            });

            Assert.IsTrue(req.TotalItem>0);
        }

        [TestMethod]
        public void GetShopRequest()
        {
            var req = YunClient.Instance.Execute(new GetShopRequest {ShopId = 12868});

            Assert.IsTrue(req.Shop!=null);
        }
    }
}
