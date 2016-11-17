
using System.Xml.Serialization;

namespace Yun.User
{
    public class LoginRecord
    {
        /// <summary>
        /// 登录时间
        /// </summary>
        [XmlElement("login_time")]
        public string LoginTime { get; set; }

        /// <summary>
        /// 登录的IP地址
        /// </summary>
        [XmlElement("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// 登录类型
        /// </summary>
        [XmlElement("login_type")]
        public int LoginType { get; set; }

        /// <summary>
        /// 客户端名字
        /// </summary>
        [XmlElement("client_info")]
        public string ClientInfo { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }
    }
}
