using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.User
{
    public class UserGroupDevices
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 用户设备
        /// </summary>
        [XmlArray("user_devices")]
        [XmlArrayItem("user_device")]
        public List<UserDevice> UserDevices { get; set; }
    }
}
