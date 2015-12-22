using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Archive.Response
{
    public class ArchiveDetailResponse : YunResponse
    {
        [XmlElement("article")]
        public ArticleDetail Article { get; set; }
    }
}
