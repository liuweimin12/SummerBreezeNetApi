using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Archive.Request;
using Yun.User.Request;
using Yun.Util;


namespace Yun.UnitTest
{
    [TestClass]
    public class ArchiveUnitTest
    {
        [TestMethod]
        public void AddArchiveRequest()
        {
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

            Assert.IsTrue(req.Result > 0);
        }

        [TestMethod]
        public void GetArchivesRequest()
        {
            YunClient.Format = "json";
            
            var req =
                YunClient.Instance.Execute(new GetArchivesRequest
                {
                    PageNum = 1,
                    PageSize = 10,
                    Fields = "postmetas"
                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetArchiveRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetArchiveRequest
                {
                    Id = 70
                });
            Assert.IsTrue(req != null);
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
            //YunClient.Format = "XML";
            var req =
                YunClient.Instance.Execute(new GetArchiveCategoryRequest
                {
                    Id = 2
                });
            Assert.IsTrue(req.Category != null);
        }

        [TestMethod]
        public void AddArchiveAskRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddArchiveAskRequest
                {
                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetArchiveTagsRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetArchiveTagsRequest
                {
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
                    Id = 70,
                    Visits = 15
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AssociateArchiveReaderRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new AssociateArchiveReaderRequest
                {
                    ArchiveId = 1,
                    Type = 1,
                    UserIds =null 
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddArchiveCommentRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new AddArchiveCommentRequest
                {
                    Content = "hello",
                    Ip = "192.168.1.1",
                    ParentId = 1,
                    PostId = 1,
                    UserAgent =null
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BatchUpdateArchiveSortRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new BatchUpdateArchiveSortRequest
                {
                    

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteArchiveRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new DeleteArchiveRequest
                {
                    Id = 1
                });
            Assert.IsTrue(req != null);
        }
          [TestMethod]
        public void DeleteArchiveAskRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new DeleteArchiveAskRequest
                {
                    Ids = ""
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteArchiveCategoryRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new DeleteArchiveCategoryRequest
                {
                    Id =1
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteArchiveTagRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new DeleteArchiveTagRequest
                {
                    Id = 1
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetArchiveQuestionRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetArchiveQuestionRequest
                {
                    Id = 1
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetArchiveReaderRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetArchiveReaderRequest
                {
                    PageNum = 1,
                    PageSize = 100,
                    StartPostTime =2016-04-01,
                    EndPostTime =2016-05-01,
                    Fields = null,
                    ReaderName = null,
                    Sort = 1,
                    Title = null,
                    Type = 1
             });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateArchiveRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new UpdateArchiveRequest
                {
                    Tags = null,
                    Sort = 1,
                    CategoryId = 1,
                    CommentStatus = null,
                    CustomType = 2,
                    Detail = null,
                    Image = null,
                    NewImage =null,  
                    Id =1,
                    ParentId = 1,
                    Password = "123",
                    PostMeta = null,
                    PostTime = 2016-04-01,
                    Status = null,
                    Title = "文章标题",
                    Visits = 1,
                  });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateCategoryRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new UpdateCategoryRequest
                {
                    Id = 1,
                    Name = "amy",
                    Sort = 1,
                    Description = null,
                    Display = true,
                    Extension = null,
                    Image = null,
                    NewImage = null,
                    ParentId = 1
                  
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UpdateQuestionRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new UpdateQuestionRequest
                {
                    Id = 1,
                   Content = "hello"

                });
            Assert.IsTrue(req != null);
        }
        

    }
}

