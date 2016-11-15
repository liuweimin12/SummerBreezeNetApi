using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 用户登录
    /// 根据用户名和密码进行登录获取访问口令
    /// </summary>
    public class LoginRequest : ITopRequest<LoginResponse>
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 经过加密的密码，MD5加密
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 用户的IP地址
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// APP密匙
        /// 不要写在文档上
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// 是否忽略密码直接使用用户名获取访问口令
        /// 该方法不要写在文档上
        /// </summary>
        public bool IgnorePassword { get; set; }

        /// <summary>
        /// 0为PC，1为APP登录
        /// </summary>
        public int LoginType { get; set; }


        /// <summary>
        /// 客户端信息，传入设备的型号
        /// </summary>
        public string ClientInfo { get; set; }

        /// <summary>
        /// 登录设备ID
        /// </summary>
        public string DeviceId { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.login";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"username", this.UserName},

                {
                    "password",
                    string.IsNullOrWhiteSpace(Password)
                        ? ""
                        : (Password.Length == 32 ? Password : TopUtils.EncryptAes(Password, AppSecret))
                },
                {"ip", this.Ip},
                {"ignorepassword", IgnorePassword},
                {"logintype", LoginType},
                {"clientinfo", ClientInfo},
                {"deviceid",DeviceId }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("username", this.UserName);
        }

    }
}
