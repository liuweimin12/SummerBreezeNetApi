using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Trade
{
    public class TradeStatistics
    {
        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

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
        /// 商品的全局类目最后一级ID
        /// </summary>
        [XmlElement("item_cats_id")]
        public int ItemCatsId { get; set; }


        /// <summary>
        /// 统计日期
        /// </summary>
        [XmlElement("statistics_data")]
        public string StatisticsData { get; set; }


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
        /// 客单价=商品平均单价×每一顾客平均购买商品个数
        /// </summary>
        [XmlElement("customer_price")]
        public double CustomerPrice { get; set; }


        /// <summary>
        /// 顾客数量
        /// </summary>
        [XmlElement("customer_num")]
        public string CustomerNum { get; set; }

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
        /// 最小客单价
        /// </summary>
        [XmlElement("min_customer_price")]
        public double MinCustomerPrice { get; set; }


        /// <summary>
        /// 最大客单价
        /// </summary>
        [XmlElement("max_customer_price")]
        public double MaxCustomerPrice { get; set; }
    }
}
