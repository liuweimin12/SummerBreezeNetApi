using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_payment_orders_response")]
    public class GetPaymentOrdersResponse : YunResponse, IPageResponse
    {
        [XmlArray("payment_trade_records")]
        [XmlArrayItem("payment_trade_record")]
        public List<PaymentTradeRecord> PaymentTradeRecords { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
