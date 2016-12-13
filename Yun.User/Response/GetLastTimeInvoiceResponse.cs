using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    [XmlRoot("get_lasttime_invoice_response")]
    public class GetLastTimeInvoiceResponse : YunResponse
    {
        [XmlElement("invoice")]
        public Invoice Invoice { get; set; }
    }
}
