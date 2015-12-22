using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Site
{
    public class SubscriptionModel
    {
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 订阅者信息
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 网站ID
        /// </summary>
        [XmlElement("site_id")]
        [XmlIgnore]
        public int SiteId { get; set; }

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
    }
}
