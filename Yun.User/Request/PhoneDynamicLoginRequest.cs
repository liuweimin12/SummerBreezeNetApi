using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class PhoneDynamicLoginRequest : ITopRequest<LoginResponse>
    {
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
        /// </summary>
        public int ShopId { get; set; }


        /// <summary>
        /// 用户标识
        /// </summary>
        public string UserFlag { get; set; }

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
                {"userflag",UserFlag},
                {"companyid",CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ip", Ip);
            RequestValidator.ValidateRequired("code", Code);
            RequestValidator.ValidateRequired("phone", Phone);
            RequestValidator.ValidateRequired("userflag", UserFlag);
        }
    }
}
