using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Private.Response
{
    [XmlRoot("get_app_info_response")]
    public class GetAppInfoResponse:YunResponse
    {
        [XmlElement("app_info")]
        public AppInfo AppInfo { get; set; }
    }
}
