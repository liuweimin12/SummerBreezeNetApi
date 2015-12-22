
using System.Xml.Serialization;

namespace Yun.Trade
{
    public class MonthTradeStatistics
    {

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        [XmlElement("company_id")]
        public int CompanyId { get; set; }


        /// <summary>
        /// 销售量
        /// </summary>
        [XmlElement("sale_num")]
        public int SaleNum { get; set; }


        /// <summary>
        /// 销售额
        /// </summary>
        [XmlElement("sale_price")]
        public double SalePrice { get; set; }


        /// <summary>
        /// 交易笔数
        /// </summary>
        [XmlElement("sale_quantity")]
        public int SaleQuantity { get; set; }



        /// <summary>
        /// 顾客数量
        /// </summary>
        [XmlElement("customer_num")]
        public int CustomerNum { get; set; }

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


        /// <summary>
        /// 月份
        /// </summary>
        [XmlElement("month")]
        public int Month { get; set; }

        /// <summary>
        /// 年
        /// </summary>
        [XmlElement("year")]
        public int Year { get; set; }
    }
}
