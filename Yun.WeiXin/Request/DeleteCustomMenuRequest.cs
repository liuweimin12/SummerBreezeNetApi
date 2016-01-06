using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 删除微信的自定义菜单
    /// chenggou.weixin.custommenu.delete
    /// </summary>
    public class DeleteCustomMenuRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 账号ID
        /// </summary>
        public int AccountId { get; set; }


        public string GetApiName()
        {
            return "chenggou.weixin.custommenu.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"accountid", AccountId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("accountid", AccountId);
            RequestValidator.ValidateMinValue("accountid", AccountId, 1);
        }
    }
}
