using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.Item.Response
{
    public class GetPrevsItemCatsResponse : YunResponse
    {
        [XmlArray("item_cats")]
        [XmlArrayItem("item_cat")]
        public List<LongKeyValuePair> ItemCats { get; set; }
    }
}
