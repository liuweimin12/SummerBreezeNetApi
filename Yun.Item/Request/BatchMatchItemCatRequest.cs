using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 批量修改商品所匹配类目
    /// yun.item.cat.batchmatch
    /// </summary>
    public class BatchMatchItemCatRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 商品类目
        /// </summary>
        public int CatId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public string ItemsId { get; set; }

        public string GetApiName()
        {
            return "yun.item.cat.batchmatch";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"catid", CatId},
                {"itemsid", ItemsId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemid", ItemsId);
        }
    }
}