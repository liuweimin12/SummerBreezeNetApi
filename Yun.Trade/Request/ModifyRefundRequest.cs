using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 修改退款单
    /// </summary>
    public class ModifyRefundRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 退款单编号
        /// </summary>
        public long OrderRefundId { get; set; }

        /// <summary>
        /// 余额退款的金额
        /// </summary>
        public double Balance { get; set; }


        /// <summary>
        /// 在线付款的金额
        /// </summary>
        public double OnlineMoney { get; set; }

        /// <summary>
        /// 退款理由
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 备注留言
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 充值卡金额
        /// </summary>
        public double PrepaidCard { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.refund.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"orderrefundid", OrderRefundId},
                {"balance", Balance},
                {"onlinemoney", OnlineMoney},
                {"reason", Reason},
                {"remark", Remark},
                {"prepaidcard", PrepaidCard}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("orderrefundid", OrderRefundId, 1);
        }
    }
}
