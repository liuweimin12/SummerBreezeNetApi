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

            var req = YunClient.Instance.Execute(new GetItemsRequest {PageSize = 20, PageNum = 1});

            Assert.IsTrue(req.Items != null);
        }

        [TestMethod]
        public void AddShopItemCategoryRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new AddShopItemCategoryRequest()
            {
                Title = "商量名称",
                Display = true,
                ParentId = 1,
                Sort = 1,
                Thumb = null,
                Image = null

            });

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void AddItemRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new AddItemRequest()
            {
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
                ItemTitle = "高级商品",
                MarketPrice = 10.9,
                MsgTitle = "优等",
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
            });

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetItemRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemRequest()
            {
                Id = 1,
                Fields = null,
                NeedPromotion = true,
                ShopId = 1

            });

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetShopItemCategorysRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetShopItemCategorysRequest()
            {
                Display = 1,
                ParentId = 1,
                ShopId = 1,


            });


        }
    }
}
