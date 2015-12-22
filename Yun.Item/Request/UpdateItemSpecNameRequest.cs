using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class UpdateItemSpecNameRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 规格名ID
        /// </summary>
        public int SpecNameId { get; set; }


        /// <summary>
        /// 规格名
        /// </summary>
        public string Name { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.specname.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"specnameid",SpecNameId},
                {"name", Name}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("specnameid", SpecNameId);
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 200);

        }
    }
}
