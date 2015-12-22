using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Distribution.Request
{
    /// <summary>
    /// 解除分销用户的绑定
    /// chenggou.distribution.cooperation.remove
    /// </summary>
    public class RemoveCooperationRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 分销账号ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        public string GetApiName()
        {
            return "chenggou.distribution.cooperation.remove";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"userid",UserId},
                {"username",UserName}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
