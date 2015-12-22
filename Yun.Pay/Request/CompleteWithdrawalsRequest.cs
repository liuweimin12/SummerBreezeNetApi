using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 完成提现
    /// chenggou.pay.withdrawals.complete
    /// </summary>
    public class CompleteWithdrawalsRequest:ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 提现号ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        public string Ip { get; set; }

        public string GetApiName()
        {
            return "chenggou.pay.withdrawals.complete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"ip",Ip}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
