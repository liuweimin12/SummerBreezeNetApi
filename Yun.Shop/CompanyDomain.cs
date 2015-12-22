using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Shop
{
    public class CompanyDomain
    {
        /// <summary>
        /// 公司ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }


        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 注册人
        /// </summary>
        [XmlElement("auditor")]
        public string Auditor { get; set; }


        /// <summary>
        /// 站点ID
        /// </summary>
        [XmlElement("site_id")]
        public int SiteId { get; set; }


        /// <summary>
        /// 支付扣点
        /// </summary>
        [XmlElement("pay_deduction")]
        public double PayDeduction { get; set; }


        /// <summary>
        /// 充值卡和余额的兑换比值，一余额卡可兑换多少余额
        /// </summary>
        [XmlElement("prepaid_card_proportion")]
        public double PrepaidCardProportion { get; set; }
    }
}
