using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class ExpenditureSummary
    {
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
