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
    /// 添加充值卡类型
    /// chenggou.prepaidcard.category.add
    /// </summary>
    public class AddPrepaidCardTypeRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 充值卡名称
        /// </summary>
        public string CardName { get; set; }

        /// <summary>
        /// 充值卡类型，自定义，对主流程无影响
        /// </summary>
        public int CardType { get; set; }

        /// <summary>
        /// 面额
        /// </summary>
        public double Denomination { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        public string GetApiName()
        {
            return "chenggou.prepaidcard.category.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"cardname",CardName},
                {"cardtype",CardType},
                {"denomination",Denomination},
                {"description",Description}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cardname", CardName);
            RequestValidator.ValidateRequired("denomination", Denomination);
        }
    }
}
