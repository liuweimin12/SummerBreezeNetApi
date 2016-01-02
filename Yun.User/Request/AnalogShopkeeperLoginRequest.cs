using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;

namespace Yun.User.Request
{
    public class AnalogShopkeeperLoginRequest : ITopRequest<LoginResponse>
    {
        public string GetApiName()
        {
            return "chenggou.user.analogshoplogin";
        }

        /// <summary>
        /// 店铺名字
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺ID
        /// 店铺ID和店铺名字二选一，二个都传入的情况下，选择店铺ID
        /// </summary>
        public int ShopId { get; set; }


        public IDictionary<string, string> GetParameters()
        {
            var parameters = new TopDictionary
            {
                {"shopname", ShopName},
                {"shopid", ShopId}
            };
            return parameters;
        }

        public void Validate()
        {
        }

    }
}
