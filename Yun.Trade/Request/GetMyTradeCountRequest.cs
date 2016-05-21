using System.Collections.Generic;
using Yun.Interface;
using Yun.Trade.Response;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 获取我的订单数量
    /// 如果不传入用户ID，则必须传入token
    /// </summary>
    public class GetMyTradeCountRequest: ITopRequest<GetTradeCountResponse>
    {

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        public string GetApiName()
        {
            return "chenggou.buyer.trade.count";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"userid", UserId}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
