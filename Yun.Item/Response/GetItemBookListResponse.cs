using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Interface;
using Yun.Response;

namespace Yun.Item.Response
{
    [XmlRoot("get_item_book_list_response")]
    public class GetItemBookListResponse:YunResponse
    {
        [XmlArray("item_books")]
        [XmlArrayItem("item_book")]
        public List<ItemBookDomain> ItemBooks { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
