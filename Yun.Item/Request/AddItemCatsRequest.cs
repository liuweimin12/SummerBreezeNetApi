using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class AddItemCatsRequest : ITopRequest<IntResultResponse>
    {
        public string GetApiName()
        {
            return "chenggou.itemcat.add";
        }

        public string Name { get; set; }

        public int ParentId { get; set; }

        public double Sort { get; set; }

        public bool Display { get; set; }


        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"parentid", ParentId},
                {"name",Name},
                {"sort",Sort},
                {"display",Display}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
        }
    }
}
