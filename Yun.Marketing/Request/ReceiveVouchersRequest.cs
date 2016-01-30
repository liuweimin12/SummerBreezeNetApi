using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 领取代金券
    ///chenggou.cashcoupon.user.receive
    /// </summary>
    public class ReceiveVouchersRequest: ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 代金券类型ID
        /// </summary>
        public int CashCouponCatId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        public string GetApiName()
        {
            return "chenggou.cashcoupon.user.receive";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"cashcouponcatid",CashCouponCatId},
                {"userid",UserId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cashcouponcatid", CashCouponCatId);
            RequestValidator.ValidateMinValue("cashcouponcatid", CashCouponCatId, 1);
            RequestValidator.ValidateRequired("userid", UserId);
            RequestValidator.ValidateMinValue("userid", UserId, 1);
        }
    }
}
