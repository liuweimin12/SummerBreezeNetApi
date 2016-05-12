using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 获取商品详情
    /// </summary>
    public class GetItemRequest : ITopRequest<ItemResponse>
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 需要的字段
        /// </summary>
        public string Fields { get; set; }


        /// <summary>
        /// 是否需要促销的信息
        /// </summary>
        public bool NeedPromotion { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"fields", Fields},
                {"needpromotion", NeedPromotion}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}