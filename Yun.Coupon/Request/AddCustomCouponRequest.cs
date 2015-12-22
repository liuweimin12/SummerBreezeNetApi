using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Coupon.Request
{
    /// <summary>
    /// 新增自定义电子券
    /// chenggou.coupon.custom.add
    /// </summary>
    public class AddCustomCouponRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 自定义电子券编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// 电子券密码
        /// </summary>
        public string CouponSecret { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        public string Ext { get; set; }


        public string GetApiName()
        {
            return "chenggou.coupon.custom.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"code", Code},
                {"itemid", ItemId},
                {"couponsecret", CouponSecret},
                {"ext",Ext }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("code", Code);
            RequestValidator.ValidateRequired("itemid", ItemId);
        }
    }
}
