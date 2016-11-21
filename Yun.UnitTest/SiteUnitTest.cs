using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Site.Request;
using Yun.User.Request;
using Yun.Util;

namespace Yun.UnitTest
{
    /// <summary>
    /// SiteUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class SiteUnitTest
    {
        /// <summary>
        /// 图片上传问题，占不调试
        /// </summary>
        //[TestMethod]
        //public void AddSiteElementImageTextRequest()
        //{
        //    YunClient.Format = "json";

        //    var req =
        //        YunClient.Instance.Execute(new AddSiteElementImageTextRequest
        //        {
        //            Title = "网站图文信息",
        //            Display = true,
        //            HyperLink = "http://open.oodso.com/home/api/17347",
        //            Image = new FileItem("D:/temp.jpg"),
        //            ModuleId = 1,
        //            ParentId = 1,
        //            SortOrder = 0,
        //            Thumb = "XX",
        //        }, YunClient.GetAdminToken());

        //    Assert.IsTrue(req != null);
        //}
        [TestMethod]
        public void AddSiteElementTextRequest()
        {
            YunClient.Format = "json";
            var reqLogin =
    YunClient.Instance.Execute(new LoginRequest
    {
        UserName = "18606683125",
        Password = "111111",
        AppSecret = YunClient.AppSecret
    }).Token;
            var req =
                YunClient.Instance.Execute(new AddSiteElementTextRequest
                {
                   Title = "测试001",
                   Display = true,
                   HyperLink = "http://open.oodso.com/home/api/17345",
                   ModuleId = 1,
                   ParentId = 0,
                   SortOrder = 0,
                   TextType = 1,

                }, reqLogin);

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void AddSitePageModuleRequest()
        {
            YunClient.Format = "xml";

            var req =
                YunClient.Instance.Execute(new AddSitePageModuleRequest
                {
                    PageId = 001,
                    Image = null,
                    ModuleFlag =null,
                    ModuleThumb = null,
                    ModuleType = "xx",
                    Name = "hello",
                    Remark = "beizhu"
                }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddSitePageRequest()
        {
            YunClient.Format = "xml";

            var req =
                YunClient.Instance.Execute(new AddSitePageRequest
                {
                   Thumb =null,
                   CompanyId = 001,
                   Image = null,
                   Name = "taobaowangzhan",
                   Remark = "beihzu"
                }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetTextsSiteElementRequest()
        {

            var req =
                YunClient.Instance.Execute(new GetTextsSiteElementRequest
                {
                    ModuleFlag = "hot-search-view",
                    Num = 10
                });

            Assert.IsTrue(req != null);
        }


        [TestMethod]
        public void GetImageTextsSiteElementRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new GetImageTextsSiteElementRequest
                {
                    ModuleId = 1,
                    ModuleFlag = "flag",
                    Num = 7

                });

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetTextSiteElementRequest()
        {
            YunClient.Format = "xml";

            var req =
                YunClient.Instance.Execute(new GetTextSiteElementRequest
                {
                    Id = 4,
                });

            Assert.IsTrue(req != null);
        }
        
        [TestMethod]
        public void AddCityRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new AddCityRequest
                {
                    Name = "杭州",
                    ParentId = 1,
                    State = 1,
                    Sort = 1,
                    Ext = null

                }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void ClearCityRequest()
        {
            var req =
                YunClient.Instance.Execute(new ClearCityRequest (), YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetCitiesRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new GetCitiesRequest
                {
                    
                });

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetCustomSiteElementRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new GetCustomSiteElementRequest
                {
                    Id = 1,

                });

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddSiteRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new AddSiteRequest
                {
                    Email = "yuanqi@ourxanadu.com",
                    Password = "nbyc0574",
                    Code = "0574",
                    Secret = "nbyc0574",
                    MobilePhone = "15355126498",
                    SiteName = "风的记忆",

                });

            Assert.IsTrue(req != null);
        }
        /// <summary>
        /// 新增站点的版本号
        /// </summary>
        [TestMethod]
        public void AddSiteVersionRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new AddSiteVersionRequest
                {
                 Title = "测试001",
                 Version = "001"

                });

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void FindSiteVersionsRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new FindSiteVersionsRequest
                {
                    

                });

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void GetTheLatestVersionRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new GetTheLatestVersionRequest
                {


                });

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void CreateDeviceInitializationRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new CreateDeviceInitializationRequest
                {
                    DeviceId = "12504",

                });

            Assert.IsTrue(req != null);
        }
        


    }
}
