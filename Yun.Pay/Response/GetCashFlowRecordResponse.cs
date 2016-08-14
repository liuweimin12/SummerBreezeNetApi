using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_cash_flow_record_response")]
    public class GetCashFlowRecordResponse : YunResponse
    {
        [XmlElement("cash_flow_record")]
        public FlowRecord CashFlowRecord { get; set; }
    }
}
