using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    public class OAuth2LoginResponse : YunResponse
    {
        /// <summary>
        /// 用户token
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 是否是第一次登录
        /// </summary>
        [XmlElement("first_login")]
        public bool FirstLogin { get; set; }
    }
}
