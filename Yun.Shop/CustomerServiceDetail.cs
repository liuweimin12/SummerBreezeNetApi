
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Shop
{
    public class CustomerServiceDetail : CustomerService
    {
        /// <summary>
        /// 排序
        /// </summary>
        [XmlElement("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        [XmlElement("display")]
        public bool Display { get; set; }
    }
}
