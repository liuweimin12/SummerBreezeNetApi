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
    /// 绑定邮箱
    /// 通过验证码修改/绑定当前登录人的邮箱
    /// </summary>
    public class BindEmailRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string Code { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.email.bind";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
               {"email",Email},
               {"code",Code}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("email", Email);
        }
    }
}
