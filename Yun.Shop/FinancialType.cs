using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Shop
{
    public class FinancialType
    {
        /// <summary>
        /// 记录详情
        /// </summary>
        [XmlArray("financial_type_details")]
        [XmlArrayItem("financial_type_detail")]
        public List<FinancialTypeDetail> FinancialTypeDetails { get; set; }
    }
}
