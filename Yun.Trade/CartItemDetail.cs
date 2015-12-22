using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Trade
{
    public class CartItemDetail
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public int ItemId { get; set; }

        /// <summary>
        /// 具体的SKU信息，例如：颜色，黄色；尺码：L码
        /// </summary>
        [XmlArray("sku_info")]
        [XmlArrayItem("sku_info")]
        public List<StringKeyValuePair> SkuInfo { get; set; }

        /// <summary>
        /// 零售价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }


        /// <summary>
        /// 市场价格
        /// </summary>
        [XmlElement("market_price")]
        public string MarketPrice { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("product")]
        public string Product { get; set; }

        /// <summary>
        /// SKUID
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [XmlElement("max_store")]
        public long MaxStore { get; set; }

        /// <summary>
        /// 附加信息
        /// </summary>
        [XmlElement("additional")]
        public string Additional { get; set; }


        /// <summary>
        /// 商品缩略图
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }


        /// <summary>
        /// 商品状态（1出售中，2库中）
        /// </summary>
        [XmlElement("item_state")]
        public long ItemState { get; set; }


        /// <summary>
        /// KEY：快递的英文名字
        /// VALUE：快递的中文解释
        /// </summary>
        [XmlArray("support_expresses_detail")]
        [XmlArrayItem("support_express_detail")]
        public List<StringKeyValuePair> SupportExpresses { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        [XmlElement("weight")]
        public double Weight { get; set; }

        /// <summary>
        /// 体积
        /// </summary>
        [XmlElement("volume")]
        public double Volume { get; set; }


        /// <summary>
        /// 积分限制
        /// </summary>
        [XmlElement("integral_limit")]
        public int Integrallimit { get; set; }

        /// <summary>
        /// 商品的扩展信息字段
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }
    }
}
