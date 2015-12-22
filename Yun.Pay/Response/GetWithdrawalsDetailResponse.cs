using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_withdrawals_detail_response")]
    public class GetWithdrawalsDetailResponse : YunResponse
    {
        [XmlElement("withdrawals_detail")]
        public WithdrawalsDetail WithdrawalsDetail { get; set; }
    }
}
