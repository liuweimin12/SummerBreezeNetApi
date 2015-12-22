using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 设置积分兑换比例
    /// chenggou.integral.traderule.set
    /// </summary>
    public class SetIntegralRequest:ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 1积分可以等于多少金钱
        /// </summary>
        public double OneIntegralEqualMoney { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public int? Enabled { get; set; }


        /// <summary>
        /// 交易成功以后款项和积分的兑换比例
        /// </summary>
        public int TradeEndMoneyToCredit { get; set; }

        public string GetApiName()
        {
            return "chenggou.integral.traderule.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"oneintegralequalmoney",OneIntegralEqualMoney},
                {"enabled",Enabled},
                {"tradeendmoneytocredit",TradeEndMoneyToCredit}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
