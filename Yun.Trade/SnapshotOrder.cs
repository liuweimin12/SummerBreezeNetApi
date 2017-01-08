
using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Trade
{
    public class SnapshotOrder 
    {

        /// <summary>
        /// 积分抵扣价格
        /// </summary>
        [XmlElement("integral_deduction_price")]
        public double IntegralDeductionPrice { get; set; }


        /// <summary>
        /// 促销信息
        /// </summary>
        [XmlElement("promotions_in_order")]
        public List<PromotionsInOrder> PromotionsInOrder { get; set; }

        /// <summary>
        /// 交易快照，当前商品详情
        /// </summary>
        [XmlElement("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// 已使用的数量
        /// </summary>
        [XmlElement("user_quantity")]
        public int UsedQuantity { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 商品预览图的绝对路径
        /// </summary>
        [XmlElement("thumb")]
        public string Thumb { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public int ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 所选择的SKUID
        /// </summary>
        [XmlElement("sku_id")]
        public int SkuId { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }


        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [XmlElement("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// 选择的商品单价
        /// </summary>
        [XmlElement("price")]
        public double Price { get; set; }

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
        /// 顾客选择的SKU信息
        /// </summary>
        [XmlArray("sku_names")]
        [XmlArrayItem("sku_name")]
        public List<YunKeyValuePair<string, string>> SkuNames { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 卖家是否评价
        /// </summary>
        [XmlElement("seller_rating")]
        public Comment SellerRating { get; set; }

        /// <summary>
        /// 买家是否评价
        /// </summary>
        [XmlElement("buyer_rating")]
        public Comment BuyerRating { get; set; }

        /// <summary>
        /// 外部订单ID
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }


        /// <summary>
        /// 手工调整金额.格式为:1.01;单位:元;精确到小数点后两位.
        /// </summary>
        [XmlElement("adjust_price")]
        public double AdjustPrice { get; set; }

        /// <summary>
        /// 子订单的交易结束时间
        /// 说明：子订单有单独的结束时间，与主订单的结束时间可能有所不同，在有退款发起的时候或者是主订单分阶段付款的时候，子订单的结束时间会早于主订单的结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 子订单发货时间
        /// </summary>
        [XmlElement("delivery_time")]
        public string DeliveryTime { get; set; }

        /// <summary>
        /// 创建交易时的物流方式（交易完成前，物流方式有可能改变，但系统里的这个字段一直不变）。
        /// 可选值：2(商家配送)，4(快递)，419(自提)，0(卖家包邮)，-1(虚拟发货)，16738(次日必达)，，16738(当日必达)，16740(预约配送)。
        /// </summary>
        [XmlElement("shipping_type")]
        public string ShippingType { get; set; }


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
        /// 扩展信息
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public int OrderType { get; set; }
    }
}
