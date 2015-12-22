using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    public class WeixinUnifiedorderResponse : YunResponse
    {
        [XmlElement("unifiedorder_result")]
        public UnifiedorderResult UnifiedorderResult { get; set; }
    }
}
