using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
    [XmlRoot("create_order_verification_response")]
    public class CreateOrderVerificationResponse : YunResponse
    {
        [XmlArray("item_buy_verification_results")]
        [XmlArrayItem("item_buy_verification_result")]
        public List<ItemBuyVerificationResult> ItemBuyVerificationResults { get; set; }
    }
}
