using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 验证授权信息
    /// 根据授权信息获取用户信息
    /// 可以验证用户密码，必须传入用户授权码
    /// </summary>
    public class UserAuthRequest : ITopRequest<AuthSessionResponse>
    {
        /// <summary>
        /// 经过加密的密码
        /// </summary>
        public string Password { get; set; }


        /// <summary>
        /// APP密匙
        /// 不要写在文档上
        /// </summary>
        public string AppSecret { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.auth";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {
                    "password",
                    string.IsNullOrWhiteSpace(Password)
                        ? ""
                        : (Password.Length == 32 ? Password : TopUtils.EncryptAes(Password, AppSecret))
                }
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
