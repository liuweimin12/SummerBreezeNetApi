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
    /// 批量关联用户标签，某一个标签批量关联到用户
    /// chenggou.user.tag.batchassociated
    /// </summary>
    public class BatchAssociatedUserTagsRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 需要被关联的用户标签ID
        /// </summary>
        public int TagId { get; set; }


        /// <summary>
        /// 用户名，多个用英文逗号进行分隔
        /// </summary>
        public string UserNick { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.tag.batchassociated";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"tagid",TagId},
                {"usernick",UserNick}
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
