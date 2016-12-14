using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Logistics.Request
{
    /// <summary>
    /// 删除常用的快递公司
    /// yun.logistics.commonlyused.express.delete
    /// </summary>
    public class DeleteCommonlyUsedExpressRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "yun.logistics.commonlyused.express.delete";
        }


        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("id", Id, 1);
        }
    }
}
