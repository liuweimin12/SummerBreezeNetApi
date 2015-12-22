using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class DeleteItemSpecNameRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 规格名ID
        /// </summary>
        public int SpecNameId { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.specname.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"specnameid",SpecNameId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("specnameid", SpecNameId);
        }
    }
}
