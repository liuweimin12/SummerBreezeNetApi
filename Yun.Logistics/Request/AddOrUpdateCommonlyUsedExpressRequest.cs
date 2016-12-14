using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Logistics.Request
{
    /// <summary>
    /// 保存常用快递列表
    /// yun.logistics.commonlyused.express.addorupdate
    /// </summary>
    public class AddOrUpdateCommonlyUsedExpressRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 常用快递
        /// </summary>
        public string ExpressName { get; set; }

        /// <summary>
        /// 是否默认
        /// </summary>
        public bool IsDefault { get; set; }

        public string GetApiName()
        {
            return "yun.logistics.commonlyused.express.addorupdate";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"expressname", ExpressName},
                {"isdefault", IsDefault}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("expressname", ExpressName);
        }
    }
}
