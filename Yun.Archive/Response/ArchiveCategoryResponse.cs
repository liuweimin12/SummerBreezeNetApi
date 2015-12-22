using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Archive.Response
{
    public class ArchiveCategoryResponse : YunResponse
    {
        [XmlElement("category")]
        public ArticleCategory Category { get; set; }
    }
}
