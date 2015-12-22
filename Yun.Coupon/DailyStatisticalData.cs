using System.Xml.Serialization;

namespace Yun.Coupon
{
    public class DailyStatisticalData
    {
        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }


        /// <summary>
        /// 电子券验证数量
        /// </summary>
        [XmlElement("consume_quantity")]
        public int ConsumeQuantity { get; set; }
    }
}
