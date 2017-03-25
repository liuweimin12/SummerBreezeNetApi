using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取商品对应的优惠券列表
    /// yun.item.cashcoupon.list.get
    /// </summary>
    public class GetItemCashCouponRequest : ITopRequest<GetItemCashCouponResponse>
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// 0:未开始，1：已开始，2：已结束
        /// </summary>
        public int? State { get; set; }

        public string GetApiName()
        {
            return "yun.item.cashcoupon.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemid", ItemId},
                {"state", State}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("itemid", ItemId, 1);
        }
    }
}
