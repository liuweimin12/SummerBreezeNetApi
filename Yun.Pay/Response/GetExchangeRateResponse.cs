using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_exchange_rate_response")]
    public class GetExchangeRateResponse : YunResponse
    {
        /// <summary>
        /// 汇率
        /// </summary>
        [XmlElement("exchange_rate")]
        public ExchangeRate ExchangeRate { get; set; }
    }
}
