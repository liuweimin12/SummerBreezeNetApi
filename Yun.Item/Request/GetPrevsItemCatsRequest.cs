using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 获取上级的商品分类链
    /// chenggou.itemcats.prev.get
    /// </summary>
    public class GetPrevsItemCatsRequest : ITopRequest<GetPrevsItemCatsResponse>
    {
        /// <summary>
        /// 商品分类ID
        /// </summary>
        public int ItemCatsId { get; set; }

        public string GetApiName()
        {
            return "chenggou.itemcats.prev.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemcatsid",ItemCatsId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemcatsid", ItemCatsId);
        }
    }
}
