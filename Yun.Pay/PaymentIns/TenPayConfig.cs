
using System.Xml.Serialization;

namespace Yun.Pay.PaymentIns
{
    public class TenPayConfig
    {
        //商户号
        [XmlElement("bargainor_id")]
        public string BargainorId { get; set; }

        //密钥
        [XmlElement("key")]
        public string Key { get; set; }
    }
}
