using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Parser;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{

    /// <summary>
    /// 申请提现
    /// chenggou.pay.withdrawals.apply
    /// </summary>
    public class ApplyWithdrawalsRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 提现至哪个地方的ID
        /// </summary>
        public int BankId { get; set; }

        /// <summary>
        /// 提现的金额
        /// </summary>
        public double Money { get; set; }

        public string GetApiName()
        {
            return "chenggou.pay.withdrawals.apply";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"bankid",BankId},
                {"money",Money}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("bankid", BankId);
            RequestValidator.ValidateRequired("money", Money);
        }
    }
}
