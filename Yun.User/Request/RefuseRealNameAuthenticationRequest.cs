using System.Collections.Generic;
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
        /// 是否同时重置
        /// </summary>
        public bool IsReset { get; set; }


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
                {"reason",Reason},
                {"isreset",IsReset}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("userid", UserId);
        }
    }
}
