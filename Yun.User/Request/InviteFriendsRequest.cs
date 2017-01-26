using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 发送好友邀请请求
    /// yun.user.friend.invitation.send
    /// </summary>
    public class InviteFriendsRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 目标用户ID
        /// </summary>
        public int TargetUserId { get; set; }

        public string GetApiName()
        {
            return "yun.user.friend.invitation.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"targetuserid", TargetUserId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("targetuserid", TargetUserId, 1);
        }
    }
}
