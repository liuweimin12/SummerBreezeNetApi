using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class AddUserRequest : ITopRequest<IntResultResponse>
    {
        /// IP 地址
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 密匙
        /// </summary>
        public string Secret { get; set; }


        public string Password { get; set; }

        public string GetApiName()
        {
            return "chenggou.distribution.cooperation.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new TopDictionary
            {
                {"ip",Ip},
                {"note",Note},
                {"username",UserName},
                {"email",Email},
                {"mobile",Mobile},
                {"secret",Secret},
                {"password",Password}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("username", UserName);
            RequestValidator.ValidateRequired("ip", Ip);
            RequestValidator.ValidateRequired("email", Email);
            RequestValidator.ValidateRequired("password", Password);

        }
    }
}
