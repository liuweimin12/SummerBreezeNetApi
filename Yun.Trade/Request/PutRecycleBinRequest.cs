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
    /// 删除交易
    /// chenggou.trade.recyclebin.put
    /// 需要授权
    /// </summary>
    public class PutRecycleBinRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 交易ID
        /// </summary>
        public int TradeId { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.recyclebin.put";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"tradeid", TradeId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("tradeid", TradeId);
            RequestValidator.ValidateMinValue("tradeid", TradeId, 1);
        }
    }
}
