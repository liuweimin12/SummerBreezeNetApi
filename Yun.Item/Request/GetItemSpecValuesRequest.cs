using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class GetItemSpecValuesRequest : ITopRequest<SpecValuesResponse>
    {
        /// <summary>
        /// 商品规格名称ID
        /// </summary>
        public int SpecNameId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public int PageNum { get; set; }

        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.specvalues.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"sepcnameid", SpecNameId},
                {"pagenum", PageNum},
                {"pagesize",PageSize}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("specnameid", SpecNameId);
            RequestValidator.ValidateRequired("pagenum", PageNum);
            RequestValidator.ValidateRequired("pagesize", PageSize);
        }
    }
}
