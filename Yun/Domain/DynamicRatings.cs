using System.Xml.Serialization;

namespace Yun.Domain
{
    public class DynamicRatings
    {
        /// <summary>
        /// 平均分
        /// </summary>
        [XmlElement("avg_score")]
        public string  AvgScore { set; get; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string  Description { set; get; }

        /// <summary>
        /// 物流配送
        /// </summary>
        [XmlElement("logistics_delivery")]
        public string  LogisticsDelivery { set; get; }
        
        /// <summary>
        /// 卖方交货
        /// </summary>
        [XmlElement("seller_delivery")]
        public string  SellerDelivery { set; get; }

        /// <summary>
        /// 服务
        /// </summary>
        [XmlElement("service")]
        public string  Service { set; get; }
    }
}
