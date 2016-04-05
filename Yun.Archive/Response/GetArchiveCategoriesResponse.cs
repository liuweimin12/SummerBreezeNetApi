using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Archive.Response
{
    public class GetArchiveCategoriesResponse : YunResponse
    {
        [XmlArray("categories")]
        [XmlArrayItem("category")]
        public List<ArticleCategory> Categorys { get; set; }
    }
}
