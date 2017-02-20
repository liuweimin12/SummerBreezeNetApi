using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 获取邀请状态
    /// yun.user.invite.status.get
    /// </summary>
    public class GetInviteStatusRequest : ITopRequest<GetInviteStatusResponse>
    {
        /// <summary>
        /// 对方用户ID，多个用英文逗号分隔
        /// </summary>
        public string OtherUserIds { get; set; }

        public string GetApiName()
        {
            return "yun.user.invite.status.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
               {"otheruserids",OtherUserIds}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("otheruserids", OtherUserIds);
        }
    }
}
