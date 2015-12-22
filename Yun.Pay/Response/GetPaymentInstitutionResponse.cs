using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    public class GetPaymentInstitutionResponse : YunResponse
    {
        /// <summary>
        /// 使用的哪家第三方机构的网银直连
        /// </summary>
        [XmlElement("banking_direct_connect")]
        public string BankingDirectConnect { get; set; }

        /// <summary>
        /// 支持哪些付款方式
        /// </summary>
        [XmlElement("payment_code")]
        public string PaymentCode { get; set; }
    }
}
