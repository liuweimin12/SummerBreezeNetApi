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
        public void GetAddressesRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetAddressesRequest
                {
                    Sort = "desc",
                    AddressType = 0
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
                    Id = 123

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
                    Id = 0

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
        YunClient.Format = "json";
        var req =
            YunClient.Instance.Execute(new SaveAddressRequest
            {
                Id = 123,
                Province = "浙江省",
                City = "宁波",
                Area = "高新区",
                Street = "杨帆街道",
                Zipcode = "000000",
                Name = "hello",
                Mobile = "0000-000000",
                IsDefault = 0

            });
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

} }