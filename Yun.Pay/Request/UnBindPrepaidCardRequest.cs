using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 用户充值卡解绑
    /// </summary>
    public class UnBindPrepaidCardRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNumber { get; set; }


        /// <summary>
        /// 充值卡ID
        /// </summary>
        public int CardId { get; set; }


        /// <summary>
        /// IP地址
        /// </summary>
        public string Ip { get; set; }

        public string GetApiName()
        {
            return "chenggou.prepaidcard.unbind";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"cardnumber",CardNumber},
                {"cardid",CardId},
                {"ip",Ip}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
