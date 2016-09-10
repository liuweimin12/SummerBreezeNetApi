using System.Collections.Generic;
using Yun.Interface;
using Yun.Trade.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 订单整单退款操作，一般用于系统支付失败后，需要整单退款的
    /// 在线付款部分统一归并到用户余额
    /// yun.trade.refund.all.create
    /// </summary>
    public class CreateTradeRefundRequest : ITopRequest<CreateTradeRefundResponse>
    {
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TradeId { get; set; }

        /// <summary>
        /// 退款理由
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 备注留言
        /// </summary>
        public string Remark { get; set; }


        /// <summary>
        /// 凭证照片
        /// </summary>
        public string Images { get; set; }


        public string GetApiName()
        {
            return "yun.trade.refund.all.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"tradeid",TradeId},
                {"reason",Reason},
                {"remark",Remark},
                {"images",Images }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("tradeid", TradeId, 1);
        }
    }
}
