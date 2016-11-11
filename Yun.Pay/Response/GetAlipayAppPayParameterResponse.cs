using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_alipay_app_pay_parameter_response")]
    public class GetAlipayAppPayParameterResponse : YunResponse
    {
        [XmlElement("alipay_app_pay_parameter")]
        public AlipayAppPayParameter AlipayAppPayParameter { get; set; }
    }
}
