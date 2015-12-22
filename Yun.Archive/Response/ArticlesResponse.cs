using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Archive.Response
{
    public class ArticlesResponse : YunResponse, IPageResponse
    {
        [XmlArray("articles")]
        [XmlArrayItem("article")]
        public List<ArticleDetail> Articles { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
