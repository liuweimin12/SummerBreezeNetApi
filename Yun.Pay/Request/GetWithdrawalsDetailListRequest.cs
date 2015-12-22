using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取提现信息列表
    /// chenggou.pay.withdrawals.list.get
    /// </summary>
    public class GetWithdrawalsDetailListRequest : ITopRequest<GetWithdrawalsDetailListResponse>
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
        /// 用户名
        /// </summary>
        public string Nick { get; set; }


        /// <summary>
        /// 状态
        /// </summary>
        public int? Status { get; set; }


        /// <summary>
        /// 提现人名字
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 提现时间段最小时间
        /// </summary>
        public DateTime? MinCreateTime { get; set; }


        /// <summary>
        /// 提现时间段最大时间
        /// </summary>
        public DateTime? MaxCreateTime { get; set; }

        public string GetApiName()
        {
            return "chenggou.pay.withdrawals.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"nick",Nick},
                {"status",Status },
                {"realname",RealName },
                {"mincreatetime",MinCreateTime },
                {"maxcreatetime",MaxCreateTime }
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
