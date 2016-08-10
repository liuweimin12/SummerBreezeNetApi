using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Archive.Response
{
    [XmlRoot("get_archive_tag_response")]
    public class GetArchiveTagResponse : YunResponse
    {
        [XmlElement("tag")]
        public Tag Tag { get; set; }
    }
}
