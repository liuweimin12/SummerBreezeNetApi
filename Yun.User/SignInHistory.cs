using System.Xml.Serialization;

namespace Yun.User
{
    public class SignInHistory
    {
        /// <summary>
        /// 签到记录ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 签到时间
        /// </summary>
        [XmlElement("sign_in_time")]
        public string SignInTime { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [XmlElement("username")]
        public string UserName { get; set; }


        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }


        /// <summary>
        /// 设备地址
        /// </summary>
        [XmlElement("device_address")]
        public string DeviceAddress { get; set; }
    }
}
