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
    /// 通过验证码修改/绑定当前登录人的手机号
    /// </summary>
    public class BindPhoneRequest : ITopRequest<BoolResultResponse>
    {

        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string Code { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.mobilephone.bind";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
               {"phone",Phone},
               {"code",Code}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("phone", Phone);
        }
    }
}
