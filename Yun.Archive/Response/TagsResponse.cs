using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Archive.Response
{
    public class TagsResponse : YunResponse, IPageResponse
    {
        [XmlArray("tags")]
        [XmlArrayItem("tag")]
        public List<Tag> Tags { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
