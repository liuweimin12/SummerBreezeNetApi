using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{

    /// <summary>
    /// 匹配商品的物流模板
    /// yun.item.logistics.templates.matching
    /// </summary>
    public class MatchingLogisticsTemplatesRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public string ItemIds { get; set; }

        /// <summary>
        /// 物流模板ID
        /// </summary>
        public int LogisticsTemplateId { get; set; }

        public string GetApiName()
        {
            return "yun.item.logistics.templates.matching";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"logisticstemplateid",LogisticsTemplateId},
                {"itemids",ItemIds}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemids", ItemIds);
            RequestValidator.ValidateMinValue("logisticstemplateid", LogisticsTemplateId, 1);
        }
    }
}
