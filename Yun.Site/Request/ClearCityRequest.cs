using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Site.Request
{
    /// <summary>
    /// 清除自定义的城市数据
    /// yun.cities.clear
    /// </summary>
    public class ClearCityRequest : ITopRequest<BoolResultResponse>
    {
        public string GetApiName()
        {
            return "yun.cities.clear";
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
