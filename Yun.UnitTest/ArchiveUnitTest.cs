using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Archive.Request;


namespace Yun.UnitTest
{
    [TestClass]
    public class ArchiveUnitTest
    {
        [TestMethod]
        public void GetArchivesRequest()
        {
            YunClient.Format = "json";
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
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetArchiveRequest
                {
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
            YunClient.Format = "XML";
            var req =
                YunClient.Instance.Execute(new GetArchiveCategoryRequest
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
                   
                 });
            Assert.IsTrue(req != null);
        }

    }
    }

