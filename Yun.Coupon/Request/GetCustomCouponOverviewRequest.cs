using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Coupon.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Coupon.Request
{
    /// <summary>
    /// 获取自定义电子券的概况
    /// chenggou.coupon.custom.overview.get
    /// </summary>
    public class GetCustomCouponOverviewRequest:ITopRequest<GetCustomCouponOverviewResponse>
    {

        public int ItemId { get; set; }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemid", ItemId);
        }

        public string GetApiName()
        {
            return "chenggou.coupon.custom.overview.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemid", ItemId}
            };
            return parameters;
        }
    }
}
