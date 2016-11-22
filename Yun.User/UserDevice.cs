using System.Xml.Serialization;

namespace Yun.User
{
    public class UserDevice
    {
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 外部的TOKEN
        /// </summary>
        [XmlElement("outer_token")]
        public string OuterToken { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }
    }
}
