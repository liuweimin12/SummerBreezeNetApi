﻿using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 快捷登陆
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
                {"shopid",ShopId}
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
