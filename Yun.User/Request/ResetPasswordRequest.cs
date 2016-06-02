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
    /// 重置密码
    /// </summary>
    public class ResetPasswordRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        public string UserFlag { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }


        /// <summary>
        /// 邮件
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.password.reset";
        }

        /// <summary>
        /// APP密匙
        /// </summary>
        public string AppSecret { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"password",TopUtils.EncryptAes(Password, AppSecret)},
                {"code",Code},
                {"userflag",UserFlag},
                {"companyid",CompanyId},
                {"email",Email},
                {"phone",Phone}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("password", Password);
        }
    }
}
