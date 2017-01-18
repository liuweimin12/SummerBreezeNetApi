using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 获取支出的来源
    /// yun.user.score.sources.expenditure.list.get
    /// </summary>
    public class GetSourcesOfExpenditureRequest: ITopRequest<GetSourcesOfExpenditureResponse>
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
                _pageSize = value < 1 ? 20 : value;
            }
        }

        private int _pageSize = 20;


        /// <summary>
        /// 收入类型
        /// </summary>
        public string IncomeIntegralType { get; set; }


        /// <summary>
        /// 支出类型
        /// </summary>
        public string ExpenditureIntegralType { get; set; }

        public string GetApiName()
        {
            return "yun.user.score.sources.expenditure.list.get";
        }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? StartTime { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"endtime", EndTime},
                {"starttime", StartTime},
                {"incomeintegraltype", IncomeIntegralType},
                {"expenditureintegraltype", ExpenditureIntegralType},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("endtime", EndTime);
            RequestValidator.ValidateRequired("starttime", StartTime);
        }
    }
}
