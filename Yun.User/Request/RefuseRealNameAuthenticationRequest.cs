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
    /// 拒绝实名认证申请
    /// yun.user.realnameauthentication.refuse
    /// </summary>
    public class RefuseRealNameAuthenticationRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 拒绝理由
        /// </summary>
        public string Reason { get; set; }

        public string GetApiName()
        {
            return "yun.user.realnameauthentication.refuse";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"userid",UserId},
                {"reason",Reason}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("userid", UserId);
        }
    }
}
