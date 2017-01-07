using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    /// <summary>
    /// 获取日数据
    /// </summary>
    [XmlRoot("get_daily_integral_report_response")]
    public class GetDailyIntegralReportResponse : YunResponse
    {
        /// <summary>
        /// 上期结转
        /// </summary>
        [XmlElement("carryover")]
        public double Carryover { get; set; }

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
