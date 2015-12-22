using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Distribution
{
    public class DistributionHistory
    {
        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 交易后可得利润
        /// </summary>
        [XmlElement("money")]
        public double Money { get; set; }

        /// <summary>
        /// 创建记录用户ID
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }


        /// <summary>
        /// 上级用户ID
        /// </summary>
        [XmlElement("parent_id")]
        public int ParentId { get; set; }


        /// <summary>
        /// 上级人员名字
        /// </summary>
        [XmlElement("parent_name")]
        public string ParentName { get; set; }


        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("trade_id")]
        public int TradeId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }


        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [XmlElement("trade_money")]
        public double TradeMoney { get; set; }

        /// <summary>
        /// 未使用的利润
        /// </summary>
        [XmlElement("surplus")]
        public double Surplus { get; set; }
    }
}
