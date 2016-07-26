using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.Item.Response
{
    [XmlRoot("delete_favorites_item_response")]
    public class DeleteFavoritesItemResponse : YunResponse
    {
        [XmlArray("results")]
        [XmlArrayItem("result__list")]
        public List<MultiState> Results { get; set; }
    }
}
