using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Pay;
using Yun.Pay.Request;

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
                    PrepaidCardTypeId =2,
                    CardNumber = "272302",
                    CardPassword = "1234561",
                    BindShopId = 1,
                    BindCompanyId = 1,
                    Money = 1000,
                    AppSecret =YunClient.AppSecret,
                 
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
                   BankId =1,
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
                    Id =1,
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
        


    }
}