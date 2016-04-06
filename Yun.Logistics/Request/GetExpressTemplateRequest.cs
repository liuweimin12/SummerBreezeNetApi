using System.Collections.Generic;
using Yun.Interface;
using Yun.Logistics.Response;
using Yun.Response;

namespace Yun.Logistics.Request
{
    /// <summary>
    /// 获取快递模板信息
    /// 根据模板ID获取快递模板的详细信息
    /// </summary>
    public class GetExpressTemplateRequest : ITopRequest<GetExpressTemplateResponse>
    {
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.delivery.template.get";
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
        }
    }
}
