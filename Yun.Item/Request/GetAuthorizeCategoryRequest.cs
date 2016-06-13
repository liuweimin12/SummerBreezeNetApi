using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;

namespace Yun.Item.Request
{
    /// <summary>
    /// 获取当前用户所属店铺的全局类目信息
    /// </summary>
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
