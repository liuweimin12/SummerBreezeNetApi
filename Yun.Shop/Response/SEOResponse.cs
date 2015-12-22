using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.Shop.Response
{
    public class SeoResponse : YunResponse
    {
        /// <summary>
        /// : ChengResponse
        /// </summary>
        [XmlElement("seo")]
        public SeoInfo SEO { get; set; }
    }
}
