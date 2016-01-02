using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    public class GetAuthorizeUrlResponse : YunResponse
    {
        [XmlArray("authorize_urls")]
        [XmlArrayItem("authorize_url")]
        public List<AuthorizeUrl> AuthorizeUrls { get; set; }
    }
}
