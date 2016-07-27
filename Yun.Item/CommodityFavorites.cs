using System.Xml.Serialization;

namespace Yun.Item
{
    public class CommodityFavorites
    {
        /// <summary>
        /// 收藏ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }


        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public int ItemId { get; set; }

        /// <summary>
        /// 收藏时间
        /// </summary>
        [XmlElement("createtime")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 收藏时价格
        /// </summary>
        [XmlElement("collected_price")]
        public double CollectedPrice { get; set; }

        /// <summary>
        /// 收藏时标题
        /// </summary>
        [XmlElement("collected_title")]
        public string CollectedTitle { get; set; }

        /// <summary>
        /// 收藏时商品主图
        /// </summary>
        [XmlElement("collected_thumb")]
        public string CollectedThumb { get; set; }

        /// <summary>
        /// 现价
        /// </summary>
        [XmlElement("now_price")]
        public double NowPrice { get; set; }


        /// <summary>
        /// 是否失效
        /// </summary>
        [XmlElement("is_invalid")]
        public bool IsInvalid { get; set; }


        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
        [XmlElement("collected_market_price")]
        public double CollectedMarketPrice { get; set; }
    }
}
