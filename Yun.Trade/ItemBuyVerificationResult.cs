
using System.Xml.Serialization;

namespace Yun.Trade
{
    public class ItemBuyVerificationResult
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        [XmlElement("item_id")]
        public int ItemId { get; set; }

        /// <summary>
        /// 选择属性
        /// </summary>
        [XmlElement("sku_id")]
        public int SkuId { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public int Result { get; set; }
    }
}
