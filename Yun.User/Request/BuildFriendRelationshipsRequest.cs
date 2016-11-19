using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 建立朋友的关系，对方必须已经注册
    /// yun.user.friend.relationships.build
    /// </summary>
    public class BuildFriendRelationshipsRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 目标用户ID，多个用英文逗号分隔
        /// </summary>
        public string TargetUserIds { get; set; }

        /// <summary>
        /// 其中一位的用户ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 目标用户类型
        /// 0：用户名,1：手机号,2：邮箱
        /// </summary>
        public int TargetUserType { get; set; }

        /// <summary>
        /// 目标用户名，可以使手机号，用户名，邮箱
        /// </summary>
        public string TargetUserName { get; set; }


        public string GetApiName()
        {
            return "yun.user.friend.relationships.build";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"targetuserids", TargetUserIds},
                {"userid", UserId},
                {"targetusertype", TargetUserType},
                {"targetusername", TargetUserName},
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("userid", UserId, 1);

            if (string.IsNullOrEmpty(TargetUserIds))
            {
                RequestValidator.ValidateRequired("targetusertype", TargetUserType);
                RequestValidator.ValidateRequired("targetusername", TargetUserName);
            }
            else
            {
                RequestValidator.ValidateRequired("targetuserids", TargetUserIds);
            }
        }
    }
}
