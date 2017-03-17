using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.User
{
    public class LoginInfo
    {
        /// <summary>
        /// 登录ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 登录时间
        /// </summary>
        [XmlElement("login_time")]
        public string LoginTime { get; set; }


        /// <summary>
        /// 登录类型
        /// </summary>
        [XmlElement("login_type")]
        public int LoginType { get; set; }


        /// <summary>
        /// 客户端信息
        /// </summary>
        [XmlElement("client_info")]
        public string ClientInfo { get; set; }

        /// <summary>
        /// 设备信息
        /// </summary>
        [XmlArray("device_info_list")]
        [XmlArrayItem("device_info")]
        public List<UserDevice> DeviceInfoList { get; set; }
    }
}
