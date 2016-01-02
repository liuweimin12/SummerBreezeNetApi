using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 修改用户积分
    /// </summary>
    public class ModifyUserCreditRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string UserNick { get; set; }

        /// <summary>
        /// 变化的积分量
        /// </summary>
        public int Credit { get; set; }


        /// <summary>
        /// 变更原因
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 过期天数
        /// </summary>
        public int ExpiredDay { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.score.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"usernick",UserNick},
                {"credit",Credit},
                {"expiredday",ExpiredDay},
                {"remark",Remark}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("remark", Remark);
            RequestValidator.ValidateRequired("credit", Credit);
            RequestValidator.ValidateRequired("usernick", UserNick);
        }
    }
}
