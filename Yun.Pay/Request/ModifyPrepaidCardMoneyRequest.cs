using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 修改充值卡余额
    /// </summary>
    public class ModifyPrepaidCardMoneyRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 充值卡ID
        /// </summary>
        public int CardId { get; set; }

        /// <summary>
        /// 当前的IP地址
        /// </summary>
        public string Ip { get; set; }


        /// <summary>
        /// 需要修改的金额
        /// </summary>
        public double Money { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        public string GetApiName()
        {
            return "chenggou.prepaidcard.money.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"cardid", CardId},
                {"ip", Ip},
                {"money", Money},
                {"note", Note},
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cardid", CardId);
            RequestValidator.ValidateRequired("money", Money);
        }
    }
}
