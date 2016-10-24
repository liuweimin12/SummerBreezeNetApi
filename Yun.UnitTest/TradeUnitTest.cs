using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Domain;
using Yun.Trade;
using Yun.Trade.Request;
using Yun.User.Request;
using Yun.Util;

namespace Yun.UnitTest
{
    /// <summary>
    /// TradeUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class TradeUnitTest
    {
        [TestMethod]
        public void GetExpressFeePriceRequest()
        {
            YunClient.Format = "json2";

            var req = YunClient.Instance.Execute(new GetExpressFeePriceRequest
            {
                Address = "浙江省 宁波市 高新区研发园B5",
                AreaId = 12,
                CityId = 7,
                ProvinceId = 1,
                TownId = 24,
                BoughtGoods = new ExpressFeePriceArgs
                {
                    delivery = "EXPRESS",
                    promotions_activity_id_in_shop = 0,
                    gifts = new List<TradeGiftJson>
                    {
                        new TradeGiftJson {gift_id = 1, is_coupon = false, sku_id = 0}
                    },
                    goods_info = new List<BuyGoods>()
                    {
                        new BuyGoods
                        {
                            item_id = 19872,
                            is_coupon = false,
                            is_gift = false,
                            promotions_activity_id_in_item = 0,
                            quantity = 1,
                            sku_id = 0
                        }
                    }
                }
            });

            Assert.IsTrue(req.Price>0);
        }

        [TestMethod]
        public void ExecuteTradeStatisticsRequest()
        {
            YunClient.Format = "json";
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
                    Mobile="18606683125",
                    TradeNum="001",
                    Quantity=2,
                    ItemId=16670,
                   
                    
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
                    Mobile = "18606683125",
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
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new AddToCartRequest
                {
                   Quantity = 1,
                   ItemId = 3,
                   SkuId = 0,
                   UserFlag = null,
                  
                   Delivery = "express",

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        /// <summary>
        /// 确认收货
        /// </summary>
        [TestMethod]
        public void ConfirmTradeRequest()
        {
            YunClient.Format = "xml";

            var reqLogin =
       YunClient.Instance.Execute(new LoginRequest
       {
           UserName = "18606683125",
           Password = "111111",

           AppSecret = YunClient.AppSecret
       }).Token;

            var req =
                YunClient.Instance.Execute(new ConfirmTradeRequest
                {
                    TradeId = 146121,
                }, reqLogin);
            Assert.IsTrue(req != null);
        }
        /// <summary>
        /// 评价商品
        /// </summary>
        [TestMethod]
        public void AddTradeRateRequest()
        {
            YunClient.Format = "json";
            var reqLogin =
          YunClient.Instance.Execute(new LoginRequest
          {
             UserName = "18606683125",
             Password = "111111",
             AppSecret = YunClient.AppSecret
         }).Token;
            var req =
                YunClient.Instance.Execute(new AddTradeRateRequest
                {
                   OrderId = 145159,
                   Content = "五颗星好评",
                   RateResult = "五颗星好评!!",
                   RatingJson = null,
                   Imgs = @"F:\pic",                 
                }, reqLogin);
            Assert.IsTrue(req != null);
        }
        /// <summary>
        ///获取评价信息
        /// </summary>
        [TestMethod]
        public void GetItemEvaluateRequest()
        {
            YunClient.Format = "xml";
            var req =
              YunClient.Instance.Execute(new GetItemEvaluateRequest
              {
                  ItemId = 16670,
                  PageSize = 10,
                  PageNum = 1,
              });
            Assert.IsTrue(req != null);
        }

      /// <summary>
      /// 批量确认收货
      /// </summary>
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
        /// <summary>
        /// 修改退款状态
        /// </summary>
        [TestMethod]
        public void ChangeRefundStatusRequest()
        {
            YunClient.Format = "json";
            var reqLogin =
                 YunClient.Instance.Execute(new LoginRequest
                 {
                     UserName = "18606683125",
                     Password = "111111",
                     AppSecret = YunClient.AppSecret
                 }).Token;
            var req =
          YunClient.Instance.Execute(new ChangeRefundStatusRequest
                {
                   OrderRefundId = 146062,
                   Remark = null,
                   Status = "SELLER_REFUSE_BUYER"
          }, reqLogin);
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
        /// <summary>
        /// 创建退款
        /// </summary>
        [TestMethod]
        public void CreateRefundRequest()
        {
            YunClient.Format = "json";
            var reqLogin =
                 YunClient.Instance.Execute(new LoginRequest
                 {
                     UserName = "18606683125",
                     Password = "111111",
                     AppSecret = YunClient.AppSecret
                 }).Token;
            var req =
                YunClient.Instance.Execute(new CreateRefundRequest
                {
                    OrderId = 146062,
                }, reqLogin);
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
        [TestMethod]
        public void GenerateCombinedPayTradeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GenerateCombinedPayTradeRequest
                {
                    Ip ="192.168.1.1",
                    Ids = "1",
                    BankCode = null,
                    Cash = 1,
                    ClientType = null,
                    OnlineMoney = 100,
                    OverMoney = 20,
                    PayChannel = null,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GeneratePayTradeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GeneratePayTradeRequest
                {
                    Ip = "192.168.1.1",
                    Id = 1,
                    BankCode = null,
                    Cash = 100,
                    ClientType = null,
                    OnlineMoney = 100,
                    OverMoney = 20,
                    PayChannel = null,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetCartCountRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetCartCountRequest
                {
                    ShopId =1,
                    CartType = 0,
                    UserFlag = null,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetEvaluateRecordRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetEvaluateRecordRequest
                {
                    ShopId = 0,
                    ItemId = 1,
                    PageSize = 10,
                    PageNum = 1,
                    HasContent = true,
  
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetIntegralRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetIntegralRequest
                {
                   
                    CompanyId = 1,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemTradeStatisticsReportRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetItemTradeStatisticsReportRequest
                {

                    ShopId = 1,
                    CompanyId = 1,
                    MinDateTime = DateTime.Now,
                    MaxDateTime = DateTime.Now,
                    PageSize = 1,
                    PageNum = 1,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetMonthTradeStatisticsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetMonthTradeStatisticsRequest
                {

                    ShopId = 1,
                    CompanyId = 1,
                    Year = 2016,
                    

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetMyRefundsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetMyRefundsRequest
                {
                   
                    
                    PageSize = 10,
                    PageNum = 1,
                    OrderId =146062,
                    OrderRefundId =146062


                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetMyTradeCountRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetMyTradeCountRequest
                {
                    UserId = 1,
 
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetRefundDetailRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetRefundDetailRequest
                {
                    RefundId = 1,
                    OrderId = 1,
                    

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetSellerRefundsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetSellerRefundsRequest
                {
                    
                    OrderId = 1,
                    CompanyId = 1,
                    LoadHistory = 1,
                    MinCreateTime = DateTime.Now,
                    MaxCreateTime = DateTime.Now,
                    Nick = null,
                    OrderRefundId = 1,
                    PageSize = 10,
                    PageNum = 1,
                    Status = null,
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetSellerTradeCountResquest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetSellerTradeCountResquest
                {
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetShoppingCartsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetShoppingCartsRequest
                {
                    ShopId =1,
                  
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetTradeDeductionRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetTradeDeductionRequest
                {
                   CompanyId = 1,
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetTradeRecordRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetTradeRecordRequest
                {
                    ShopId = 1,
                    ItemId = 1,
                    PageNum = 1,
                    PageSize = 10
                   
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetTradeSettingRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetTradeSettingRequest
                {
                
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetTradesSoldRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetTradesSoldRequest
                {
                    PageSize = 10,
                    PageNum = 1,
                   
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetTradeStatisticsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetTradeStatisticsRequest
                {
                    PageSize = 10,
                    PageNum = 1,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ModifyDeliveryInfoRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyDeliveryInfoRequest
                {
                    TradeId = 1,
                    ExpressEnName = null,
                    ExpressName = null,
                    Remark = null,
                    TrackingNumber = null,
                   
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ModifyPostFareRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyPostFareRequest
                {
                    Id = 1,
                    Postfee = 100,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ModifyPriceRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyPriceRequest
                {
                    Price = "1",
                    Postfee = 100,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ModifyRefundRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyRefundRequest
                {
                   OrderRefundId = 1,
                   Remark = null,
                   Reason =null,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void PayCompleteNotifyRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new PayCompleteNotifyRequest
                {
                    TradeId =1,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void PutRecycleBinRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new PutRecycleBinRequest
                {
                    TradeId = 1,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void RemoveCartRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new RemoveCartRequest
                {
                    CartIds = "1",
                    UserFlag = null,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void SaveMemoRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SaveMemoRequest
                {
                  Flag = 1,
                  Id = 1,
                  Memo = null,
                  SlaveFlag = 1,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void SaveSystemMemoRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SaveSystemMemoRequest
                {
                    TradeId = 1,
                    Memo = null,
                    

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void SetIntegralRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SetIntegralRequest
                {
                    OneIntegralEqualMoney = 100,
                    Enabled = 1,
                    TradeEndMoneyToCredit = 1


                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void SetTradeDeductionRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SetTradeDeductionRequest
                {
                  CompanyId = 1,
                  Content = 0,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateCartRequest()
        {
            YunClient.Format = "json";
            var req =
              YunClient.Instance.Execute(new UpdateCartRequest
              {
                 CartId = 1,
                 Quantity = 10,
                 UserFlag = null


                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateMobileRequest()
        {
            YunClient.Format = "json";
            var req =
              YunClient.Instance.Execute(new UpdateMobileRequest
              {
                 OrderId = 1,
                 Mobile = "15662414748"

              });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateShippingAddressRequest()
        {
            YunClient.Format = "json";
            var req =
              YunClient.Instance.Execute(new UpdateShippingAddressRequest
              {
                  OrderId = 1,
                  Mobile = "15662414748",
                  RealName = "hh",
                  Zipcode = null

              });
            Assert.IsTrue(req != null);
        }
       
        






    }
}
