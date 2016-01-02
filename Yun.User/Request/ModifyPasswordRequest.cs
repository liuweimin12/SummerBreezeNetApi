using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class ModifyPasswordRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 原始密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 新密码
        /// </summary>
        public string NewPassword { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.password.modify";
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
                {"newpassword",TopUtils.EncryptAes(NewPassword, AppSecret)}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("appsecret", AppSecret);
            RequestValidator.ValidateRequired("password", Password);
            RequestValidator.ValidateRequired("newpassword", NewPassword);
        }
    }
}
