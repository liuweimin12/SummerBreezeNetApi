using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取用户充值卡概要
    /// chenggou.user.prepaidcard.money
    /// </summary>
    public class GetPrepaidCardMoneyRequest : ITopRequest<GetPrepaidCardMoneyResponse>
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }


        /// <summary>
        /// 用户昵称
        /// </summary>
        public string Nick { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.prepaidcard.money";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"userid", UserId},
                {"nick", Nick}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
