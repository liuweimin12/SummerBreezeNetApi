using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Distribution.Response;
using Yun.Interface;

namespace Yun.Distribution.Request
{
    /// <summary>
    /// 获取分销的账单记录
    /// chenggou.distributors.trade.history
    /// </summary>
    public class GetDistributorsHistoryRequest : ITopRequest<GetDistributorsHistoryResponse>
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
        /// 需要搜索的开始时间
        /// </summary>
        public DateTime? StartDateTime { get; set; }


        /// <summary>
        /// 需要搜索的结束时间
        /// </summary>
        public DateTime? EndDateTime { get; set; }


        /// <summary>
        /// 交易状态，支持TRADE_CLOSED,WAIT_BUYER_PAY,WAIT_SELLER_SEND_GOODS,WAIT_BUYER_CONFIRM_GOODS,TRADE_FINISHED
        /// </summary>
        public string TradeStatus { get; set; }

        /// <summary>
        /// 上级用户ID
        /// </summary>
        public int ParentUserId { get; set; }


        /// <summary>
        /// 当前用户ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public int TradeId { get; set; }

        public string GetApiName()
        {
            return "chenggou.distributors.trade.history";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"startdatetime",StartDateTime},
                {"enddatetime",EndDateTime},
                {"tradestatus",TradeStatus},
                {"parentuserid",ParentUserId},
                {"userid",UserId},
                {"tradeid",TradeId }
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
