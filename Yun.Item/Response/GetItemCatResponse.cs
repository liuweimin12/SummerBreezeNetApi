using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    [XmlRoot("get_item_cat_response")]
    public class GetItemCatResponse : YunResponse
    {
        [XmlElement("item_cat")]
        public ItemCat ItemCat { get; set; }
    }
}
