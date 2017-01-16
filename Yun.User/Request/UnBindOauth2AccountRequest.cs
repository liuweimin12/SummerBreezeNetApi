using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 当前账号与第三方账号解绑
    /// yun.oauth2.user.unbind
    /// </summary>
    public class UnBindOauth2AccountRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// OAuth2认证类型
        /// </summary>
        public string OAuth2Type { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        public string GetApiName()
        {
            return "yun.oauth2.user.unbind";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"oauth2type", OAuth2Type},
                {"userid", UserId},
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("oauth2type", OAuth2Type);
        }
    }
}
