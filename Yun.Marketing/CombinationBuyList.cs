using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class CombinationBuyList
    {
        /// <summary>
        /// 用户自定义的活动类型
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }

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
        /// 操作人ID
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }


        /// <summary>
        /// 促销活动ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 促销活动名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }


        /// <summary>
        /// 活动描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }


        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }


        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }


        /// <summary>
        /// 套餐价格
        /// </summary>
        [XmlElement("price")]
        public double Price { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
        [XmlElement("market_price")]
        public string MarketPrice { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [XmlElement("images")]
        public string Images { get; set; }
    }
}
