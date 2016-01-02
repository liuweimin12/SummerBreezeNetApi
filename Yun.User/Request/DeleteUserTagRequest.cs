using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.User.Request
{
    /// <summary>
    /// 删除用户标签
    /// chenggou.user.tag.delete
    /// </summary>
    public class DeleteUserTagRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 用户标签ID
        /// </summary>
        public int TagId { get; set; }
        public string GetApiName()
        {
            return "chenggou.user.tag.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"tagid",TagId}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
