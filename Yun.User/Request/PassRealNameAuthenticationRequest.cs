using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 通过实名认证申请
    /// yun.user.realnameauthentication.pass
    /// </summary>
    public class PassRealNameAuthenticationRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        public string GetApiName()
        {
            return "yun.user.realnameauthentication.pass";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"userid",UserId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("userid", UserId);
        }
    }
}
