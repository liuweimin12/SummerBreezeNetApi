using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Trade.Request;

namespace Yun.UnitTest
{
    /// <summary>
    /// TradeUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class TradeUnitTest
    {
        [TestMethod]
        public void ExecuteTradeStatisticsRequest()
        {
            var req = YunClient.Instance.Execute(new ExecuteTradeStatisticsRequest { Day = 30 }, YunClient.GetAdminToken());
            Assert.IsTrue(req.Result);
        }
        [TestMethod]
        public void GetTradeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetTradeRequest
                {
                    Id = 123,
                    TradeNo="number"

                });
            Assert.IsTrue(req != null);
        }
    }
}
