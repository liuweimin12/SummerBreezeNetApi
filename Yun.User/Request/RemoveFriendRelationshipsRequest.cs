using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 移除好友关系
    /// yun.user.friend.relationships.remove
    /// </summary>
    public class RemoveFriendRelationshipsRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 目标用户ID
        /// </summary>
        public int TargetUserId { get; set; }

        public string GetApiName()
        {
            return "yun.user.friend.relationships.remove";
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
            RequestValidator.ValidateRequired("targetuserid", TargetUserId);
        }
    }
}
