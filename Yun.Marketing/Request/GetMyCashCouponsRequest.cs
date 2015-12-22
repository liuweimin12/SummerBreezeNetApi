using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取我得代金券
    /// chenggou.cashcoupon.my.get
    /// </summary>
    public class GetMyCashCouponsRequest : ITopRequest<GetMyCashCouponsResponse>
    {
        /// <summary>
        /// 订单价格
        /// </summary>
        public double? TradePrice { get; set; }

        /// <summary>
        /// 已经使用
        /// </summary>
        public bool? HasUsed { get; set; }

        /// <summary>
        /// 已经过期
        /// </summary>
        public bool? HasExpired { get; set; }

        /// <summary>
        /// 商品价格JSON格式
        /// </summary>
        public List<GetMyCashCouponItemPriceJson> ItemPriceJson { get; set; }

        public string GetApiName()
        {
            return "chenggou.cashcoupon.my.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"tradeprice", TradePrice},
                {"hasused", HasUsed},
                {"hasexpired", HasExpired},
                {"itempricejson", ItemPriceJson}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
