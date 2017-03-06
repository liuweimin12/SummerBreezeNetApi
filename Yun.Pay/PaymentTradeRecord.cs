using System;
using System.Xml.Serialization;

namespace Yun.Pay
{
    public class PaymentTradeRecord
    {
        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 在线充值的款项
        /// </summary>
        [XmlElement("recharge")]
        public double Recharge { get; set; }

        /// <summary>
        /// 交易ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 商户支付订单号
        /// </summary>
        [XmlElement("merchant_trade_no")]
        public string MerchantTradeNo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }


        /// <summary>
        /// 充值卡支付金额
        /// </summary>
        [XmlElement("prepaid_card")]
        public double PrepaidCard { get; set; }


        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [XmlElement("total_amount")]
        public double TotalAmount { get; set; }


        /// <summary>
        /// 现金支付金额，包括POS机
        /// </summary>
        [XmlElement("cash")]
        public double Cash { get; set; }


        /// <summary>
        /// 余额支付金额
        /// </summary>
        [XmlElement("credit")]
        public double Credit { get; set; }


        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }


        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }


        /// <summary>
        /// 支付渠道
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }


        /// <summary>
        /// 线上支付方式
        /// </summary>
        [XmlElement("online_pay_type")]
        public string OnlinePayType { get; set; }

        /// <summary>
        /// 服务费
        /// </summary>
        [XmlElement("service_fee")]
        public double ServiceFee { get; set; }

        /// <summary>
        /// 收入方
        /// </summary>
        [XmlElement("income_pay_account_id")]
        public int IncomePayAccountId { get; set; }

        /// <summary>
        /// 收入方名称
        /// </summary>
        [XmlElement("income_pay_account_name")]
        public string IncomePayAccountName { get; set; }

        /// <summary>
        /// 支出方名称
        /// </summary>
        [XmlElement("expenditure_pay_account_name")]
        public string ExpenditurePayAccountName { get; set; }

        /// <summary>
        /// 支出方
        /// </summary>
        [XmlElement("expenditure_pay_account_id")]
        public int ExpenditurePayAccountId { get; set; }
    }
}
