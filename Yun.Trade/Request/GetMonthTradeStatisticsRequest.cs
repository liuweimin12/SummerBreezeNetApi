using System.Collections.Generic;
using Yun.Interface;
using Yun.Trade.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 获取交易的月报表
    /// chenggou.trade.monthstatistics.list.get
    /// </summary>
    public class GetMonthTradeStatisticsRequest: ITopRequest<GetMonthTradeStatisticsResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }


        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }


        /// <summary>
        /// 年份
        /// </summary>
        public int Year { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.monthstatistics.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"companyid", CompanyId},
                {"year", Year},
                {"shopid", ShopId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("year", Year);
            RequestValidator.ValidateMinValue("year", Year, 2015);
        }
    }
}
