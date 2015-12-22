using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 修改系统备注，可在任何时间进行修改，和系统扩展字段不一样，扩展自定只允许在订单创建的时候存入
    /// chenggou.trade.systemmemo.save
    /// </summary>
    public class SaveSystemMemoRequest : ITopRequest<BoolResultResponse>
    {
        public string GetApiName()
        {
            return "chenggou.trade.systemmemo.save";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"tradeid",TradeId},
                {"memo",Memo}
            };

            return parameters;
        }

        /// <summary>
        /// 订单ID
        /// </summary>
        public int TradeId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

        public void Validate()
        {
            RequestValidator.ValidateRequired("tradeid", TradeId);
            RequestValidator.ValidateMinValue("tradeid", TradeId, 1);
        }
    }
}
