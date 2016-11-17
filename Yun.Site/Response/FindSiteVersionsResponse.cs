using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    [XmlRoot("find_site_versions_response")]
    public class FindSiteVersionsResponse: YunResponse
    {
        [XmlArray("versions")]
        [XmlArrayItem("version")]
        public List<SiteVersion> Versios { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
