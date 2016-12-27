using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Trade
{
    public class ShopBasicInfo
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("contacts")]
        public string Contacts { get; set; }


        /// <summary>
        /// 店名
        /// </summary>
        [XmlElement("shop_title")]
        public string ShopTitle { get; set; }


        /// <summary>
        /// 店铺照片
        /// </summary>
        [XmlElement("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 营业时间
        /// </summary>
        [XmlElement("hours")]
        public string Hours { get; set; }

        /// <summary>
        /// 首页地址
        /// </summary>
        [XmlElement("home_page")]
        public string HomePage { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 联系地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 客服
        /// </summary>
        [XmlArray("customer_services")]
        [XmlArrayItem("customer_service")]
        public List<CustomerService> CustomerServices { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        [XmlElement("parent_id")]
        public int ParentId { get; set; }

    }
}
