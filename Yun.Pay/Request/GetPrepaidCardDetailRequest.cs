using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Pay.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取充值卡详情
    /// chenggou.prepaidcard.detail.get
    /// </summary>
    public class GetPrepaidCardDetailRequest : ITopRequest<GetPrepaidCardDetailResponse>
    {
        /// <summary>
        /// 充值卡ID
        /// </summary>
        public int PrepaidCardId { get; set; }

        /// <summary>
        /// 充值卡卡号
        /// </summary>
        public string CardNumber { get; set; }

        public string GetApiName()
        {
            return "chenggou.prepaidcard.detail.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"prepaidcardid",PrepaidCardId},
                {"cardnumber",CardNumber}
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
