using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 获取快捷登录的授权地址
    /// </summary>
    public class GetAuthorizeUrlRequest : ITopRequest<GetAuthorizeUrlResponse>
    {
        /// <summary>
        /// OAuth2认证类型
        /// </summary>
        public string OAuth2Type { get; set; }

        public string GetApiName()
        {
            return "chenggou.oauth2.loginurl.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"oauth2type", OAuth2Type}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("oauth2type", OAuth2Type);
        }
    }
}