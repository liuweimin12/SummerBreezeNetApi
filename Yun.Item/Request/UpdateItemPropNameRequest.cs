using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class UpdateItemPropNameRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 属性名ID
        /// </summary>
        public int PropNameId { get; set; }

        /// <summary>
        /// 属性名
        /// </summary>
        public string Name { get; set; }


        public int Sort { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.propname.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"propnameid", PropNameId},
                {"name", Name},
                {"sort", Sort}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("propnameid", PropNameId);
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMaxLength("name", Name, 200);
        }
    }
}
