
using System.Xml.Serialization;

namespace Yun.Trade
{
    public class TradeStatisticsSummary
    {
        /// <summary>
        /// 销售量
        /// </summary>
        [XmlElement("sale_num")]
        public double SaleNum { get; set; }


        /// <summary>
        /// 销售额
        /// </summary>
        [XmlElement("sale_price")]
        public double SalePrice { get; set; }


        /// <summary>
        /// 交易笔数
        /// </summary>
        [XmlElement("sale_quantity")]
        public double SaleQuantity { get; set; }


        /// <summary>
        /// 客单价=商品平均单价×每一顾客平均购买商品个数
        /// </summary>
        [XmlElement("customer_price")]
        public double CustomerPrice { get; set; }


        /// <summary>
        /// 顾客数量
        /// </summary>
        [XmlElement("customer_num")]
        public double CustomerNum { get; set; }

        /// <summary>
        /// 在线付款金额
        /// </summary>
        [XmlElement("online_payment")]
        public double OnlinePayment { get; set; }


        /// <summary>
        /// 充值卡付款
        /// </summary>
        [XmlElement("prepaid_card_payment")]
        public double PrepaidCardPayment { get; set; }


        /// <summary>
        /// 余额付款
        /// </summary>
        [XmlElement("balance_payment")]
        public double BalancePayment { get; set; }


        /// <summary>
        /// 现金支付
        /// </summary>
        [XmlElement("cash_payment")]
        public double CashPayment { get; set; }
    }
}
