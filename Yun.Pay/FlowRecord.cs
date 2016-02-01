using System;
using System.Xml.Serialization;

namespace Yun.Pay
{
    public class FlowRecord
    {
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
        /// 资金流入流程类型
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }


        /// <summary>
        /// 订单最后修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }


        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string  CreateTime { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string  TotalAmount { get; set; }


        /// <summary>
        /// 现金支付金额，包括POS机
        /// </summary>
        [XmlElement("cash")]
        public string  Cash { get; set; }


        /// <summary>
        /// 余额支付金额
        /// </summary>
        [XmlElement("credit")]
        public string  Credit { get; set; }


        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 本方用户ID
        /// </summary>
        [XmlElement("owner_user_id")]
        public long OwnerUserId { get; set; }


        /// <summary>
        /// 本方用户名
        /// </summary>
        [XmlElement("owner_name")]
        public string OwnerName { get; set; }


        /// <summary>
        /// 对方用户ID
        /// </summary>
        [XmlElement("opposite_user_id")]
        public string OppositeUserId { get; set; }

        /// <summary>
        /// 对方用户名
        /// </summary>
        [XmlElement("opposite_name")]
        public string OppositeName { get; set; }

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
        /// 余额快照
        /// </summary>
        [XmlElement("balance_snapshot")]
        public double BalanceSnapshot { get; set; }


        /// <summary>
        /// 充值卡余额快照
        /// </summary>
        [XmlElement("prepaid_card_snapshot")]
        public double PrepaidCardSnapshot { get; set; }
		
		
		/// <summary>
        /// 充值卡支付金额
        /// </summary>
        [XmlElement("prepaid_card")]
        public double PrepaidCard { get; set; }
    }
}
