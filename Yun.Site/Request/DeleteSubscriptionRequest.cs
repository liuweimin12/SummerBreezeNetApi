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
    /// 删除订阅者信息
    /// chenggou.subscription.delete
    /// </summary>
    public class DeleteSubscriptionRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 订阅者ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.subscription.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
