using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class PhoneRegisterRequest : ITopRequest<LoginResponse>
    {
        ///<summary>
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
        /// 用户密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        public string UserFlag { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }


        //该字段切记不需要传递
        /// <summary>
        /// 加密
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        public string IdCard { get; set; }


        /// <summary>
        /// 省
        /// </summary>
        public string Province { get; set; }


        /// <summary>
        /// 市
        /// </summary>
        public string City { get; set; }


        /// <summary>
        /// 区
        /// </summary>
        public string Area { get; set; }


        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.mobilephone.register";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ip", Ip},
                {"phone", Phone},
                {"code", Code},
                {"shopid", ShopId},
                {"userflag", UserFlag},
                {"companyid", CompanyId},
                {"password", TopUtils.EncryptAes(Password, Secret)},
                {"idcard", IdCard},
                {"province", Province},
                {"city", City},
                {"area", Area},
                {"address", Address},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("secret", Secret);
            RequestValidator.ValidateRequired("code", Code);
            RequestValidator.ValidateRequired("phone", Phone);
        }
    }
}
