using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Site.Request
{
    /// <summary>
    /// 清除网站所有的数据
    /// </summary>
    public class ResetAllDataRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 需要清除的内容，多个用英文逗号分隔
        /// 可以清除内容包括如下部分：shop,commodity,trade,pay,archive,permission,pageelement,prepaidcard,user
        /// </summary>
        public string ClearContent { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.alldata.clear";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"clearcontent", ClearContent}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
