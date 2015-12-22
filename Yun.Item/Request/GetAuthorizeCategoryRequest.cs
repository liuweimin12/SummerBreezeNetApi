using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;

namespace Yun.Item.Request
{
    public class GetAuthorizeCategoryRequest : ITopRequest<ItemCatsResponse>
    {
        public string GetApiName()
        {
            return "chenggou.itemcats.authorize.get";
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
