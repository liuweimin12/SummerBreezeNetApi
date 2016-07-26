using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Request
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