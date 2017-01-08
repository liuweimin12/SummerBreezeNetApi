using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class IncomeSummary
    {
        /// <summary>
        /// 总金额
        /// </summary>
        [XmlElement("total_amount")]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 收入明细
        /// </summary>
        [XmlArray("income_compositions")]
        [XmlArrayItem("income_composition")]
        public List<IncomeComposition> IncomeCompositions { get; set; }
    }
}
