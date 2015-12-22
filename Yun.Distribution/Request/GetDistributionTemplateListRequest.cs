using System.Collections.Generic;
using Yun.Distribution.Response;
using Yun.Interface;

namespace Yun.Distribution.Request
{

    /// <summary>
    /// 获取分销等级模板列表
    /// chenggou.distribution.template.list.get
    /// </summary>
    public class GetDistributionTemplateListRequest : ITopRequest<GetDistributionTemplateListResponse>
    {
        public int? ShopId { get; set; }


        public string GetApiName()
        {
            return "chenggou.distribution.template.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid", ShopId}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
