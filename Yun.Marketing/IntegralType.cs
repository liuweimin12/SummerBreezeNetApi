using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class IntegralType
    {
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }


        /// <summary>
        /// 类型标记
        /// </summary>
        [XmlElement("type_flag")]
        public string TypeFlag { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }
    }
}
