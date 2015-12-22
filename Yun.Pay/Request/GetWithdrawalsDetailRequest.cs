using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取提现详情
    /// chenggou.pay.withdrawals.detail.get
    /// </summary>
    public class GetWithdrawalsDetailRequest : ITopRequest<GetWithdrawalsDetailResponse>
    {
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.pay.withdrawals.detail.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
