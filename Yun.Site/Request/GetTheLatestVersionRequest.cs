using System.Collections.Generic;
using Yun.Interface;
using Yun.Site.Response;

namespace Yun.Site.Request
{
    /// <summary>
    /// 获取最新的版本号
    /// yun.site.version.latest.get
    /// </summary>
    public class GetTheLatestVersionRequest : ITopRequest<GetTheLatestVersionResponse>
    {
        /// <summary>
        /// 类型
        /// </summary>
        public int? Type { get; set; }

        public string GetApiName()
        {
            return "yun.site.version.latest.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"type",Type}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
