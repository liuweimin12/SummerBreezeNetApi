using System.Collections.Generic;
using Yun.Interface;
using Yun.Util;
using Yun.WeiXin.Response;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 获取微信的自定义菜单
    /// chenggou.weixin.custommenu.get
    /// </summary>
    public class GetCustomMenuRequest : ITopRequest<GetCustomMenuResponse>
    {
        public string GetApiName()
        {
            return "chenggou.weixin.custommenu.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"accountid", AccountId}
            };
            return parameters;
        }

        /// <summary>
        /// 账号ID
        /// </summary>
        public int AccountId { get; set; }


        public void Validate()
        {
            RequestValidator.ValidateRequired("accountid", AccountId);
            RequestValidator.ValidateMinValue("accountid", AccountId, 1);
        }
    }
}
