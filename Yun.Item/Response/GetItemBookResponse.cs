using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    [XmlRoot("get_item_book_response")]
    public class GetItemBookResponse:YunResponse
    {
        [XmlElement("item_book")]
        public ItemBookDomain ItemBook { get; set; }
    }
}
