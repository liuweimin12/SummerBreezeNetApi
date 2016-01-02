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
    /// 更改用户标签
    /// chenggou.user.tag.update
    /// </summary>
    public class UpdateUserTagRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 标签名字
        /// </summary>
        public string TagName { get; set; }


        /// <summary>
        /// 用户标签ID
        /// </summary>
        public int TagId { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.tag.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"tagname",TagName},
                {"tagid",TagId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("tagname", TagName);
            RequestValidator.ValidateRequired("tagid", TagId);
        }
    }
}
