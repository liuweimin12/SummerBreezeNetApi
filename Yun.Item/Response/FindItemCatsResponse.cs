using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    [XmlRoot("find_item_cats_response")]
    public class FindItemCatsResponse : YunResponse, IPageResponse
    {
        [XmlArray("item_cats")]
        [XmlArrayItem("item_cat")]
        public List<ItemCat> ItemCats { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
