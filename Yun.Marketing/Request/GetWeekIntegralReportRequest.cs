using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取积分的周报表
    /// yun.integral.weekreport.get
    /// </summary>
    public class GetWeekIntegralReportRequest : ITopRequest<GetWeekIntegralReportResponse>
    {
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime? Date { get; set; }

        public string GetApiName()
        {
            return "yun.integral.weekreport.get";
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
