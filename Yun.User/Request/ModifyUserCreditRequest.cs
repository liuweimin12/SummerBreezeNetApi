using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 修改用户积分
    /// 不需要授权
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
        /// 用户ID
        /// </summary>
        public int TargetUserId { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 过期天数
        /// </summary>
        public int ExpiredDay { get; set; }

        /// <summary>
        /// 变更详情，不能超过20个字
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 对应的关系ID，只允许传入英文，数字
        /// </summary>
        public string DetailId { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.score.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"usernick", UserNick},
                {"credit", Credit},
                {"expiredday", ExpiredDay},
                {"remark", Remark},
                {"detail", Detail},
                {"detailid", DetailId},
                {"targetuserid",TargetUserId }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("detail", Detail);
            RequestValidator.ValidateRequired("credit", Credit);
        }
    }
}
