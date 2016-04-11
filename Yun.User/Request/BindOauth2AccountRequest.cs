using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 绑定OAuth2账号
    /// 根据用户ID绑定第三方账号
    /// chenggou.oauth2.user.bind
    /// </summary>
    public class BindOauth2AccountRequest: ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 第三方的oauthid
        /// </summary>
        public string OAuthId { get; set; }

        /// <summary>
        /// OAuth2认证类型
        /// </summary>
        public string OAuth2Type { get; set; }


        /// <summary>
        /// 用户原信息
        /// </summary>
        public string UserMeta { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }


        public string GetApiName()
        {
            return "chenggou.oauth2.user.bind";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"userid",UserId},
                {"oauthid",OAuthId},
                {"oauth2type",OAuth2Type},
                {"usermeta",UserMeta}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("oauth2type", OAuth2Type);
            RequestValidator.ValidateRequired("oauthid", OAuthId);
            RequestValidator.ValidateRequired("userid", UserId);
            RequestValidator.ValidateMinValue("userid", UserId, 1);
        }
    }
}
