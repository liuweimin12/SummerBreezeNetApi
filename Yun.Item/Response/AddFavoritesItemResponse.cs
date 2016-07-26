using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.Item.Response
{
    [XmlRoot("add_favorites_item_response")]
    public class AddFavoritesItemResponse: YunResponse
    {
        [XmlArray("results")]
        [XmlArrayItem("result__list")]
        public List<MultiState> Results { get; set; }
    }
}
