using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    [XmlRoot("get_child_appinfo_response")]
    public class GetChildAppInfoResponse : YunResponse
    {
        [XmlArray("app_infos")]
        [XmlArrayItem("app_info")]
        public List<AppInfo> AppInfos { get; set; }
    }
}
