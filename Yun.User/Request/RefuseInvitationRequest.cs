using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 拒绝好友邀请
    /// yun.user.friend.invitation.refuse
    /// </summary>
    public class RefuseInvitationRequest : ITopRequest<IntResultResponse>
    {
        public int Id { get; set; }

        public string GetApiName()
        {
            return "yun.user.friend.invitation.refuse";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("id", Id, 1);
        }
    }
}
