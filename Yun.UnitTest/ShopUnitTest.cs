using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Shop.Request;
using Yun.Item.Request;

namespace Yun.UnitTest
{
    [TestClass]
    public class ShopUnitTest
    {
        [TestMethod]
        public void AddShopRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddShopRequest
                {
                    Name = "消费搜00",
                    AppSecret = YunClient.AppSecret,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddCompanyRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new AddCompanyRequest
                {
                    Name = "公司02",
                    PrepaidCardProportion = 10,

                    AppSecret = YunClient.AppSecret,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void SearchShopsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SearchShopsRequest
                {



                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void FindCompaniesRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new FindCompaniesRequest
                {
                    PageSize = 10,
                    PageNum = 1,


                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddShopAlumbRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new AddShopAlumbRequest
                {



                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddShopAreaRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddShopAreaRequest
                {
                    Name = "消费搜00",
                    Sort = 1,
                    ParentId = 1,


                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetShopRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetShopRequest
                {
                    ShopId = 1,


                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddShopCustomerserviceRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddShopCustomerserviceRequest
                {
                    Nick = "甜甜",
                    Qq = "1805768571",
                    IsFemale = true,


                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AskShopQuestionRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new AskShopQuestionRequest
                {
                    ShopId = 1,
                    Content = "店铺内容",
                    Other = "补充内容"

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BatchUpdateCustomerSortRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new BatchUpdateCustomerSortRequest
                {


                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BatchUpdateShopAreaRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new BatchUpdateShopAreaRequest
                {


                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void BatchUpdateShopCategoryRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new BatchUpdateShopCategoryRequest
                {


                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ClaimShopRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ClaimShopRequest
                {
                    ShopId = 1,
                    CompanyName = "公司02",
                    IdcardImg = "123456",
                    Email = "1805768571@qq.com",
                    LicenseImg = "123456789",
                    Mobile = "18606683125",

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteShopAlumbRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new DeleteShopAlumbRequest
                {
                    Ids = "1"

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteShopAreaRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new DeleteShopAreaRequest
                {
                    Id = 42659,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteShopCategoryRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new DeleteShopCategoryRequest
                {
                    Id = 2,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteShopCustomerServiceRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new DeleteShopCustomerServiceRequest
                {
                    Id = 3,

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteShopQuestionRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new DeleteShopQuestionRequest
                {
                    Ids = "7",

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ExistCompanyRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ExistCompanyRequest
                {
                    Content = "6",

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        //[TestMethod]
        //public void FindCompaniesRequest()
        //{
        //    YunClient.Format = "json";
        //    var req =
        //        YunClient.Instance.Execute(new FindCompaniesRequest
        //        {
        //            PageSize = 10,
        //            PageNum = 1,


        //        }, YunClient.GetAdminToken());
        ////    Assert.IsTrue(req != null);
        //}
        [TestMethod]
        public void GetCompanyRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetCompanyRequest
                {
                    Id = 7,


                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetCompanyRequest1()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetCompanyRequest
                {
                    Id = 7,


                });
            Assert.IsTrue(req != null);
        }




    }

}

