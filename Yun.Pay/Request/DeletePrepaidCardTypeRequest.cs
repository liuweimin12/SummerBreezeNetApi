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
    /// 删除充值卡类型
    /// chenggou.prepaidcard.category.delete
    /// </summary>
    public class DeletePrepaidCardTypeRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 充值卡类型ID
        /// </summary>
        public int PrepaidCardTypeId { get; set; }


        public string GetApiName()
        {
            return "chenggou.prepaidcard.category.delete";
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
            RequestValidator.ValidateRequired("prepaidcardtypeId", PrepaidCardTypeId);
        }
    }
}
