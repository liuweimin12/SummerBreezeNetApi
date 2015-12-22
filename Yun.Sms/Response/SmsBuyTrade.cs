using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Sms.Response
{
    public class SmsBuyTrade : YunResponse
    {
        /// <summary>
        /// 短信购买ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 交易状态
        /// Unpay，Paied
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 购买的价格
        /// </summary>
        [XmlElement("price")]
        public double Price { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("Create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 购买者名字
        /// </summary>
        [XmlElement("buyer")]
        public string Buyer { get; set; }

        /// <summary>
        /// 卖家名字
        /// </summary>
        [XmlElement("seller_name")]
        public string SellerName { get; set; }
    }
}
