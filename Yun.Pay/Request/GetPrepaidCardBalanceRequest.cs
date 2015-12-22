using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取充值卡余额统计报表
    /// chenggou.pay.prepaidcard.balance.report.get
    /// </summary>
    public class GetPrepaidCardBalanceRequest : ITopRequest<GetPrepaidCardBalanceResponse>
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
        /// 统计时间
        /// </summary>
        public DateTime? StatisticsData { get; set; }


        public string GetApiName()
        {
            return "chenggou.pay.prepaidcard.balance.report.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"statisticsdata", StatisticsData}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("statisticsdata", StatisticsData);
        }
    }
}
