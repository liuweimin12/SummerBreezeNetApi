using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class IncomeComposition
    {
        /// <summary>
        ///名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("money")]
        public int Money { get; set; }

        /// <summary>
        /// 类型标记
        /// </summary>
        [XmlElement("type_flag")]
        public string TypeFlag { get; set; }
    }
}
