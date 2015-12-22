using System.Xml.Serialization;

namespace Yun.Coupon
{
   public class CouponDetail
   {
       /// <summary>
       /// 电子券编号
       /// </summary>
       [XmlElement("coupon_id")]
       public string CouponId { get; set; }



       /// <summary>
       /// 核销时间
       /// </summary>
       [XmlElement("consume_time")]
       public string ConsumeTime { get; set; }


       /// <summary>
       /// 已消费的电子券数量
       /// </summary>
       [XmlElement("consume_quantity")]
       public int ConsumeQuantity { get; set; }



       /// <summary>
       /// 核销账号ID
       /// </summary>
       [XmlElement("consume_user_id")]
       public int ConsumeUserId { get; set; }

       /// <summary>
       /// 核销用户
       /// </summary>
       [XmlElement("consume_user")]
       public string ConsumeUser { get; set; }


       /// <summary>
       /// 是否核销
       /// </summary>
       [XmlElement("is_consume")]
       public bool IsConsume { get; set; }


       /// <summary>
       /// 过期时间
       /// </summary>
       [XmlElement("expired_time")]
       public string ExpiredTime { get; set; }


       /// <summary>
       /// 生效的开始时间
       /// </summary>
       [XmlElement("begin_time")]
       public string BeginTime { get; set; }


       /// <summary>
       /// 创建时间
       /// </summary>
       [XmlElement("create_time")]
       public string CreateTime { get; set; }


       /// <summary>
       /// 最近一次短信发送时间
       /// </summary>
       [XmlElement("sms_time")]
       public string SmsTime { get; set; }


       /// <summary>
       /// 短信发送次数
       /// </summary>
       [XmlElement("sms_count")]
       public int SmsCount { get; set; }


       [XmlElement("order_info")]
       public OrderInfo OrderInfo { get; set; }
   }
}
