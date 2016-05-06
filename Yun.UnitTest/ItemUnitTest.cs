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
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new GetItemsRequest {PageSize = 20, PageNum = 1});

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
               ItemId = 1,
               Mobile = null,
               Quantity = 10
            }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }
        

        [TestMethod]
        public void AddShopItemCategoryRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new AddShopItemCategoryRequest()
            {
                Title = "good",
                Display = true,
                ParentId = 1,
                Sort = 0,
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
                ItemTitle = "goodtwo",
                MsgTitle = "123",
                ItemCatId = 2,
                SortOrder = 0,


             }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetItemRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemRequest()
            {
                Id = 2,
               

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

