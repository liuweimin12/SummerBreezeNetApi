using System.Collections.Generic;
using Yun.Shop.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class GetShopAlumbsRequest : ITopRequest<AlbumsResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 是否只筛选显示的
        /// </summary>
        public bool OnyDisplay { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.alumbs.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid", ShopId},
                {"onydisplay",OnyDisplay}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("shopid", ShopId);
            RequestValidator.ValidateRequired("onydisplay", OnyDisplay);
        }
    }
}
