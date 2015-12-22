using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Logistics
{
    public class ShippingRecord
    {
        /// <summary>
        /// 记录ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public int OrderId { get; set; }

        /// <summary>
        /// 发货方式名字
        /// </summary>
        [XmlElement("express_name")]
        public string DeliveryName { get; set; }

        /// <summary>
        ///单号
        /// </summary>
        [XmlElement("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 留言
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 发货方式的英文名，一般当作标识用
        /// </summary>
        [XmlElement("express_en_name")]
        public string DeliveryId { get; set; }
    }
}
