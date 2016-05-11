using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Item.Request;

namespace Yun.UnitTest
{
    /// <summary>
    /// ItemUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class ItemUnitTest
    {
        [TestMethod]
        public void GetItemsRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemsRequest {PageSize = 1, PageNum = 1});

            Assert.IsTrue(req.Items != null);
        }

        [TestMethod]
        public void AddItemBookRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new AddItemBookRequest()
            {
               SkuId = 1,
               BookerName = "amy",
               ItemId = 2,
               Mobile = null,
               Quantity = 10
            }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }
        

        [TestMethod]
        public void AddShopItemCategoryRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new AddShopItemCategoryRequest()
            {
                Title = "商品名称",
                Display = true,
                ParentId = 1,
                Sort = 1,

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void AddItemRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new AddItemRequest()
            {
                ItemTitle = "goodtwo",
                MsgTitle = "123",
                OffshelfTime = 1,
                OnShelfTime = 1,
                OnShelfType = 1,
                Pictures = null,
                Price = 100,
                SaleType = 1,
                SeoDescription = null,
                SeoKeyword = null,
                SeoTitle = null,
                ShopCatIds = null,
                SortOrder = 1,
                Stock = 100,
                SubTitle = null,
                Volume = 10.9,
                Weight = 10.8,
                MarketPrice = 10.9,
                Description = "商品",
                AdditionalInfo = null,
                BuyLimit = 1,
                CloseTimeDelay = 1,
                CouponTemplateId = 1,
                CustomPropNames = null,
                CustomPropValues = null,
                CustomSkus = null,
                CustomSpecNames = null,
                DistributionTemplateId = 1,
                ExpireDays = 1,
                ExpireRule = 1,
                ExpireStart = 1,
                ExpireTime = 1,
                ExtItemCatIds = null,
                FreightTemplateId = 1,
                Integrallimit = 1,
                InventoryCount = 1,
                IsRecommend = 1,
                ItemCatId = 1,
                ItemCode = null,
                ItemPartnerIds = null,
                ItemPropValues = null,
                ItemSkus = null,
             }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetItemRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new GetItemRequest()
            {
                Id = 2,
               

            });

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetShopItemCategorysRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new GetShopItemCategorysRequest()
            {
                Display = -1,
                ParentId = 1,
                ShopId =2,

              });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddItemCatsRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new AddItemCatsRequest()
            {
               Name = "goodone",
             }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddItemSpecNameRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new AddItemSpecNameRequest
()
            {
                ItemCatId = 2,
                Name = "good",
                


            });
            Assert.IsTrue(req != null);
        }

    }
    }

