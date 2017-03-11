using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取支付账号的余额变化记录
    /// yun.pay.payaccount.balance.list.get
    /// </summary>
    public class GetPayAccountRecordListRequest : ITopRequest<GetPayAccountRecordListResponse>
    {
        /// <summary>
        /// 支付账号ID
        /// </summary>
        public int PayAccountId { get; set; }

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


        public string GetApiName()
        {
            return "yun.pay.payaccount.balance.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"payaccountid", PayAccountId},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("payaccountid", PayAccountId, 1);
        }
    }
}
