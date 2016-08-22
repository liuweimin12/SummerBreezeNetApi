using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    [XmlRoot("get_app_info_response")]
    public class GetAppInfoResponse:YunResponse
    {
        [XmlElement("app_info")]
        public AppInfo AppInfo { get; set; }
    }
}
