using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    [XmlRoot("get_site_version_response")]
    public class GetSiteVersionResponse : YunResponse
    {
        [XmlElement("site_version")]
        public SiteVersion SiteVersion { get; set; }
    }
}
