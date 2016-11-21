using System.Xml.Serialization;

namespace Yun.Shop
{
    public class FinancialTypeDetail
    {
        /// <summary>
        /// 详情类型
        /// </summary>
        [XmlElement("detail_type")]
        public string DetailType { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount_money")]
        public double AmountMoney { get; set; }
    }
}
