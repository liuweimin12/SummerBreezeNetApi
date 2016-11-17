using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    [XmlRoot("get_the_latest_version_request")]
    public class GetTheLatestVersionResponse : YunResponse
    {
        /// <summary>
        /// 版本号信息
        /// </summary>
        [XmlElement("version")]
        public SiteVersion Version { get; set; }
    }
}
