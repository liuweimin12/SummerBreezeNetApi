using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Pay;
using Yun.Pay.Request;
using Yun.Pay.Response;
using Yun.Shop.Request;
using Yun.User.Request;

namespace Yun.UnitTest
{

    [TestClass]
    public class PayUnitTest
    {
        [TestMethod]
        public void AddPrepaidCardRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new AddPrepaidCardRequest
                {
                    PrepaidCardTypeId = 4,
                    CardNumber = "272306",
                    CardPassword = "1234561",
                    BindShopId = 1,
                    BindCompanyId = 1,
                    Money = 1000,
                    AppSecret = YunClient.AppSecret,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void AddPrepaidCardTypeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddPrepaidCardTypeRequest
                {
                    CardName = "充值卡",
                    CardType = 2,
                    Description = null,
                    Denomination = 1000,


                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void AddUserBankCardRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new AddUserBankCardRequest
                {
                    BankName = "cc",
                    AccountName = "dd",
                    BankNum = "98765432111",
                    IdCard = "1231456789622",
                    Location = null,
                    Phone = "15662414748",
                    RealName = "AMY",
                    SubBranch = "高新区支行",

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void ApplyWithdrawalsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ApplyWithdrawalsRequest
                {
                    BankId = 1,
                    Money = 10,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void BatchAddPrepaidCardRequest()
        {
            YunClient.Format = "xml";
            List<BatchAddCardJson> myBatchAddCardJson = new List<BatchAddCardJson>();
            BatchAddCardJson BatchAddCardJson1 = new BatchAddCardJson();
            BatchAddCardJson1.card_number = "111222";
            BatchAddCardJson1.card_password = "1234554321";
            BatchAddCardJson1.bind_shopId = 1;
            BatchAddCardJson1.bind_companyId = 1;
            BatchAddCardJson1.expired_time = null;
            myBatchAddCardJson.Add(BatchAddCardJson1);

            var req =
                YunClient.Instance.Execute(new BatchAddPrepaidCardRequest
                {
                    PrepaidCardTypeId = 1,
                    BatchAddCardJson = myBatchAddCardJson,
                    AppSecret = YunClient.AppSecret


                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void CompleteOnlinePayRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new CompleteOnlinePayRequest
                {
                    Id = 1,
                    PayPassword = "123456",
                    Money = 10,
                    TradeNum = "123456",
                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void CompletePayRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new CompletePayRequest
                {
                    Id = 2,
                    PayPassword = "123456",
                    OutTradeNum = "1112",
                    AppSecret = YunClient.AppSecret,
                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void CompleteRefundRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new CompleteRefundRequest
                {
                    RefundId = 1,
                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void CompleteWithdrawalsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new CompleteWithdrawalsRequest
                {
                    Id = 1,
                    Ip = "192.168.1.1"
                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void CreateRefundLinkRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new CreateRefundLinkRequest
                {
                    BatchNo = "301",
                    HtmlMethod = "GET",

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void DeletePrepaidCardRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new DeletePrepaidCardRequest
                {
                    PrepaidCardId = 1,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void DeletePrepaidCardTypeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new DeletePrepaidCardTypeRequest
                {
                    PrepaidCardTypeId = 1,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void ExecutePrepaidCardBalanceStatisticsRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new ExecutePrepaidCardBalanceStatisticsRequest
                {


                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void ExecuteShopPrepaidCardStatisticsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ExecuteShopPrepaidCardStatisticsRequest
                {
                    Day = 10,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GenerateJsApiPayParmRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GenerateJsApiPayParmRequest
                {
                    PrepayId = "1",
                    CompanyId = 1,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GeneratePayHtmlRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GeneratePayHtmlRequest
                {
                    Id = 2,
                    HtmlMethod = "GET",
                    MerchantUrl = null,
                    OutTradeNum = "1112",
                    ReturnUrl = null,
                    CompanyId = 1,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetAccountReportRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetAccountReportRequest
                {
                    PageSize = 1,
                    PageNum = 10,
                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetBandBankRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetBandBankRequest
                {
                    Id = 4,
                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetBandBanksRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetBandBanksRequest
                {

                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetCompanyPaymentRateRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetCompanyPaymentRateRequest
                {
                    CompanyId = 1,

                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetCompanyReportRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetCompanyReportRequest
                {
                    CompanyId = 1,
                    Direction = null,
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now,
                    MerchantOrderNo = null,
                    PageSize = 1,
                    PageNum = 10,
                    OppositeName = null,
                    OwnerId = 1,
                    ShopId = 1,
                    Status = null,
                    TradeType = null,

                });
            Assert.IsTrue(req != null);
        }

        //[TestMethod]
        //public void GetDefaultPayMentRateResponse()
        //{
        //    YunClient.Format = "json";
        //    var req =
        //        YunClient.Instance.Execute(new GetDefaultPayMentRateResponse
        //        {


        //        });
        //    Assert.IsTrue(req != null);
        //}
        [TestMethod]
        public void GetOnlinePaymentRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetOnlinePaymentRequest
                {
                    PayMethod = "MOBILE",
                    CompanyId = 1,

                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetPaymentInstitutionRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetPaymentInstitutionRequest
                {
                    PayMethod = "MOBILE",
                    CompanyId = 1,
                    ShopId = 1,

                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetPrepaidCardBalanceRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetPrepaidCardBalanceRequest
                {
                    PageNum = 1,
                    PageSize = 10,
                    StatisticsData = DateTime.Now,

                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetPrepaidCardDetailRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetPrepaidCardDetailRequest
                {
                    CardNumber = "272304",
                    PrepaidCardId = 6

                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetPrepaidCardMoneyRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetPrepaidCardMoneyRequest
                {
                    UserId = 1,
                    Nick = null


                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetPrepaidCardsListRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetPrepaidCardsListRequest
                {
                    PageSize = 1,

                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetPrepaidCardTypeListRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetPrepaidCardTypeListRequest
                {
                    PageSize = 1,

                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetPrepaidCardTypeRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetPrepaidCardTypeRequest
                {
                    PrepaidCardTypeId = 2,

                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetPrepaidTypeStatisticsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetPrepaidTypeStatisticsRequest
                {
                    PrepaidCardTypeId = 2,
                    BindCompanyId = 1,
                    BindShopId = 1,

                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetShopPrepaidCardStatisticsRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetShopPrepaidCardStatisticsRequest
                {
                    PageSize = 10,
                    PageNum = 1,
                    MaxStatisticsData = DateTime.Now,
                    MinStatisticsData = DateTime.Parse("2016-07-01"),
                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetSitePaymentrateRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetSitePaymentrateRequest
                {
                    DeveloperId = 1,
                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetWithdrawalsDetailListRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetWithdrawalsDetailListRequest
                {
                    PageSize = 10,
                    PageNum = 1,
                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetWithdrawalsDetailRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetWithdrawalsDetailRequest
                {
                    Id = 2,
                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void ModifyPrepaidCardMoneyRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new ModifyPrepaidCardMoneyRequest
                {
                    CardId = 4,
                    Money = 10000

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void ModifyPrepaidCardPasswordRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyPrepaidCardPasswordRequest
                {
                    PrepaidCardId = 6,
                    CardPassword = "123",
                    AppSecret = YunClient.AppSecret,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void ModifyUserBankCardRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new ModifyUserBankCardRequest
                {
                    BankName = "98765432111",
                    Id = 1,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void PerfectWithdrawalsInfoRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new PerfectWithdrawalsInfoRequest
                {
                    BankName = "9876543211",
                    RealName = "AMY",

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void PrepaidCardBindUserRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new PrepaidCardBindUserRequest
                {
                    BoundNick = "aa",
                    AppSecret = YunClient.AppSecret,
                    CardNumber = "272306",

                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void ReNotifyOuterTradeRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new ReNotifyOuterTradeRequest
                {
                    FlowId = 1,

                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void SetCompanyPaymentRateRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SetCompanyPaymentRateRequest
                {
                    CompanyId = 1,
                    Pc = 50,
                    Mobile = 40,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void SetDefaultPaymengRateRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SetDefaultPaymengRateRequest
                {

                    Pc = 50,
                    Mobile = 40,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void SetOnlinePaymentRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SetOnlinePaymentRequest
                {
                    PayMethod = "aa"

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void SetSitePaymentrateRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SetSitePaymenTrateRequest
                {
                    Pc = 50,
                    DeveloperId = 1,
                    Mobile = 18606683125

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void TransfersMoneyRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new TransfersMoneyRequest
                {
                    Money = 100,
                    TargetUserId = 1,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void UnBindPrepaidCardRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new UnBindPrepaidCardRequest
                {

                    CardNumber = "272306",

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void UpdatePrepaidCardTypeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new UpdatePrepaidCardTypeRequest
                {

                    PrepaidCardTypeId = 4,
                    CardName = "充值卡"

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void VerificationPrepaidCardRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new VerificationPrepaidCardRequest
                {
                    CardNumber = "272306",
                    AppSecret = YunClient.AppSecret,
                    CardPassword = "1234561"

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void WeixinUnifiedorderRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new WeixinUnifiedorderRequest
                {
                    Id = 1,
                    TradeType = "1"

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void SetExchangeRateRequest()
        {
            var login = YunClient.Instance.Execute(new LoginRequest {UserName = "礼来往", IgnorePassword = true}).Token;

            var req = YunClient.Instance.Execute(new SetExchangeRateRequest {CashRate = 0.01, PrepaidCardRate = 0.01},
                login);

            Assert.IsTrue(req.Result > 0);
        }


        [TestMethod]
        public void GetRefundAmountRequest()
        {
            var req =
                YunClient.Instance.Execute(new GetRefundAmountRequest {OutTradeNum = "go-307737-23-mlnjiev" })
                    .RefundMoney;

            Assert.IsTrue(req.OnlineMoney==0.01);
        }




    }
}