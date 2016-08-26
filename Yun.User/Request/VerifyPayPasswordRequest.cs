using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 验证支付密码
    /// yun.user.paypassword.verify
    /// </summary>
    public class VerifyPayPasswordRequest: ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }


        /// <summary>
        /// APP密匙
        /// 不要写入文档
        /// </summary>
        public string AppSecret { get; set; }

        public string GetApiName()
        {
            return "yun.user.paypassword.verify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"password", Password.Length == 32 ? Password : TopUtils.EncryptAes(Password, AppSecret)},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("password", Password);
        }
    }
}
