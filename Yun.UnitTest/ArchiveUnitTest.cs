using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Archive.Request;
using Yun.User.Request;


namespace Yun.UnitTest
{
    [TestClass]
    public class ArchiveUnitTest
    {
        [TestMethod]
        public void AddArchiveRequest()
        {
            YunClient.Format = "xml";
            var req = YunClient.Instance.Execute(new AddArchiveRequest
            {
                CategoryId = 0,
                CommentStatus = "OPEN",
                CustomType = 0,
                Password = "",
                ParentId = 0,
                PostMeta = null,
                Image = null,
                Sort = 0,
                Detail = "文章详情",
                PostTime = 0,
                Status = "",
                Tags = "",
                Thumb = "",
                Title = "测试文章",
                Visits = 0
            }, YunClient.GetAdminToken());

            Assert.IsTrue(req.Result>0);
        }


        [TestMethod]
        public void GetArchivesRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetArchivesRequest
                {
                    PageNum = 1,
                    PageSize = 10,
                   });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetArchiveRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetArchiveRequest
                {
                   Id = 10
                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void AddCategoryRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new AddCategoryRequest
                {
                    Name = "hello001",
                    Description = "123",
                    ParentId = 1,
                    Sort = 1,
                    Image = null,
                    Thumb = "",
                }, YunClient.GetAdminToken());
            Assert.IsTrue(req.Result > 0);
        }

        [TestMethod]
        public void ArchiveAskRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ArchiveAskRequest
                {
                    Content = "文章详情",
                    ArchiveId = 10,
                    Other = "文章详情备注"
                }, YunClient.GetAdminToken());
            Assert.IsTrue(req.Result > 0);
        }
        

        [TestMethod]
        public void GetArchiveCategoriesRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetArchiveCategoriesRequest
                {
                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetArchiveCategoryRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetArchiveCategoryRequest
                {
                    Id = 34,
                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetArchiveTagsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetArchiveTagsRequest
                {
                    PageSize = 100
                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void IncreaseArchiveVisitRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new IncreaseArchiveVisitRequest
                {
                    Id=34,
                    Visits = 1
                    });
            Assert.IsTrue(req != null);
        }

    }
    }

