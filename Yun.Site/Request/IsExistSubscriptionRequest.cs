using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    /// <summary>
    /// 查询某订阅者是否已存在
    /// chenggou.subscription.isexist
    /// </summary>
    public class IsExistSubscriptionRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 订阅者信息
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 订阅类型，默认0是邮件，1是手机
        /// </summary>
        public int Type { get; set; }

        public string GetApiName()
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"content",Content},
                {"type",Type}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("content", Content);
        }
    }
}
