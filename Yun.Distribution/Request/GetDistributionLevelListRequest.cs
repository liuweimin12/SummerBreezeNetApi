using System.Collections.Generic;
using Yun.Distribution.Response;
using Yun.Interface;

namespace Yun.Distribution.Request
{
    /// <summary>
    /// 获取店铺下的分销等级分成列表
    /// chenggou.distribution.level.list.get
    /// </summary>
    public class GetDistributionLevelListRequest : ITopRequest<GetDistributionLevelListResponse>
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        public int? TemplateId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        public string GetApiName()
        {
            return "chenggou.distribution.level.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"templateid",TemplateId},
                {"shopid",ShopId}
            };
            return parameters;
        }

        public void Validate()
        {
           
        }
    }
}
