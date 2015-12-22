using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    public class GetCompanyPaymentRateResponse:YunResponse
    {
        /// <summary>
        /// 返回公司/站点的抽成比例
        /// </summary>
        [XmlElement("online_payment_rate")]
        public OnlinePayRate Result { get; set; }
    }
}
