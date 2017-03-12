using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取充值卡列表数据
    /// yun.prepaidcard.expired.list.get
    /// </summary>
    public class GetExpiredPrepaidCardsListRequest : ITopRequest<GetPrepaidCardsListResponse>
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
        /// 过期时间
        /// </summary>
        public DateTime? ExpiredDateTime { get; set; }

        public string GetApiName()
        {
            return "yun.prepaidcard.expired.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"expireddatetime",ExpiredDateTime},
                {"pagenum",PageNum},
                {"pagesize",PageSize},
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
