using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Pay
{
    public class PrepaidCardTypeDomain
    {
        /// <summary>
        /// 充值卡类型ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 充值卡类型名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 充值卡类型，可进行自定义
        /// </summary>
        [XmlElement("card_type")]
        public int CardType { get; set; }

        /// <summary>
        /// 充值卡面值
        /// </summary>
        [XmlElement("money")]
        public double Money { get; set; }

        /// <summary>
        /// 当前充值卡类型所属的公司ID
        /// </summary>
        [XmlElement("company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// 当前充值卡类型所属的店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 当前充值卡类型是由谁创建的
        /// </summary>
        [XmlElement("creator_id")]
        public int CreatorId { get; set; }

        /// <summary>
        /// 当前充值卡类型的创建者
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreatetTme { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("card_count")]
        public int CardCount { get; set; }

        /// <summary>
        /// 使用数量
        /// </summary>
        [XmlElement("used_quantity")]
        public int UsedQuantity { get; set; }
    }
}
