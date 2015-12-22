using System.Xml.Serialization;

namespace Yun.Coupon
{
    public class CustomCoupon
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [XmlElement("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// 自定义电子券ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public int ItemId { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }
    }
}