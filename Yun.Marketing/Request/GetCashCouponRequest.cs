using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取代金券单条的信息
    /// chenggou.cashcoupon.get
    /// </summary>
    public class GetCashCouponRequest : ITopRequest<GetCashCouponResponse>
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 代金券编号
        /// </summary>
        public string Code { get; set; }


        public string GetApiName()
        {
            return "chenggou.cashcoupon.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"code", Code}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
