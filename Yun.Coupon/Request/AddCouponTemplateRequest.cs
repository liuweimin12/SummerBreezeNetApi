using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Coupon.Request
{
    public class AddCouponTemplateRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 券发送类型
        /// </summary>
        public int SendType { get; set; }

        /// <summary>
        /// 核销后付款
        /// </summary>
        public bool ConsumePaid { get; set; }


        /// <summary>
        /// 过期后退款
        /// </summary>
        public bool ExpiredRefund { get; set; }


        /// <summary>
        /// 自由退款
        /// </summary>
        public bool FreedomRefund { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }


        /// <summary>
        /// 适用自定义电子券
        /// </summary>
        public bool UseCustomCoupon { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        public string GetApiName()
        {
            return "chenggou.coupon.template.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"sendtype", SendType},
                {"consumepaid", ConsumePaid},
                {"freedomrefund", FreedomRefund},
                {"expiredrefund", ExpiredRefund},
                {"title", Title},
                {"usecustomcoupon", UseCustomCoupon},
                {"shopid", ShopId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("title", Title);
        }
    }
}
