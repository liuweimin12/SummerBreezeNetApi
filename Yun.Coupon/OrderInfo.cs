using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Coupon
{
    public class OrderInfo
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public int OrderId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 商品缩略图
        /// </summary>
        [XmlElement("item_image")]
        public string ItemImage { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public int ItemId { get; set; }

        [XmlArray("item_sku_names")]
        [XmlArrayItem("item_sku_name")]
        public List<StringKeyValuePair> ItemSku { get; set; }

        /// <summary>
        /// 电子券关联订单购买的总数量
        /// </summary>
        [XmlElement("buy_quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// 电子券关联订单剩余数量
        /// </summary>
        [XmlElement("used_quantity")]
        public int UsedQuantity { get; set; }

        /// <summary>
        /// 电子券所属店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 电子券所属店铺名
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 发送方式
        /// </summary>
        [XmlElement("send_type")]
        public string SendType { get; set; }


        /// <summary>
        /// 接收手机号
        /// </summary>
        [XmlElement("receive_phone")]
        public string ReceivePhone { get; set; }

        /// <summary>
        /// 买家用户ID
        /// </summary>
        [XmlElement("buyer_id")]
        public int BuyerId { get; set; }


        /// <summary>
        /// 买家用户名
        /// </summary>
        [XmlElement("buyer")]
        public string Buyer { get; set; }
    }
}
