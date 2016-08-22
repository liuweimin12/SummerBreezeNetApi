using System.Xml.Serialization;

namespace Yun.Site
{
    public class AppInfo
    {
        [XmlElement("app_key")]
        public string AppKey { get; set; }


        [XmlElement("app_secret")]
        public string AppSecret { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        [XmlElement("notify_url")]
        public string NotifyUrl { get; set; }
    }
}
