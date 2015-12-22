using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Trade.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 获取我的退款记录
    /// </summary>
    public class GetMyRefundsRequest : ITopRequest<GetRefundsResponse>
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
        /// 待搜索的创建时间最小值
        /// </summary>
        public DateTime? MinCreateTime { get; set; }

        /// <summary>
        /// 待搜索的创建时间最大值
        /// </summary>
        public DateTime? MaxCreateTime { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 退款号
        /// </summary>
        public int OrderRefundId { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 是否加载历史记录
        /// </summary>
        public int LoadHistory { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.myrefunds.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"mincreatetime",MinCreateTime},
                {"maxcreatetime",MaxCreateTime},
                {"orderid",OrderId},
                {"orderrefundid",OrderRefundId},
                {"status",Status},
                {"loadhistory",LoadHistory}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("pagesize", PageSize, 40);
        }
    }
}
