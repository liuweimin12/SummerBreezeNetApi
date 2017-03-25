using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 管理员变更用户的余额，返回变更后的余额
    /// chenggou.user.money.modify
    /// </summary>
    public class ModifyUserMoneyRequest:ITopRequest<StringResultResponse>
    {
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string UserNick { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 变更的金额，可以为负值
        /// </summary>
        public double Money { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// ip地址
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        public string TradeNo { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.money.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"usernick",UserNick},
                {"userid",UserId},
                {"money",Money},
                {"remark",Remark},
                {"tradeno",TradeNo}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("tradeno", TradeNo);
            RequestValidator.ValidateRequired("remark", Remark);
            RequestValidator.ValidateRequired("money", Money);
        }
    }
}
