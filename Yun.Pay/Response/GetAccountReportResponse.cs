using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_accout_report_response")]
    public class GetAccountReportResponse : YunResponse, IPageResponse
    {
        [XmlArray("cash_flow_records")]
        [XmlArrayItem("cash_flow_record")]
        public List<FlowRecord> CashFlowRecords { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }

    }
}
