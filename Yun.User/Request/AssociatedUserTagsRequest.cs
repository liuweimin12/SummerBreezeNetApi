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
    /// 关联用户标签
    /// chenggou.user.tag.associated
    /// </summary>
    public class AssociatedUserTagsRequest : ITopRequest<BoolResultResponse>
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
            return "chenggou.user.tag.associated";
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
