using System.Xml.Serialization;

namespace Yun.Pay
{
    public class ShopPrepaidCardStatisticsDomain
    {
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
        /// 金额
        /// </summary>
        [XmlElement("create_money")]
        public double CreateMoney { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("bind_money")]
        public double BindMoney { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("used_money")]
        public double UsedMoney { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("unbind_money")]
        public double UnBindMoney { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("refund_money")]
        public double RefundMoney { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("modify_money")]
        public double ModifyMoney { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("expired_money")]
        public double ExpiredMoney { get; set; }
    }
}
