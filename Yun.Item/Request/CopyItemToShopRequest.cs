using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 拷贝商品
    /// </summary>
    public class CopyItemToShopRequest : ITopRequest<IntResultResponse>
    {

        /// <summary>
        /// 库存，如果不传入，则为9999
        /// </summary>
        public int? Stock { get; set; }

        /// <summary>
        /// 需要复制的商品ID
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// 复制到哪家店铺下去
        /// </summary>
        public int ToShopId { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.copyto";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"stock",Stock},
                {"toshopid",ToShopId},
                {"itemid",ItemId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemid", ItemId);
            RequestValidator.ValidateRequired("toshopid", ToShopId);
        }
    }
}
