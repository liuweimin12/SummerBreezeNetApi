using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    [XmlRoot("get_grouping_shop_item_response")]
    public class GetGroupingShopItemResponse : YunResponse
    {
        /// <summary>
        /// 按照店铺分组的商品
        /// </summary>
        [XmlArray("grouping_shop_items")]
        [XmlArrayItem("grouping_shop_item")]
        public List<GroupingShopItem> GroupingShopItems { get; set; }
    }
}
