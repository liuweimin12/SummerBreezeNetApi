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
    /// 添加用户标签
    /// chenggou.user.tag.add
    /// </summary>
    public class AddUserTagRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 标签名字
        /// </summary>
        public string TagName { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.tag.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"tagname",TagName}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("tagname", TagName);
        }
    }
}
