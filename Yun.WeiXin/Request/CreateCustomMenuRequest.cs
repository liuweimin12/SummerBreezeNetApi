using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 创建微信的自定义菜单
    /// chenggou.weixin.custommenu.create
    /// </summary>
    public class CreateCustomMenuRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 账号ID
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// 菜单的JSON字符串
        /// </summary>
        public string Menu { get; set; }

        public string GetApiName()
        {
            return "chenggou.weixin.custommenu.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"accountid", AccountId},
                {"menu", Menu}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("menu", Menu);
            RequestValidator.ValidateRequired("accountid", AccountId);
            RequestValidator.ValidateMinValue("accountid", AccountId, 1);
        }
    }
}
