using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取充值卡流水统计汇总报表
    /// chenggou.pay.prepaidcard.flow.statistics.get
    /// </summary>
    public class GetShopPrepaidCardStatisticsRequest : ITopRequest<GetShopPrepaidCardStatisticsResponse>
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int PageNum
        {
            get { return _pageNum; }
            set
            {
                _pageNum = value < 1 ? 1 : value;
            }
        }

        private int _pageNum = 1;

        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = value < 1 ? 1 : value;
            }
        }

        private int _pageSize = 1;


        /// <summary>
        /// 最小统计时间
        /// </summary>
        public DateTime? MinStatisticsData { get; set; }

        /// <summary>
        /// 最大时间
        /// </summary>
        public DateTime? MaxStatisticsData { get; set; }

        public string GetApiName()
        {
            return "chenggou.pay.prepaidcard.flow.statistics.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"minstatisticsdata", MinStatisticsData},
                {"maxstatisticsdata", MaxStatisticsData},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("minstatisticsdata", MinStatisticsData);
            RequestValidator.ValidateRequired("maxstatisticsdata", MaxStatisticsData);
        }
    }
}
