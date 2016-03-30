using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 手机动态码登录
    /// 根据手机动态码进行用户的快速登录和注册
    /// </summary>
    public class PhoneDynamicLoginRequest : ITopRequest<LoginResponse>
    {
        /// <summary>
        /// IP地址
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 店铺ID
        /// 该用户
        /// </summary>
        public int ShopId { get; set; }


        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.mobilephone.login";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ip",Ip},
                {"phone",Phone},
                {"code", Code},
                {"shopid",ShopId},
                {"userflag",Phone},
                {"companyid",CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ip", Ip);
            RequestValidator.ValidateRequired("code", Code);
            RequestValidator.ValidateRequired("phone", Phone);
        }
    }
}
