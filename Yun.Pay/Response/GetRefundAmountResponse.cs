using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_refund_amount_response")]
    public class GetRefundAmountResponse : YunResponse
    {
        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_money")]
        public RefundMoney RefundMoney { get; set; }
    }
}
