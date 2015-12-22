using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Sms
{
    public class SupportDataList
    {
        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 认证信息
        /// </summary>
        [XmlArray("auths")]
        [XmlArrayItem("auth")]
        public List<StringKeyValuePair> Auth { get; set; }

        /// <summary>
        /// 默认
        /// </summary>
        [XmlElement("default")]
        public bool Default { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }
    }
}
