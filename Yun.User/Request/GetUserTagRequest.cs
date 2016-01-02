using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 获取单条用户标签信息
    /// </summary>
    public class GetUserTagRequest : ITopRequest<GetUserTagResponse>
    {
        public string GetApiName()
        {
            return "chenggou.user.tag.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
               {"tagid",TagId}
            };
            return parameters;
        }

        /// <summary>
        /// 用户标签ID
        /// </summary>
        public int TagId { get; set; }

        public void Validate()
        {
            RequestValidator.ValidateRequired("tagid", TagId);
        }
    }
}
