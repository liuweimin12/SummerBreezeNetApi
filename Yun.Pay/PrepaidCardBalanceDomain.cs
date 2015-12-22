using System.Xml.Serialization;

namespace Yun.Pay
{
    public class PrepaidCardBalanceDomain
    {
        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 店铺名字
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        [XmlElement("company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// 公司名字
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 记录创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 统计日期
        /// </summary>
        [XmlElement("statistics_data")]
        public string StatisticsData { get; set; }

        /// <summary>
        /// 动作类型
        /// </summary>
        [XmlElement("balance")]
        public double Balance { get; set; }
    }
}
