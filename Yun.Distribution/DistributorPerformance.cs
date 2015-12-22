using System.Xml.Serialization;

namespace Yun.Distribution
{
    public class DistributorPerformance
    {
        /// <summary>
        /// 未付款订单金额
        /// </summary>
        [XmlElement("not_paid_trade")]
        public double NotPaidTrade { get; set; }

        /// <summary>
        /// 总交易金额
        /// </summary>
        [XmlElement("total_trade_money")]
        public double TotalTradeMoney { get; set; }

        /// <summary>
        /// 总获利金额
        /// </summary>
        [XmlElement("total_profit")]
        public double TotalProfit { get; set; }



        /// <summary>
        /// 已支付订单金额
        /// </summary>
        [XmlElement("paid_trade")]
        public double PaidTrade { get; set; }


        /// <summary>
        /// 已发货订单总额
        /// </summary>
        [XmlElement("has_delivery")]
        public double HasDelivery { get; set; }


        /// <summary>
        /// 已确认订单总额
        /// </summary>
        [XmlElement("has_confirm")]
        public double HasConfirm { get; set; }



        /// <summary>
        /// 已付款购买人数
        /// </summary>
        [XmlElement("paid_total_buyer")]
        public int PaidTotalBuyer { get; set; }


        /// <summary>
        /// 已付款订单数量
        /// </summary>
        [XmlElement("paid_trade_num")]
        public int PaidTradeNum { get; set; }

        /// <summary>
        /// 已支付订单可获得利润
        /// </summary>
        [XmlElement("paid_profit")]
        public double PaidProfit { get; set; }


        /// <summary>
        /// 已发货订单可获得利润
        /// </summary>
        [XmlElement("has_delivery_profit")]
        public double HasDeliveryProfit { get; set; }


        /// <summary>
        /// 已确认收货订单可获得利润
        /// </summary>
        [XmlElement("has_confirm_profit")]
        public double HasConfirmProfit { get; set; }
    }
}
