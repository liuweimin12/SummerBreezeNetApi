using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
    [XmlRoot("get_express_fee_price_response")]
    public class GetExpressFeePriceResponse: YunResponse
    {
        /// <summary>
        /// 运费
        /// </summary>
        [XmlElement("price")]
        public double Price { get; set; }
    }
}
