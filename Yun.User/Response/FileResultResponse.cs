using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    public class FileResultResponse : YunResponse
    {
        [XmlArray("file_urls")]
        [XmlArrayItem("file_url")]
        public List<string> Files { get; set; }
    }
}
