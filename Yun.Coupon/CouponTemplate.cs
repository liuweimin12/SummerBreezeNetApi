using System.Xml.Serialization;

namespace Yun.Coupon
{
    public class CouponTemplate
    {
        /// <summary>
        /// 电子券模板ID
        /// </summary>
        [XmlElement("id")]
        public long  Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 发送类型
        /// </summary>
        [XmlElement("send_type")]
        public string SendType { get; set; }

        /// <summary>
        /// 消费支付
        /// </summary>
        [XmlElement("consumed_pay")]
        public bool ConsumedPay { get; set; }

        /// <summary>
        /// 过期退款
        /// </summary>
        [XmlElement("expired_refund")]
        public bool ExpiredRefund { get; set; }


        /// <summary>
        /// 自动退款
        /// </summary>
        [XmlElement("auto_refund")]
        public bool AutoRefund { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }


        /// <summary>
        /// 使用自定义电子券
        /// </summary>
        [XmlElement("use_custom_coupon")]
        public bool UseCustomCoupon { get; set; }
    }
}
