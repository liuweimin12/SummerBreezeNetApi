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
        
        [TestMethod]
        public void AddExpressTradeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddExpressTradeRequest
                {
                    Mobile="18560237296",
                    TradeNum="001",
                    Quantity=1,
                    ItemId=1,
                    Address = null,
                    CashCouponId = 1,
                    DeliveryType = null,
                    CreateTime = DateTime.Now,
                    ExpressRemark = null,
                    Ext = null,
                    Ext2 = null,
                    GiftsJson =null,
                    Integral = 10,
                    
                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddmultiExpressTradeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddmultiExpressTradeRequest
                {
                    Items = null,
                    Mobile = "18560237296",
                    TradeNum = "001",                 
                    Address = null,
                    CashCouponId = 1,                  
                    CreateTime = DateTime.Now,
                    ExpressRemark = null,
                    Ext = null,
                    Ext2 = null,
                    GiftsJson = null,
                    Integral = 10,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddToCartRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddToCartRequest
                {
                   Quantity = 1,
                   ItemId = 1,
                   SkuId = 0,
                   UserFlag = null,
                  
                   Delivery = "1",

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddTradeRateRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddTradeRateRequest
                {
                   OrderId = 1,
                   Content = null,
                   RateResult = null,
                   RatingJson = null,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BatchConfirmTradeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new BatchConfirmTradeRequest
                {

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BatchSaveMemoTradeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new BatchSaveMemoTradeRequest
                {
                    Ids = "1",
                    Flag = 1,
                    Memo = null,
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ChangeRefundStatusRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ChangeRefundStatusRequest
                {
                   OrderRefundId = 1,
                   Remark = null,
                   Status = "close"
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void CloseTradeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new CloseTradeRequest
                {
                   Id = 1,
                   CloseReason = null,
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void CompleteNoPaidTradeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new CompleteNoPaidTradeRequest
                {
                    TradeId = 1
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void CreateRefundRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new CreateRefundRequest
                {
                    OrderId = 1,
                    Balance = 100,
                    OnlineMoney = 10,
                    PrepaidCardMoney = 10,
                    Remark = null,
                    Reason = null,
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DelayReceiveTimeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new DelayReceiveTimeRequest
                {
                    OrderId = 1,
                    Days = 10,
                   
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeliveryTradeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new DeliveryTradeRequest
                {
                    OrderId = 1,
                    ExpressName = null,
                    ExpressEnName = null,
                    Remark = null,
                    TrackingNumber = null,
                    

                });
            Assert.IsTrue(req != null);
        }
        


    }
}
