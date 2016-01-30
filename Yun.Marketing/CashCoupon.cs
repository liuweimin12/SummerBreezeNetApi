using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class CashCoupon
    {
        /// <summary>
        /// 代金券ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 代金券编号，一个网站内的编号不能重复
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }


        /// <summary>
        /// 适用范围
        /// </summary>
        [XmlElement("range")]
        public int Range { get; set; }


        /// <summary>
        /// 最低金额
        /// </summary>
        [XmlElement("min_price")]
        public double MinPrice { get; set; }

        /// <summary>
        /// 代金券有效期开始
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }


        /// <summary>
        /// 代金券过期时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }


        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public int OrderId { get; set; }

        /// <summary>
        /// 面值
        /// </summary>
        [XmlElement("credit")]
        public double Credit { get; set; }


        /// <summary>
        /// 使用状态
        /// </summary>
        [XmlElement("status")]
        public int Status { get; set; }


        /// <summary>
        /// 绑定的用户ID
        /// </summary>
        [XmlElement("bind_user_id")]
        public int BindUserId { get; set; }

        /// <summary>
        /// 绑定的用户
        /// </summary>
        [XmlElement("bind_user_name")]
        public string BindUserName { get; set; }


        /// <summary>
        /// 绑定时间
        /// </summary>
        [XmlElement("bind_time")]
        public string BindTime { get; set; }

        /// <summary>
        /// 代金券名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 代金券类型
        /// </summary>
        [XmlElement("coupon_type")]
        public string CouponType { get; set; }
    }
}
