using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Item
{
    public  class ItemBookDomain
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 预定ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public int ItemId { get; set; }

        /// <summary>
        /// 商品的SKUID
        /// </summary>
        [XmlElement("sku_id")]
        public int SkuId { get; set; }

        /// <summary>
        /// 预定的数量
        /// </summary>
        [XmlElement("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// 预定人手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 预定人姓名
        /// </summary>
        [XmlElement("booker_name")]
        public string BookerName { get; set; }

        /// <summary>
        /// 预定人的用户ID
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 预定人的用户名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 预定信息属于哪个店铺
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 预定信息属于哪个公司
        /// </summary>
        [XmlElement("company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 预定状态，可以自定义，默认为0
        /// </summary>
        [XmlElement("status")]
        public int Status { get; set; }

        /// <summary>
        /// 预定的修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 当时所选择的商品的SKU名字
        /// </summary>
        [XmlArray("sku_names")]
        [XmlArrayItem("sku_name")]
        public List<YunKeyValuePair<string, string>> SkuNames { get; set; }

    }
}
