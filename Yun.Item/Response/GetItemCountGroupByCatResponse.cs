using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    [XmlRoot("get_itemcount_groupby_cat_response")]
    public class GetItemCountGroupByCatResponse : YunResponse
    {
        [XmlArray("items_group_by_cat")]
        [XmlArrayItem("item_group_by_cat")]
        public List<ItemGroupByCat> ItemsGroupByCat { get; set; }
    }
}
