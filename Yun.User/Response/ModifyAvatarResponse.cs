using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    public class ModifyAvatarResponse : YunResponse
    {
        /// <summary>
        /// 返回的URL
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("bool_result")]
        public bool Result { get; set; }
    }
}
