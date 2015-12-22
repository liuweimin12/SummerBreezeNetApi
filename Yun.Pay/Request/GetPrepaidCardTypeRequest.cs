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
    /// 获取充值卡类型的单条记录
    /// chenggou.prepaidcard.category.get
    /// </summary>
    public class GetPrepaidCardTypeRequest : ITopRequest<GetPrepaidCardTypeResponse>
    {
        /// <summary>
        /// 充值卡类型ID
        /// </summary>
        public int PrepaidCardTypeId { get; set; }

        public string GetApiName()
        {
            return "chenggou.prepaidcard.category.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"prepaidcardtypeid",PrepaidCardTypeId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("prepaidcardtypeid", PrepaidCardTypeId);
        }
    }
}
