using System.Collections.Generic;
using Yun.Interface;
using Yun.Site.Response;

namespace Yun.Site.Request
{
    /// <summary>
    /// 获取当前登录用户的APP信息，必须是管理员，必须授权
    /// chenggou.yun.authorization.get
    /// </summary>
    public class GetAppInfoRequest : ITopRequest<GetAppInfoResponse>
    {

        public string GetApiName()
        {
            return "chenggou.yun.authorization.get";
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
