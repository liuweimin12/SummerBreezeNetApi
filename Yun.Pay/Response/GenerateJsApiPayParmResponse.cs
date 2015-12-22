using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("generate_js_api_pay_parm_response")]
    public class GenerateJsApiPayParmResponse : YunResponse
    {
        [XmlElement("js_api_pay_result")]
        public JsApiPayResult JsApiPayResult { get; set; }
    }
}
