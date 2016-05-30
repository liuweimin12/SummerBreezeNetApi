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
                ShopId = 1
               
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddItemSpecValueRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new AddItemSpecValueRequest
()
            {
                SpecNameId = 1,
                Sort = 1,
                Value = null
  

            });
            Assert.IsTrue(req != null);
        }
        
        [TestMethod]
        public void AddItemPropNameRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new AddItemPropNameRequest
()
            {
                ItemCatId = 2,
                Name = "good",
                Sort = 1,
                CanCustomValue = true,
                HasMultiValues = true,
                IsRequired = true,
                ShopId = 1,
                SpecialType = 1


            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddItemPropValueRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new AddItemPropValueRequest()
            {
                Sort = 1,
                Image = null,
                IsHide = true,
                ParentId = 1,
                PropNameId = 1,
                Thumb = null,
                Value = null,


            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AskItemQuestionRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new AskItemQuestionRequest()
            {
               ItemId = 1,
               Content = null,
               Other = null,
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BatchUpdateItemCatRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new BatchUpdateItemCatRequest()
            {
                SortContent = null,
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ChangeBookStatusRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new ChangeBookStatusRequest()
            {
                Id = 1,
                Status = 1
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void CopyItemToShopRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new CopyItemToShopRequest()
            {
                Stock = 1,
                ItemId = 1,
                ToShopId = 1
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteItemBookRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new DeleteItemBookRequest()
            {
                Id = 1
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteItemCatsRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new DeleteItemCatsRequest()
            {
                Id = 1
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteItemPropNameRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new DeleteItemPropNameRequest()
            {
                PropNameId = 1
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteItemPropValueRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new DeleteItemPropValueRequest()
            {
                PropValueId = 1
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteItemQuestionRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new DeleteItemQuestionRequest()
            {
               Ids =null 
            
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteItemRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new DeleteItemRequest()
            {
                ItemId = "1"

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteItemSpecNameRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new DeleteItemSpecNameRequest()
            {
                SpecNameId = 1

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteItemSpecValueRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new DeleteItemSpecValueRequest()
            {
                SpecValueId = 1

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteShopItemCategoryRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new DeleteShopItemCategoryRequest()
            {
              Id = 1

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemBookListRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemBookListRequest()
            {
               PageSize =10,
               PageNum = 1,
               CompanyId = 1,
               ShopId = 1,
               ItemId = 1,
               Nick = "xx",
               Sort = null,

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemBookRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemBookRequest()
            {
              Id = 1,

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemCatChainRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemCatChainRequest()
            {
                ItemCatId = 1,

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemCatDetailRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemCatDetailRequest()
            {
                ItemCatId = 1,

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemCategorysRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemCategorysRequest()
            {
                ParentId = 1,

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemCatPropChildrenRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemCatPropChildrenRequest()
            {
                ParentValueId = 1,
                ItemcatId = 1
            

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemCatRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemCatRequest()
            {
                Id = 1,
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemPropNameRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemPropNameRequest()
            {
                PropNameId = 1,
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemPropNamesRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemPropNamesRequest()
            {
                ItemCatId = 1,
                CompanyId = 1,
                ShopId = 1,
                PageSize = 10,
                PageNum = 2,
                SpecialType = 1
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemPropValueRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemPropValueRequest()
            {
             PropValueId = 1
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemPropValuesRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemPropValuesRequest()
            {
                PageNum = 1,
                PageSize = 10,
                IsHide = true,
                ParentId = 1,
                PropNameId = 1,
                SpecialType = 1
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemsByUserTypePromotionsRquest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemsByUserTypePromotionsRquest()
            {
                PageNum = 1,
                PageSize = 10,
                CompanyId = 1,
                Fields = null,
                ImageSize = 1,
                ItemIds = null,
                NeedPromotion = true,
                ShopId = 1,
                UserType = "1"

                
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemSpecNameRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemSpecNameRequest()
            {
            SpecNameId = 1,
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemSpecnamesRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemSpecnamesRequest()
            {
                PageSize = 1,
                ItemCatId = 1,
                PageNum = 1,
                ShopId = 1
            });
            Assert.IsTrue(req != null);
        }
        //[TestMethod]
        //public void GetItemSpecValueRequest()
        //{
        //    YunClient.Format = "json";

        //    var req = YunClient.Instance.Execute(new GetItemSpecValueRequest()
        //    {
        //       SpecValueId = 1
        //    });
        //    Assert.IsTrue(req != null);
        //}
        [TestMethod]
        public void GetItemSpecValuesRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemSpecValuesRequest()
            {
               PageSize = 1,
               PageNum = 1,
               SpecNameId = 1
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetPrevsItemCatsRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetPrevsItemCatsRequest()
            {
                ItemCatsId = 1
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetPrevsShopItemCategoryRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetPrevsShopItemCategoryRequest()
            {
                Id = 1,
                ShopId = 1
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetQuestionRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetQuestionRequest()
            {
                Id = 1,
            
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetQuestionsRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetQuestionsRequest()
            {
                ShopId = 1,
                ItemId = 1,
                PageSize = 10,
                PageNum = 1,
                Content = null,
                ReplyStatus = 1

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetShopItemCategoryRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetShopItemCategoryRequest()
            {
               Id = 1

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetShopItemCountRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetShopItemCountRequest()
            {
                Id = 1

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void OffsheIfItemsRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new OffsheIfItemsRequest()
            {
                ItemIds = "1"

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void OnsheIfItemRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new OnsheIfItemRequest()
            {
                ItemId = "1"

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void RealDelItemRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new RealDelItemRequest()
            {
                ItemId = "1"

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ReplyQuestionRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new ReplyQuestionRequest()
            {
                Id =1

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void RestoreItemRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new RestoreItemRequest()
            {
                ItemId = "1"

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void SearchLimitDiscountItemRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new SearchLimitDiscountItemRequest()
            {
                PageSize = 10,
                PageNum = 1,
                Fields = null,
                ImageSize = 1,
                ShopId = 1,
                UserType = null,

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateItemCatRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new UpdateItemCatRequest()
            {
                Id = 1,
                Display = true,
                Name = "xx",
                Sort = 1

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateItemPropNameRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new UpdateItemPropNameRequest()
            {
                
                Name = "xx",
                Sort = 1,
                PropNameId = 1

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateItemPropValueRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new UpdateItemPropValueRequest()
            {
                PropValueId = 1,
                Image = null,
                IsHide = true,
                Sort = 1,
                Name = "xx",
                NewImage = null,

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateItemRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new UpdateItemRequest()
            {
               ItemId = 1,
               AdditionalInfo = null,
               BuyLimit = 1,
               BuyOnce = true,
               CloseTimeDelay = 2016-05-01,
               CustomSpecNames = null,
               CustomPropNames = null,
               CustomPropValues = null,
               CustomSkus = null,
               CouponTemplateId = 1,
               Description = null,
               DistributionTemplateId = 1,
               ExpireRule = 1,
               ExtItemCatIds = "1",
               ExpireDays = 10,
               ExpireTime = 2016-05-01,
                ExpireStart = 2016-05-01,
                FreightTemplateId = 1,
                ItemCatId = 1,
                InventoryCount = 1,
                ItemTitle = null,
                ItemPropValues = null,
                IsRecommend = 1,
                Integrallimit = 1,
                ItemPartnerIds = null,
                ItemSkus = null,
                ItemCode = null,
                MarketPrice = 100,
                MsgTitle = null,
                OnShelfType = 1,
                OnShelfTime = 2015-10-10,
                Pictures = null,
                Price = 60,
                SortOrder = 0,
                SeoKeyword = null,
                Stock = 100,
                SaleType = 1,
                ShopCatIds = null,
                SeoTitle = null,
                SeoDescription = null,
                SubTitle = null,
                TuanTitle = null,
                Volume = 100,
                Weight = 100,
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateItemSpecNameRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new UpdateItemSpecNameRequest()
            {
                SpecNameId = 1,
                Name = "hha"

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateItemSpecValueReuqst()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new UpdateItemSpecValueReuqst()
            {
                SpecValueId = 1,
                Name = "hha"

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateItemStateRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new UpdateItemStateRequest()
            {
                ItemId = 1,
                StateCode = 2030
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateQuestionRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new UpdateQuestionRequest()
            {
               Id = 1,
               Content = null,
           });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateShopItemCategoryDisplayRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new UpdateShopItemCategoryDisplayRequest()
            {
                Id = 1,
                Display = true
          
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdatesortItemCategoryRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new UpdatesortItemCategoryRequest()
            {
                Id = 1,
                Sort = 1
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateShopItemCategoryRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new UpdateShopItemCategoryRequest()
            {
                Id = 1,
                Sort = 1,
                Display = true,
                Image = null,
                NewImage = null,
                Title = null,
            });
            Assert.IsTrue(req != null);
        }
        




    }
}

