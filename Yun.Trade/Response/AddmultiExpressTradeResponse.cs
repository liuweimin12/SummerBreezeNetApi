using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
    public class AddmultiExpressTradeResponse : YunResponse
    {
        /// <summary>
        /// 返回购物车订单，电子券商品不能使用
        /// </summary>
        [XmlArray("trade_ids")]
        [XmlArrayItem("trade_id")]
        public List<string> TradeId { get; set; }
    }
}
