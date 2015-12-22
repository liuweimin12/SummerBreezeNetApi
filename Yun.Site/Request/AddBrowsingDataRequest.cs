using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Site.Request
{
    /// <summary>
    /// 插入用户的浏览记录
    /// chenggou.item.browsing.trace.add
    /// </summary>
    public class AddBrowsingDataRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// IP地址
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 当前页面URL
        /// </summary>
        public string CurrentUrl { get; set; }


        /// <summary>
        /// 匿名用户标识
        /// </summary>
        public string AnonymousId { get; set; }


        /// <summary>
        /// 上一页的URL
        /// </summary>
        public string UrlReferrer { get; set; }


        /// <summary>
        /// 用户的信息
        /// </summary>
        public string UserAgent { get; set; }


        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }


        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }


        /// <summary>
        /// 目标对象ID
        /// </summary>
        public int ObjectId { get; set; }


        /// <summary>
        /// 来访者形式，支持PC，MOBILE
        /// </summary>
        public string AccessTerminalType { get; set; }




        public string GetApiName()
        {
            return "chenggou.item.browsing.trace.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ip",Ip},
                {"nick",Nick},
                {"currenturl",CurrentUrl},
                {"companyid",CompanyId},
                {"objectid",ObjectId},
                {"accessterminaltype",AccessTerminalType},
                {"anonymousid",AnonymousId},
                {"urlreferrer",UrlReferrer},
                {"useragent",UserAgent},
                {"shopid",ShopId}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
