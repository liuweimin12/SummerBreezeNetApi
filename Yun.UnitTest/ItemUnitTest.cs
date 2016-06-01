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
               SkuId = 2,
               BookerName = "AA",
               ItemId = 4,
               Mobile = "18606683125",
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
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetShopItemCategorysRequest()
            {
                Display = -1,
                ParentId = 1,
                ShopId =1,

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
                Name = "ii",
                ShopId = 1

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddItemSpecValueRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new AddItemSpecValueRequest
()
            {
                SpecNameId =2,
                Sort = 1,
                Value = "1"
            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        
        [TestMethod]
        public void AddItemPropNameRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new AddItemPropNameRequest
()
            {
                ItemCatId = 1,
                Name = "good",
                Sort = 1,
                CanCustomValue = true,
                HasMultiValues = true,
                IsRequired = true,
                ShopId = 1,
                SpecialType = 1

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddItemPropValueRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new AddItemPropValueRequest()
            {
                Sort = 1,
                Image = null,
                IsHide = true,
                ParentId = 1,
                PropNameId = 5,
                Thumb = null,
                Value = "1",

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AskItemQuestionRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new AskItemQuestionRequest()
            {
               ItemId = 1,
               Content = "can i help you",
               Other = null,
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BatchUpdateItemCatRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new BatchUpdateItemCatRequest()
            {
                SortContent = "2:1",
            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ChangeBookStatusRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new ChangeBookStatusRequest()
            {
                Id = 2,
                Status = 1
            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void CopyItemToShopRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new CopyItemToShopRequest()
            {
                Stock = 1,
                ItemId = 1,
                ToShopId = 1
            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteItemBookRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new DeleteItemBookRequest()
            {
                Id = -2
            }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteItemCatsRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new DeleteItemCatsRequest()
            {
                Id = 6
            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteItemPropNameRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new DeleteItemPropNameRequest()
            {
                PropNameId =4
            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteItemPropValueRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new DeleteItemPropValueRequest()
            {
                PropValueId =1
            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteItemQuestionRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new DeleteItemQuestionRequest()
            {
               Ids ="4"
            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteItemRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new DeleteItemRequest()
            {
                ItemId = "1"
            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteItemSpecNameRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new DeleteItemSpecNameRequest()
            {
                SpecNameId = 9

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        //[TestMethod]
        //public void DeleteItemSpecValueRequest()
        //{
        //    YunClient.Format = "json";

        //    var req = YunClient.Instance.Execute(new DeleteItemSpecValueRequest()
        //    {
        //        SpecValueId =3
        //    }, YunClient.GetAdminToken());
        //    Assert.IsTrue(req != null);
        //}
        [TestMethod]
        public void DeleteShopItemCategoryRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new DeleteShopItemCategoryRequest()
            {
              Id =9

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemBookListRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new GetItemBookListRequest()
            {
               PageSize =10,
               PageNum = 1,
               CompanyId = 1,
               ShopId = 1,
               ItemId =-2,
               Nick = null,
               Sort = null,

            });
            Assert.IsTrue(req != null);
        }
        //[TestMethod]
        //public void GetItemBookRequest()
        //{
        //    YunClient.Format = "json";

        //    var req = YunClient.Instance.Execute(new GetItemBookRequest()
        //    {
        //        Id = 1

        //    });
        //    Assert.IsTrue(req != null);
        //}
        [TestMethod]
        public void GetItemCatChainRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemCatChainRequest()
            {
                ItemCatId =9,

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemCatDetailRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemCatDetailRequest()
            {
                ItemCatId =8,

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemCategorysRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new GetItemCategorysRequest()
            {
                ParentId = 1,

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemCatPropChildrenRequest()
        {
            YunClient.Format = "xml";

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
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new GetItemCatRequest()
            {
                Id = 1,
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemPropNameRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new GetItemPropNameRequest()
            {
                PropNameId = 1,
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetItemPropNamesRequest()
        {
            YunClient.Format = "xml";

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
        //[TestMethod]
        //public void GetItemPropValueRequest()
        //{
        //    YunClient.Format = "xml";

        //    var req = YunClient.Instance.Execute(new GetItemPropValueRequest()
        //    {
        //         PropValueId = 1
        //    });
        //    Assert.IsTrue(req != null);
        //}
        [TestMethod]
        public void GetItemPropValuesRequest()
        {
            YunClient.Format = "xml";

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
        //[TestMethod]
        //public void GetItemsByUserTypePromotionsRquest()
        //{
        //    YunClient.Format = "json";

        //    var req = YunClient.Instance.Execute(new GetItemsByUserTypePromotionsRquest()
        //    {
                
        //        UserType = "1"

                
        //    });
        //    Assert.IsTrue(req != null);
        //}
        [TestMethod]
        public void GetItemSpecNameRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetItemSpecNameRequest()
            {
                 SpecNameId =2,
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
        //[TestMethod]
        //public void GetItemSpecValuesRequest()
        //{
        //    YunClient.Format = "xml";

        //    var req = YunClient.Instance.Execute(new GetItemSpecValuesRequest()
        //    {
        //        PageSize = 10,
        //        PageNum = 1,
        //        SpecNameId = 1
        //    });
        //    Assert.IsTrue(req != null);
        //}
        [TestMethod]
        public void GetPrevsItemCatsRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new GetPrevsItemCatsRequest()
            {
                ItemCatsId = 1
            });
            Assert.IsTrue(req != null);
        }
        //[TestMethod]
        //public void GetPrevsShopItemCategoryRequest()
        //{
        //    YunClient.Format = "xml";

        //    var req = YunClient.Instance.Execute(new GetPrevsShopItemCategoryRequest()
        //    {
        //        Id = 6,
        //        ShopId = 1
        //    });
        //    Assert.IsTrue(req != null);
        //}
        [TestMethod]
        public void GetQuestionRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new GetQuestionRequest()
            {
                Id=3
            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetQuestionsRequest()
        {
            YunClient.Format = "xml";

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
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new GetShopItemCategoryRequest()
            {
               Id= 1

            });
            Assert.IsTrue(req != null);
        }
        //[TestMethod]
        //public void GetShopItemCountRequest()
        //{
        //    YunClient.Format = "xml";

        //    var req = YunClient.Instance.Execute(new GetShopItemCountRequest()
        //    {
        //        Id =1
        //    });
        //    Assert.IsTrue(req != null);
        //}
        [TestMethod]
        public void OffsheIfItemsRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new OffsheIfItemsRequest()
            {
                ItemIds = "001"

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void OnsheIfItemRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new OnsheIfItemRequest()
            {
                ItemId = "001"

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void RealDelItemRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new RealDelItemRequest()
            {
                ItemId = "001"

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ReplyQuestionRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new ReplyQuestionRequest()
            {
                Id =3,
                Content = "好的，收到"

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void RestoreItemRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new RestoreItemRequest()
            {
                ItemId = "1"

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void SearchLimitDiscountItemRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new SearchLimitDiscountItemRequest()
            {
                PageSize = 10,
                PageNum = 1,
              

            });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateItemCatRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new UpdateItemCatRequest()
            {
                Id = 1,
                Display = true,
                Name = "xx",
                Sort = 1

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateItemPropNameRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new UpdateItemPropNameRequest()
            {
                
                Name = "xx",
                Sort = 1,
                PropNameId = 1

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateItemPropValueRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new UpdateItemPropValueRequest()
            {
                PropValueId = 1,
                Image = null,
                IsHide = true,
                Sort = 1,
                Name = "xx",
                NewImage = null,

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateItemRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new UpdateItemRequest()
            {
              
                ItemTitle = "001",
               
                MsgTitle = "msgtitle"
                
            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateItemSpecNameRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new UpdateItemSpecNameRequest()
            {
                SpecNameId =5,
                Name = null

            }, YunClient.GetAdminToken());
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

            }, YunClient.GetAdminToken());
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
            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateQuestionRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new UpdateQuestionRequest()
            {
               Id = 1,
               Content = "ask question",
            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateShopItemCategoryDisplayRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new UpdateShopItemCategoryDisplayRequest()
            {
                Id = 1,
                Display = true

            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdatesortItemCategoryRequest()
        {
            YunClient.Format = "xml";

            var req = YunClient.Instance.Execute(new UpdatesortItemCategoryRequest()
            {
                Id = 1,
                Sort = 1
            }, YunClient.GetAdminToken());
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
            }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        




    }
}

