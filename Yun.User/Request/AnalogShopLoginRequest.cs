using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.User.Response;

namespace Yun.User.Request
{
    /// <summary>
    /// 获取店铺管理人员的登录凭证
    /// </summary>
    public class AnalogShopLoginRequest : ITopRequest<LoginResponse>
    {
        /// <summary>
        /// 商户名字
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺ID
        /// 店铺ID和店铺名字二选一，二个都传入的情况下，选择店铺ID
        /// </summary>
        public int ShopId { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.analogshoplogin";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopname",ShopName},
                {"shopid",ShopId}
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
