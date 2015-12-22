
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    [XmlRoot("get_module_response")]
    public class GetPageModuleResponse : YunResponse
    {
        [XmlElement("page_module")]
        public SiteModule PageModule { get; set; }
    }
}
