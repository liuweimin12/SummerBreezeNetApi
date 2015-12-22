using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Private.Response;

namespace Yun.Private.Request
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
