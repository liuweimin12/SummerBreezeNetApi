using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Trade
{
    public class SnapshotTrade
    {
        /// <summary>
        /// 区域ID
        /// </summary>
        [XmlElement("location_ids")]
        public string LocationIds { get; set; }


        /// <summary>
        /// 关闭订单/退款理由
        /// </summary>
        [XmlElement("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 丢弃理由
        /// </summary>
        [XmlElement("trade_reason")]
        public string DropReason { get; set; }

        /// <summary>
        /// 订单
        /// </summary>
        [XmlArray("orders")]
        [XmlArrayItem("order")]
        public List<SnapshotOrder> Orders { get; set; }

        [XmlElement("company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// 买家用户ID
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 买家用户名
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 店铺名
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺联系方式，包括QQ或者旺旺
        /// </summary>
        [XmlArray("shop_contacts")]
        [XmlArrayItem("shop_contact")]
        public List<CustomerService> ShopContact { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("parrner_id")]
        public int PartnerId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [XmlElement("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [XmlElement("zipcode")]
        public string Zipcode { get; set; }

        /// <summary>
        /// 送货地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 是否是快递订单
        /// </summary>
        [XmlElement("is_coupon")]
        public bool IsCoupon { get; set; }

        /// <summary>
        /// 系统固定留言，例如送货时间等
        /// </summary>
        [XmlElement("system_remark")]
        public string SystemRemark { get; set; }

        /// <summary>
        /// 顾客选择的运送方式
        /// 可选值：2(商家配送)，4(快递)，419(自提)，0(卖家包邮)，-1(虚拟发货)，16738(次日必达)，16738(当日必达)，16740(预约配送)。
        /// </summary>
        [XmlElement("shipping_type")]
        public string ShippingType { get; set; }

        /// <summary>
        /// 实付款
        /// </summary>
        [XmlElement("money")]
        public double Money { get; set; }


        /// <summary>
        /// 总款
        /// </summary>
        [XmlElement("total_funds")]
        public double TotalFunds { get; set; }


        /// <summary>
        /// 积分支付，此处显示的已经换算成金额
        /// </summary>
        [XmlElement("credit")]
        public double Credit { get; set; }

        /// <summary>
        /// 运费
        /// </summary>
        [XmlElement("fare")]
        public double Fare { get; set; }

        /// <summary>
        /// 买家留言
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 买家备注
        /// </summary>
        [XmlElement("buyer_memo")]
        public string BuyerMemo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 支付ID
        /// </summary>
        [XmlElement("pay_id")]
        public string PayId { get; set; }

        /// <summary>
        /// 是否是货到付款
        /// </summary>
        [XmlElement("cod_status")]
        public string CodStatus { get; set; }


        /// <summary>
        /// 商家备注，只有卖家自己能看到
        /// </summary>
        [XmlElement("seller_memo")]
        public MemoModel SellerMemo { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 发货时间
        /// </summary>
        [XmlElement("delivery_time")]
        public string DeliveryTime { get; set; }

        /// <summary>
        /// 确认收货时间
        /// </summary>
        [XmlElement("confirm_time")]
        public string ConfirmTime { get; set; }


        /// <summary>
        /// 交易结束时间。交易成功时间(更新交易状态为成功的同时更新)/确认收货时间或者交易关闭时间。
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }


        /// <summary>
        /// 卖家是否评价
        /// </summary>
        [XmlElement("seller_rating")]
        public bool SellerRating { get; set; }

        /// <summary>
        /// 买家是否评价
        /// </summary>
        [XmlElement("buyer_rating")]
        public bool BuyerRating { get; set; }


        /// <summary>
        /// 流量来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 服务
        /// </summary>
        [XmlElement("service")]
        public string Service { get; set; }


        /// <summary>
        /// 付款情况
        /// </summary>
        [XmlElement("payment_info")]
        public PaymentInfo PaymentInfo { get; set; }

        /// <summary>
        /// 发货公司名字
        /// </summary>
        [XmlElement("delivery_name")]
        public string DeliveryName { get; set; }


        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("tracking_number")]
        public string TrackingNumber { get; set; }


        /// <summary>
        /// 公司名字
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 促销信息
        /// </summary>
        [XmlElement("promotions_in_order")]
        public List<PromotionsInOrder> PromotionsInOrder { get; set; }

        /// <summary>
        /// 系统备注
        /// </summary>
        [XmlElement("system_memo")]
        public string SystemMemo { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        [XmlElement("invoice_title")]
        public string InvoiceTitle { get; set; }

        /// <summary>
        /// 发票内容
        /// </summary>
        [XmlElement("invoice_content")]
        public string InvoiceContent { get; set; }

        /// <summary>
        /// 代金券抵扣金额
        /// </summary>
        [XmlElement("cash_coupon")]
        public double CashCoupon { get; set; }
    }
}
