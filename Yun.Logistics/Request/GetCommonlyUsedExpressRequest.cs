using System.Collections.Generic;
using Yun.Interface;
using Yun.Logistics.Response;

namespace Yun.Logistics.Request
{
    /// <summary>
    /// 获取常用快递列表
    /// yun.logistics.commonlyused.express.get
    /// </summary>
    public class GetCommonlyUsedExpressRequest : ITopRequest<GetCommonlyUsedExpressResponse>
    {
        public string GetApiName()
        {
            return "yun.logistics.commonlyused.express.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            return new Dictionary<string, string>();
        }

        public void Validate()
        {
        }
    }
}
