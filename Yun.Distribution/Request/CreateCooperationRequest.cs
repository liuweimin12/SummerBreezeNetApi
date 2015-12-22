using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;


namespace Yun.Distribution.Request
{
    public class CreateCooperationRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }


        /// <summary>
        /// Ip地址
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
        public string AppSecret { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }


        /// <summary>
        /// 上家的用户昵称
        /// </summary>
        public string SuperiorDistributor { get; set; }


        public string GetApiName()
        {
            return "chenggou.distribution.cooperation.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ip",Ip},
                {"note",Note},
                {"username",UserName},
                {"email",Email},
                {"mobile",Mobile},
                {"password",TopUtils.EncryptAes(Password, AppSecret)},
                {"superiordistributor",SuperiorDistributor},
                {"shopid",ShopId}
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
