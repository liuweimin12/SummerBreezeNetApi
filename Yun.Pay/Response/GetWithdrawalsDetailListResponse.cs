using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_withdrawals_detail_list_response")]
    public class GetWithdrawalsDetailListResponse : YunResponse
    {
        [XmlArray("withdrawals_details")]
        [XmlArrayItem("withdrawals_detail")]
        public List<WithdrawalsDetail> WithdrawalsDetails { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
