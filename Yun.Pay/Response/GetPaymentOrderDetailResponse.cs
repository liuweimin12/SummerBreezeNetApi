using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_payment_order_detail_response")]
    public class GetPaymentOrderDetailResponse : YunResponse
    {
        [XmlElement("payment_trade_record")]
        public PaymentTradeRecord PaymentTradeRecord { get; set; }
    }
}
