using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 更新店铺状态
    /// yun.shop.status.update
    /// </summary>
    public class UpdateShopStatusRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 是否系统级别的开启
        /// </summary>
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// 店铺状态/开店，闭店
        /// </summary>
        public bool? IsOpen { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool? IsDisplay { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        public string GetApiName()
        {
            return "yun.shop.status.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid", ShopId},
                {"isenabled",IsEnabled},
                {"isopen",IsOpen},
                {"isdisplay",IsDisplay},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("shopid", ShopId);
        }
    }
}
