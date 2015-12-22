using System.Collections.Generic;
using Yun.Interface;
using Yun.Logistics.Response;
using Yun.Util;

namespace Yun.Logistics.Request
{
    /// <summary>
    /// 获取多个商品最贵的快递模板ID
    /// </summary>
    public class GetTheMostExpensiveTemplateRequest : ITopRequest<GetExpressTemplateResponse>
    {
        /// <summary>
        /// 商品ID，多个用英文逗号进行分割
        /// </summary>
        public string ItemIds { get; set; }

        public string GetApiName()
        {
            return "chenggou.delivery.mostexpensivetemplate.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemids", ItemIds}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemids", ItemIds);
        }
    }
}
