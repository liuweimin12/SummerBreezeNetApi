using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Item
{
    public class GroupingShopItem
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }


        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("goodses")]
        [XmlArrayItem("goods")]
        public List<GoodsDetail> Goodses { get; set; }
    }
}
