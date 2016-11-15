using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 注册用户
    /// 通过用户名、邮箱、手机号等信息注册用户
    /// </summary>
    public class RegisterRequest : ITopRequest<LoginResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        /// <summary>
        /// 用户在系统中的等级，可以自定义用来进行用户分组
        /// </summary>
        public int SystemLevel { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 注册方式
        /// 0：普通注册
        /// 1：手机注册
        /// 2：普通注册带公司
        /// </summary>
        public int RegisterType { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 公司名
        /// </summary>
        public string SiteName { get; set; }


        /// <summary>
        /// IP地址
        /// </summary>
        public string Ip { get; set; }

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


        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        public int UserType { get; set; }

        /// <summary>
        /// 0为PC，1为APP登录
        /// </summary>
        public int LoginType { get; set; }


        /// <summary>
        /// 客户端信息
        /// </summary>
        public string ClientInfo { get; set; }


        /// <summary>
        /// 登录设备ID
        /// </summary>
        public string DeviceId { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.register";
        }

        /// <summary>
        /// APP密匙
        /// </summary>
        public string AppSecret { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"username", UserName},
                {"password", TopUtils.EncryptAes(Password, AppSecret)},
                {"ip", Ip},
                {"registertype", RegisterType},
                {"email", Email},
                {"mobile", Mobile},
                {"sitename", SiteName},
                {"systemlevel", SystemLevel},
                {"shopid", ShopId},
                {"companyid", CompanyId},
                {"idcard", IdCard},
                {"province", Province},
                {"city", City},
                {"area", Area},
                {"address", Address},
                {"realname", RealName},
                {"usertype",UserType },
                {"logintype", LoginType},
                {"clientinfo", ClientInfo},
                {"deviceid",DeviceId }
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ip", this.Ip);
            RequestValidator.ValidateRequired("appsecret", this.AppSecret);
        }
    }
}
