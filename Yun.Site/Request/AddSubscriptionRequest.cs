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
    /// 新增订阅者
    /// chenggou.subscription.add
    /// </summary>
    public class AddSubscriptionRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 订阅者信息
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 订阅类型，默认0是邮件，1是手机
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 所属公司ID
        /// </summary>
        public int CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.subscription.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"content",Content},
                {"type",Type},
                {"shopid",ShopId},
                {"companyid",CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("content", Content);
        }
    }
}
