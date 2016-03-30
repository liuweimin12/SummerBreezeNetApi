using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 修改用户密码
    /// 修改当前登录人员的密码
    /// 必须授权
    /// </summary>
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
        /// 不要写入文档
        /// </summary>
        public string AppSecret { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"password", Password.Length == 32 ? Password : TopUtils.EncryptAes(Password, AppSecret)},
                {"newpassword", NewPassword.Length == 32 ? NewPassword : TopUtils.EncryptAes(NewPassword, AppSecret)}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("password", Password);
            RequestValidator.ValidateRequired("newpassword", NewPassword);
        }
    }
}
