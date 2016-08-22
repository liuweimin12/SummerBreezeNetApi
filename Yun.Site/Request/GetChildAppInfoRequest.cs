using System.Collections.Generic;
using Yun.Interface;
using Yun.Site.Response;

namespace Yun.Site.Request
{
    /// <summary>
    /// 获取子开发者账号信息
    /// yun.site.childappinfo.list.get
    /// </summary>
    public class GetChildAppInfoRequest :ITopRequest<GetChildAppInfoResponse>
    {
        public string GetApiName()
        {
            return "yun.site.childappinfo.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {

            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
