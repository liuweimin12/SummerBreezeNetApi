using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Trade.Request
{
    public class IntegralDomain
    {
        /// <summary>
        /// 1积分可以等于多少金钱
        /// </summary>
        [XmlElement("one_integral_equal_money")]
        public double OneIntegralEqualMoney { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [XmlElement("integral_enabled")]
        public int IntegralEnabled { get; set; }

        /// <summary>
        /// 交易结束以后款项和积分的兑换比例
        /// </summary>
        [XmlElement("trade_end_money_to_credit")]
        public int TradeEndMoneyToCredit { get; set; }
    }
}
