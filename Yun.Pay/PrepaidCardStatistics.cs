using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Pay
{
    public class PrepaidCardStatistics
    {
        /// <summary>
        /// 卡购买总面额
        /// </summary>
        [XmlElement("total_money")]
        public double TotalMoney { get; set; }


        /// <summary>
        /// 已经绑定的总面额
        /// </summary>
        [XmlElement("has_bind_money")]
        public double HasBindMoney { get; set; }


        /// <summary>
        /// 已使用的总金额
        /// </summary>
        [XmlElement("has_used_money")]
        public double HasUsedMoney { get; set; }
    }
}
