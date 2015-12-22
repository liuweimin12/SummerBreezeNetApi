using System.Collections.Generic;
using Yun.Distribution.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Distribution.Request
{
    /// <summary>
    /// 获取上下级分销商用户信息
    /// chenggou.distributors.sibling.get
    /// </summary>
    public class GetMySiblingDistributorsRequest : ITopRequest<GetMySiblingDistributorsResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }


        /// <summary>
        /// 需要等级
        /// </summary>
        public int NeedLevel { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }


        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }


        public string GetApiName()
        {
            return "chenggou.distributors.sibling.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid", ShopId},
                {"needlevel", NeedLevel},
                {"username", UserName},
                {"userid", UserId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("shopid", ShopId);
        }
    }
}
