using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取外部待处理退款的数据
    /// yun.pay.outerrefund.list.get
    /// </summary>
    public class GetOuterRefundRequest :ITopRequest<GetOuterRefundResponse>
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
        /// 状态
        /// </summary>
        public int? State { get; set; }

        /// <summary>
        /// 退款ID
        /// </summary>
        public int? RefundId { get; set; }


        public string GetApiName()
        {
            return "yun.pay.outerrefund.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"state", State},
                {"refundid", RefundId}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
