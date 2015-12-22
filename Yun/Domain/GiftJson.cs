
using System.Xml.Serialization;

namespace Yun.Domain
{
    public class GiftJson
    {
        /// <summary>
        /// 需要赠送的商品名字
        /// </summary>
        [XmlElement("gift_id")]
        public int gift_id { get; set; }

        /// <summary>
        /// 需要赠送的商品标题
        /// </summary>
        [XmlElement("gift_title")]
        public string gift_title { get; set; }


        /// <summary>
        /// 礼品描述
        /// </summary>
        [XmlElement("gift_description")]
        public string gift_description { get; set; }


        /// <summary>
        /// 礼品的URL指向
        /// </summary>
        [XmlElement("gift_url")]
        public string gift_url { get; set; }
    }
}
