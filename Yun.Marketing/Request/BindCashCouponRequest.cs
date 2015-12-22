using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 代金券和用户绑定
    /// chenggou.cashcoupon.binduser
    /// </summary>
    public class BindCashCouponRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 代金券ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 代金券编号
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }


        public string GetApiName()
        {
            return "chenggou.cashcoupon.binduser";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"code", Code},
                {"userid", UserId}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
