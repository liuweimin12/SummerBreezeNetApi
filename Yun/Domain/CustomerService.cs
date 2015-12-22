using System.Xml.Serialization;

namespace Yun.Domain
{
    public class CustomerService
    {
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// QQ
        /// </summary>
        [XmlElement("qq")]
        public string Qq { get; set; }

        /// <summary>
        /// 旺旺
        /// </summary>
        [XmlElement("wangwang")]
        public string Wangwang { get; set; }
    }
}
