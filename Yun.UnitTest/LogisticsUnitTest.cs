using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Logistics.Request;

namespace Yun.UnitTest
{
    /// <summary>
    /// MarketingUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class LogisticsUnitTest
    {
        [TestMethod]
        public void AddDeliveryTemplateRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new AddDeliveryTemplateRequest
                {
                    Title = "AA",
                    Farefree = 10,
                    PriceType = 0,
                    FareFreeStrategy = null,
                    LogisticsPrice =null
                   

                }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteDeliveryTemplateRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new DeleteDeliveryTemplateRequest
                {
                  Id = 1
                }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void DeleteExpressTemplateRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new DeleteExpressTemplateRequest
                {
                    Id = 1
                }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);

        }

        [TestMethod]
        public void GetAddressesRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetAddressesRequest
                {
                   
                   
                });

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetAddressRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetAddressRequest
                {
                    Id =1

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetDefaultAddressRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetDefaultAddressRequest
                {
                    AddressType = 0

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetExpressTemplateRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetExpressTemplateRequest
                {
                    Id =1

                });
            Assert.IsTrue(req != null);

        }
        [TestMethod]
        public void GetTheMostExpensiveTemplateRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetTheMostExpensiveTemplateRequest
                {
                    ItemIds = "123"
                });
            Assert.IsTrue(req != null);

        }
    [TestMethod]
    public void SaveAddressRequest()
    {
        YunClient.Format = "xml";
        var req =
            YunClient.Instance.Execute(new SaveAddressRequest
            {
                Id = 110,
                Province = "浙江省",
                City = "宁波",
                Area = "高新区",
                Street = "杨帆街道",
                Zipcode = null,
                Name = "lily",
                Mobile = "13250958899",
                IsDefault = 1,
                AddressType = 0,
                Detail = null,
                Town = null,

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);

    }
    [TestMethod]
    public void SetDefaultAddressRequest()
    {
        YunClient.Format = "json";
        var req =
            YunClient.Instance.Execute(new SetDefaultAddressRequest
            {
                Id = 123
            });
        Assert.IsTrue(req != null);

    }
        [TestMethod]
        public void DeleteAddressRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new DeleteAddressRequest
                {
                    Id = 1
                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);

        }
        [TestMethod]
        public void GetDeliveryTemplatesRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetDeliveryTemplatesRequest
                {
                    ShopId = 1
                });
            Assert.IsTrue(req != null);

        }
        [TestMethod]
        public void GetLogisticsCompanyNameRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetLogisticsCompanyNameRequest
                {
                    
                });
            Assert.IsTrue(req != null);

        }
        [TestMethod]
        public void GetLogisticsRecordRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetLogisticsRecordRequest
                {
                    LogisticsName = "ems",
                    LogisticsNumber = "123466789",

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetShippingRecordRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetShippingRecordRequest
                {
                    OrderId = 1

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateDeliveryTemplateRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new UpdateDeliveryTemplateRequest
                {
                    Id = 1,
                    Title = "aa",
                    Farefree = 10,
                    FareFreeStrategy = null,
                    LogisticsPrice = null,
                    PriceType = 1

                });
            Assert.IsTrue(req != null);
        }
        


    } }