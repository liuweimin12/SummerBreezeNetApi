using System.Xml.Serialization;

namespace Yun.Site
{
    public class NotifySetting
    {
        /// <summary>
        /// 设置ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 类型ID
        /// </summary>
        [XmlElement("type_id")]
        public int TypeId { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        [XmlElement("notify_url")]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [XmlElement("is_enabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 格式，支持json和xml，默认xml
        /// </summary>
        [XmlElement("format")]
        public string Format { get; set; }


        /// <summary>
        /// 说明
        /// </summary>
        [XmlElement("note")]
        public string Note { get; set; }


        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }


        /// <summary>
        /// 方法
        /// </summary>
        [XmlElement("method")]
        public string Method { get; set; }
    }
}
