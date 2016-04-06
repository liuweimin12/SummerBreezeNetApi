using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Archive.Request;


namespace Yun.UnitTest
{
    [TestClass]
    public class ArchiveUnitTest
    {
        //[TestMethod]
        //public void GetArchivesRequest()
        //{
        //    YunClient.Format = "json";
        //    var req =
        //        YunClient.Instance.Execute(new GetArchivesRequest
        //        {
        //            PageNum = 1,
        //            PageSize = 10,
        //            AuthorId = 123456,
        //            Sort = "123",
        //            Title = "titlt",
        //            StartPostTime=1,
        //            EndPostTime=2,
        //            TaxonomyId=123,
        //            Fields="fields",
        //            ShopId=123,
        //            Status="status",
        //           /// HasPunish='0',
        //            Tags="tags",
        //            CategoryName="hello",
        //            CompanyId=123
                    
        //        });
        //    Assert.IsTrue(req != null);
        //}
        [TestMethod]
        public void GetArchiveRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetArchiveRequest
                {
                    Id = 1,
                    Fields = "fields"
                    
                });
            Assert.IsTrue(req != null);
        }
        //[TestMethod]
        //public void GetCategoriesRequest()
        //{
        //    YunClient.Format = "json";
        //    var req =
        //        YunClient.Instance.Execute(new GetCategoriesRequest
        //        {
        //            Display = 1,
        //            ShopId= 123,
        //            ParentId=123

        //        });
        //    Assert.IsTrue(req != null);
        //}
        //[TestMethod]
        //public void GetCategoryRequest()
        //{
        //    YunClient.Format = "json";
        //    var req =
        //        YunClient.Instance.Execute(new GetCategoryRequest
        //        {
        //            Id = 123,

        //        });
        //    Assert.IsTrue(req != null);
        //}
        [TestMethod]
        public void GetArchiveTagsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetArchiveTagsRequest
                {
                    ShopId = 123,
                    PageNum = 1,
                    PageSize=20

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void IncreaseArchiveVisitRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new IncreaseArchiveVisitRequest
                {
                    Id = 123,
                    Visits = 123,
                 

                });
            Assert.IsTrue(req != null);
        }

    }
    }

