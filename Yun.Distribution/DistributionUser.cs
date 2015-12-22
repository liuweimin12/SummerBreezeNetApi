using System;
using System.Xml.Serialization;

namespace Yun.Distribution
{
    public class DistributionUser
    {
        /// <summary>
        /// 下级分销商数量
        /// </summary>
        [XmlElement("distributor_quantity")]
        public int DistributorQuantity { get; set; }

        /// <summary>
        /// 分销账号ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public long  UserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }


        /// <summary>
        /// 真实姓名
        /// </summary>
        [XmlElement("realname")]
        public string RealName { get; set; }


        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }


        /// <summary>
        /// 分销备注
        /// </summary>
        [XmlElement("note")]
        public string Note { get; set; }



        /// <summary>
        /// 分销级别
        /// </summary>
        [XmlElement("level")]
        public int Level { get; set; }

        /// <summary>
        /// 上级分销人员
        /// </summary>
        [XmlElement("parent_id")]
        public int ParentId { get; set; }

        /// <summary>
        /// 营业额
        /// </summary>
        [XmlElement("turn_over")]
        public string Turnover { get; set; }

        /// <summary>
        /// 交易量
        /// </summary>
        [XmlElement("trading_volume")]
        public int TradingVolume { get; set; }

        /// <summary>
        /// 快捷登陆的oauthid
        /// </summary>
        [XmlElement("oauth_id")]
        public string OAuthId { get; set; }
    }
}
