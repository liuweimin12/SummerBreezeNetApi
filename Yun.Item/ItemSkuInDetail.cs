using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Item
{
    public class ItemSkuInDetail
    {
        /// <summary>
        /// 缩略图
        /// </summary>
        public string images { get; set; } 

        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 规格值IDs(ItemSpecValue)
        /// </summary>
        [XmlArray("spec_ids")]
        [XmlArrayItem("spec_id")]
        public List<long> SpecIds { get; set; }

        [XmlArray("spec_names")]
        [XmlArrayItem("spec_name")]
        public List<StringKeyValuePair> SpecNames { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
         [XmlElement("price")]
        public string  Price { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
         [XmlElement("stock")]
        public long Stock { get; set; }


        /// <summary>
        /// 商品sku编码
        /// </summary>
         [XmlElement("sku_code")]
        public string SkuCode { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
         [XmlElement("market_price")]
        public string  MarketPrice { get; set; }

        /// <summary>
        /// 附加信息
        /// </summary>
         [XmlElement("additional_info")]
        public string AdditionalInfo { get; set; }
    }
}
