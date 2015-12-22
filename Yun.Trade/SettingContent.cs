using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Trade
{
    public class SettingContent
    {
        /// <summary>
        /// 自动确认的时间，从发货后开始计时
        /// </summary>
        [XmlElement("confirm_hours")]
        public int ConfirmHours { get; set; }

        /// <summary>
        /// 普通订单的关闭时间，按小时计算
        /// </summary>
        [XmlElement("close_trade_hour")]
        public int CloseTradeHour { get; set; }
    }
}
