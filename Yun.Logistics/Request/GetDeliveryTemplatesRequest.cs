using System.Collections.Generic;
using Yun.Interface;
using Yun.Logistics.Response;

namespace Yun.Logistics.Request
{
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
                
            };
            return parameters; 
        }

        public void Validate()
        {
            
        }
    }
}
