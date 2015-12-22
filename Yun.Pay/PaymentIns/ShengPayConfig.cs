
using System.Xml.Serialization;

namespace Yun.Pay.PaymentIns
{
    public class ShengPayConfig
    {
        [XmlElement("key")]
        public string Key { get; set; }

        [XmlElement("msg_sender")]
        public string MsgSender { get; set; }

    }
}
