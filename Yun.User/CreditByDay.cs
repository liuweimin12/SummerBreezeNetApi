using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.User
{
    public class CreditByDay
    {
        /// <summary>
        /// 记录的日期
        /// </summary>
        [XmlElement("record_date")]
        public string RecordDate { get; set; }

        /// <summary>
        /// 积分
        /// </summary>
        [XmlArray("credits")]
        [XmlArrayItem("credit")]
        public List<CreditDomain> Credits { get; set; }
    }
}
