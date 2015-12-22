using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class UpdateItemSpecValueReuqst : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 规格值ID
        /// </summary>
        public int SpecValueId { get; set; }

        /// <summary>
        /// 规格值
        /// </summary>
        public string Name { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.specvalue.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"specvalueid", SpecValueId},
                {"name", Name}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("specvalueid", SpecValueId);
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 200);
        }
    }
}
