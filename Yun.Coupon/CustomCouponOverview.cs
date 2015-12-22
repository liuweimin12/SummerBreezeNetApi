
using System.Xml.Serialization;

namespace Yun.Coupon
{
    public class CustomCouponOverview
    {
        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_count")]
        public int TotleCount { get; set; }
    }
}
