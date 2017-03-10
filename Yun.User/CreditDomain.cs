using System.Xml.Serialization;

namespace Yun.User
{
    public class CreditDomain
    {
        /// <summary>
        /// 类型、用户、可以自定义
        /// </summary>
        [XmlElement("credit")]
        public string CreditType { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 关联用户
        /// </summary>
        [XmlElement("related_user_id")]
        public int RelatedUserId { get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 详情对应的ID
        /// </summary>
        [XmlElement("detail_id")]
        public string DetailId { get; set; }

        /// <summary>
        /// 积分
        /// </summary>
        [XmlElement("score")]
        public int Score { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        [XmlElement("nick")]
        public string Nick { get; set; }
    }
}
