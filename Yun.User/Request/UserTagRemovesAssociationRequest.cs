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
    /// 移除用户所关联的标签
    /// chenggou.user.tag.removeassociation
    /// </summary>
    public class UserTagRemovesAssociationRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string UserNick { get; set; }

        /// <summary>
        /// 用户标签ID
        /// </summary>
        public int TagId { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.tag.removeassociation";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"usernick",UserNick},
                {"tagid",TagId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("usernick", UserNick);
            RequestValidator.ValidateRequired("tagid", TagId);
        }
    }
}
