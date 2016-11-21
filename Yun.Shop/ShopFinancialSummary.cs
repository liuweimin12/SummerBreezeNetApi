using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Shop
{
    public class ShopFinancialSummary
    {
        /// <summary>
        /// 用户总余额
        /// </summary>
        [XmlElement("total_balance")]
        public double TotalBalance { get; set; }

        /// <summary>
        /// 资金类型
        /// </summary>
        [XmlArray("financial_types")]
        [XmlArrayItem("financial_type")]
        public List<FinancialType> FinancialType { get; set; }
    }
}
