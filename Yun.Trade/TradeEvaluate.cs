using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Trade
{
    public class TradeEvaluate
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_id")]
        public long OrderId { get; set; }


        /// <summary>
        /// 评价内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 评价时间
        /// </summary>
        [XmlElement("comment_time")]
        public string CommentTime { get; set; }

        /// <summary>
        /// 评价等级
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// 顾客选择的SKU信息
        /// </summary>
        [XmlArray("sku_names")]
        [XmlArrayItem("sku_name__list")]
        public List<YunKeyValuePair<string, string>> SkuNames { get; set; }

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
        /// 商品预览图的绝对路径
        /// </summary>
        [XmlElement("item_thumb")]
        public string ItemThumb { get; set; }

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
        /// 评价人用户ID
        /// </summary>
        [XmlElement("evaluate_user_id")]
        public int EvaluateUserId { get; set; }

        /// <summary>
        /// 评价人用户名
        /// </summary>
        [XmlElement("evaluate_user")]
        public string EvaluateUser { get; set; }
    }
}
