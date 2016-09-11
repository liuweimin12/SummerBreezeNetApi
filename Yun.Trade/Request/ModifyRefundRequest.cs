using System.Collections.Generic;
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
        /// 退款理由
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 备注留言
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 余额退款的金额
        /// </summary>
        public double Money { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.refund.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"orderrefundid", OrderRefundId},
                {"money", Money},
                {"reason", Reason},
                {"remark", Remark}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("orderrefundid", OrderRefundId, 1);
        }
    }
}
