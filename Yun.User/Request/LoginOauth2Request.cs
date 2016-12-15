using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 快捷登录
    /// 根据第三方的oauthid进行用户的快捷登录
    /// chenggou.oauth2.login
    /// </summary>
    public class LoginOauth2Request : ITopRequest<OAuth2LoginResponse>
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 第三方的oauthid
        /// </summary>
        public string OAuthId { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// OAuth2认证类型
        /// </summary>
        public string OAuth2Type { get; set; }


        /// <summary>
        /// 用户原信息
        /// </summary>
        public string UserMeta { get; set; }



        /// <summary>
        /// 用户的真实性名
        /// </summary>
        public string RealName { get; set; }


        /// <summary>
        /// 店铺ID 
        /// </summary>
        public int ShopId { get; set; }


        /// <summary>
        /// 用户头像
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// 用户登录时候的IP地址
        /// </summary>
        public string Ip { get; set; }


        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }

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


        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IdCard { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// APP密匙
        /// </summary>
        public string AppSecret { get; set; }


        public string GetApiName()
        {
            return "chenggou.oauth2.login";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"nickname",NickName},
                {"oauthid",OAuthId},
                {"email",Email},
                {"oauth2type",OAuth2Type},
                {"phone",Phone},
                {"avatar",Avatar},
                {"realname",RealName},
                {"usermeta",UserMeta},
                {"shopid",ShopId},
                {"logintype", LoginType},
                {"clientinfo", ClientInfo},
                {"deviceid",DeviceId },
                {"idcard",IdCard },
                {"password", TopUtils.EncryptAes(Password, AppSecret)},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("oauth2type", OAuth2Type);
            RequestValidator.ValidateRequired("oauthid", OAuthId);
        }
    }
}
