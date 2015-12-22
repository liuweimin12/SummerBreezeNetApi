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
    /// 删除充值卡
    /// chenggou.prepaidcard.delete
    /// </summary>
    public class DeletePrepaidCardRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 充值卡类型ID
        /// </summary>
        public int PrepaidCardId { get; set; }


        public string GetApiName()
        {
            return "chenggou.prepaidcard.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"prepaidcardid",PrepaidCardId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("prepaidcardid", PrepaidCardId);
        }
    }
}
