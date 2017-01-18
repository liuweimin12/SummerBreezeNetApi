using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class ExpenditureSummary
    {
        /// <summary>
        /// 上期收入结转
        /// </summary>
        [XmlElement("carryover")]
        public double Carryover { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [XmlElement("total_amount")]
        public int TotalAmount { get; set; }


        /// <summary>
        /// 支出明细
        /// </summary>
        [XmlArray("expenditure_compositions")]
        [XmlArrayItem("expenditure_composition")]
        public List<ExpenditureComposition> ExpenditureCompositions { get; set; }
    }
}
