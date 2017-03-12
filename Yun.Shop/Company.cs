using System;
using System.Xml.Serialization;

namespace Yun.Shop
{
    public class Company
    {
        /// <summary>
        /// 管理人
        /// </summary>
        [XmlElement("management")]
        public string Management { get; set; }

        [XmlElement("id")]
        public long Id { get; set; }

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
        public long UserId { get; set; }

        /// <summary>
        /// 注册人
        /// </summary>
        [XmlElement("auditor")]
        public string Auditor { get; set; }


        /// <summary>
        /// 支付扣点
        /// </summary>
        [XmlElement("pay_deduction")]
        public string PayDeduction { get; set; }
    }
}
