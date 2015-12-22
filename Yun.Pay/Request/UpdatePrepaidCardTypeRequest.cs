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
    /// 修改充值卡类型
    /// chenggou.prepaidcard.type.update
    /// </summary>
    public class UpdatePrepaidCardTypeRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 充值卡类型ID
        /// </summary>
        public int PrepaidCardTypeId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// 充值卡名称
        /// </summary>
        public string CardName { get; set; }

        /// <summary>
        /// 充值卡类型，自定义，对主流程无影响
        /// </summary>
        public int CardType { get; set; }

        public string GetApiName()
        {
            return "chenggou.prepaidcard.type.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"prepaidcardtypeid",PrepaidCardTypeId},
                {"description",Description},
                {"cardname",CardName},
                {"cardtype",CardType}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cardname", CardName);
            RequestValidator.ValidateRequired("prepaidcardtypeId", PrepaidCardTypeId);
        }
    }
}
