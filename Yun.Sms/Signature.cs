

using System;
using System.Xml.Serialization;

namespace Yun.Sms
{
    public class Signature
    {
        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [XmlElement("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// 签名内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 签名是否通过
        /// </summary>
        [XmlElement("is_passed")]
        public bool IsPassed { get; set; }

        /// <summary>
        /// 通过时间
        /// </summary>
        [XmlElement("passed_time")]
        public long PassedTime { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        [XmlElement("company_id")]
        public long CompanyId { get; set; }

        /// <summary>
        /// 站点ID 
        /// </summary>
        [XmlElement("site_id")]
        public long SiteId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }
    }
}
