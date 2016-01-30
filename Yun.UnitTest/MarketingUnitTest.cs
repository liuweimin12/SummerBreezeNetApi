using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Marketing.Request;

namespace Yun.UnitTest
{
    /// <summary>
    /// MarketingUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class MarketingUnitTest
    {
        [TestMethod]
        public void GenerateCashCouponRequest()
        {
            var req =
                YunClient.Instance.Execute(new GenerateCashCouponRequest {CategoryId = 1, Num = 29},
                    YunClient.GetAdminToken()).Result;

            Assert.IsTrue(!string.IsNullOrEmpty(req));
        }

        [TestMethod]
        public void FindCashCouponRequest()
        {
            var req =
                YunClient.Instance.Execute(new FindCashCouponRequest {PageNum = 1, PageSize = 20, CategoryId = 1})
                    .CashCoupons;

            Assert.IsTrue(req!=null&&req.Any());
        }
    }
}
