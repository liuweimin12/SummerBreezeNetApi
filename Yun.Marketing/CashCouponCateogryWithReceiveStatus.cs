using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class CashCouponCateogryWithReceiveStatus
    {
        /// <summary>
        /// 已经领取
        /// </summary>
        [XmlElement("has_received")]
        public bool HasReceived { get; set; }

        /// <summary>
        /// 显示位置
        /// </summary>
        [XmlElement("display_position")]
        public int DisplayPosition { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }


        /// <summary>
        /// 代金券类型ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }


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
        /// 代金券类型名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }



        /// <summary>
        /// 代金券类型
        /// </summary>
        [XmlElement("coupon_type")]
        public string CouponType { get; set; }


        /// <summary>
        /// 代金券发放数量
        /// </summary>
        [XmlElement("quantity")]
        public int Quantity { get; set; }


        /// <summary>
        /// 代金券使用数量
        /// </summary>
        [XmlElement("has_used")]
        public int HasUsed { get; set; }


        /// <summary>
        /// 代金券领取数量
        /// </summary>
        [XmlElement("has_bind")]
        public int HasBind { get; set; }


        /// <summary>
        /// 每用户最多领取数量
        /// </summary>
        [XmlElement("per_user_max_quantity")]
        public int PerUserMaxQuantity { get; set; }

    }
}
