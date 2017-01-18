﻿using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    /// <summary>
    /// 获取周数据报表
    /// </summary>
    [XmlRoot("get_week_integral_report_response")]
    public class GetWeekIntegralReportResponse : YunResponse
    {
        /// <summary>
        /// 余额
        /// </summary>
        [XmlElement("balance")]
        public double Balance { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 支出概要
        /// </summary>
        [XmlElement("expenditure_summary")]
        public ExpenditureSummary ExpenditureSummary { get; set; }

        /// <summary>
        /// 收入概要
        /// </summary>
        [XmlElement("income_summary")]
        public IncomeSummary IncomeSummary { get; set; }
    }
}
