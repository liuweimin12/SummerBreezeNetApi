using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取积分的月报表
    /// yun.integral.monthreport.get
    /// </summary>
    public class GetMonthIntegralReportRequest : ITopRequest<GetMonthIntegralReportResponse>
    {
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime? Date { get; set; }

        public string GetApiName()
        {
            return "yun.integral.monthreport.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"date",Date.Value.ToShortDateString()}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("date", Date);
        }
    }
}
