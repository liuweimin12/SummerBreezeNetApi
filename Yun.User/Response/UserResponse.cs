using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.User.Response
{
    public class UserResponse : YunResponse
    {
        /// <summary>
        /// 用户数据
        /// </summary>
        [XmlElement("user")]
        public UserDetail User { get; set; }
    }
}
