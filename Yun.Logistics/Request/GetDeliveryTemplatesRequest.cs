using System.Collections.Generic;
using Yun.Interface;
using Yun.Logistics.Response;

namespace Yun.Logistics.Request
{
    /// <summary>
    /// 获取物流模板的列表
    /// </summary>
    public class GetDeliveryTemplatesRequest : ITopRequest<ExpressTemplateResponse>
    {

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        public string GetApiName()
        {
            return "chenggou.freight.templates.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid",ShopId }   
            };
            return parameters; 
        }

        public void Validate()
        {
            
        }
    }
}
