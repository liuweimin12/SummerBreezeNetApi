using System.Collections.Generic;
using Yun.Interface;
using Yun.Private.Response;
using Yun.Util;

namespace Yun.Private.Request
{
    public class AddSiteRequest : ITopRequest<AddSiteResponse>
    {
        public string Password { get; set; }


        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }


        /// <summary>
        /// 移动手机
        /// </summary>
        public string MobilePhone { get; set; }


        /// <summary>
        /// 网站名字
        /// </summary>
        public string SiteName { get; set; }

        /// <summary>
        /// 推荐人工号
        /// </summary>
        public string JobNumber { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 密匙
        /// </summary>
        public string Secret { get; set; }

         /// <summary>
        /// 短信验证码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 匿名用户
        /// </summary>
        public string AnonymousUser { get; set; }

        public string GetApiName()
        {
            return "chenggou.yun.site.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"email", Email},
                {"password", TopUtils.EncryptAes(Password, Secret)},
                {"ip", Ip},
                {"jobnumber", JobNumber},
                {"mobilephone", MobilePhone},
                {"sitename", SiteName},
                {"code", Code},
                {"anonymoususer", AnonymousUser}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("email", this.Email);
            RequestValidator.ValidateRequired("password", this.Password);
            RequestValidator.ValidateRequired("secret", this.Secret);
            RequestValidator.ValidateRequired("mobilephone", this.MobilePhone);
            RequestValidator.ValidateRequired("sitename", this.SiteName);
        }
    }
}
