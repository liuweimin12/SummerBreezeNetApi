using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Pay
{
    public class PrepaidCardDomain
    {
        /// <summary>
        /// 充值卡余额
        /// </summary>
        [XmlElement("balance")]
        public double Balance { get; set; }

        /// <summary>
        /// 充值卡ID
        /// </summary>
        [XmlElement("prepaid_card_id")]
        public int PrepaidCardId { get; set; }

        /// <summary>
        /// 充值卡类型ID
        /// </summary>
        [XmlElement("prepaid_card_type_id")]
        public int PrepaidcardTypeId { get; set; }

        /// <summary>
        /// 充值卡类型ID
        /// </summary>
        [XmlElement("prepaid_card_type_name")]
        public string PrepaidcardTypeName { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_number")]
        public string CardNumber { get; set; }


        /// <summary>
        /// 绑定的用户ID
        /// </summary>
        [XmlElement("bind_user_id")]
        public int BindUserId { get; set; }

        /// <summary>
        /// 绑定的用户名
        /// </summary>
        [XmlElement("bind_user_name")]
        public string BindUserName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }


        /// <summary>
        /// 充值卡面值
        /// </summary>
        [XmlElement("money")]
        public double Money { get; set; }

        /// <summary>
        /// 绑定的店铺ID
        /// </summary>
        [XmlElement("bind_shop_id")]
        public int BindshopId { get; set; }


        /// <summary>
        /// 绑定的店铺名
        /// </summary>
        [XmlElement("bind_shop_name")]
        public string BindShopName { get; set; }

        /// <summary>
        /// 绑定的公司ID
        /// </summary>
        [XmlElement("bind_company_id")]
        public int BindCompanyId { get; set; }


        /// <summary>
        /// 绑定的公司ID
        /// </summary>
        [XmlElement("bind_company_name")]
        public string BindCompanyName { get; set; }


        /// <summary>
        /// 充值卡绑定时间
        /// </summary>
        [XmlElement("bind_time")]
        public string BindTime { get; set; }

        /// <summary>
        /// 该充值卡的创建人
        /// </summary>
        [XmlElement("create_user_name")]
        public string CreateUserName { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

    }
}
