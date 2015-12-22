using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    public class OnlinePaymentResponse : YunResponse
    {
        [XmlElement("online_payment_setting")]
        public OnlinePaymentSetting Setting { get; set; }
    }
}
