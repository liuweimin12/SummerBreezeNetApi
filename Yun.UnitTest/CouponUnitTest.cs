using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Coupon.Request;

namespace Yun.UnitTest
{
    [TestClass]
    public class CouponUnitTest
    {
        [TestMethod]
        public void AddCouponTradeRequest()
        {
            var req =
                YunClient.Instance.Execute(new AddCouponTradeRequest
                {
                    ItemId = 1,
                    Quantity = 10,
                    TradeNum = "",
                    Mobile = "18606683125",
                    SendType = "0",
                }, YunClient.GetAdminToken());

            Assert.IsTrue(req.Result > 0);
        }
    }
}
