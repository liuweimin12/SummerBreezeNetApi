using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_prepaid_card_balance_response")]
    public class GetPrepaidCardBalanceResponse : YunResponse, IPageResponse
    {
        [XmlArray("prepaid_card_balances")]
        [XmlArrayItem("prepaid_card_balance")]
        public List<PrepaidCardBalanceDomain> PrepaidCardBalances { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
