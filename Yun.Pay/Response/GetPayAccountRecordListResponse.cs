using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_pay_account_record_list_response")]
    public class GetPayAccountRecordListResponse : YunResponse, IPageResponse
    {
        [XmlArray("pay_account_balance_list")]
        [XmlArrayItem("pay_account_balance")]
        public List<PayAccountBalance> PayAccountBalanceList { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
