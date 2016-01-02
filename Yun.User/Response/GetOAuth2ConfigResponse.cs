using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    public class GetOAuth2ConfigResponse: YunResponse
    {
        [XmlArray("settings")]
        [XmlArrayItem("setting")]
        public List<OAuth2Setting> Settings { get; set; }
    }
}