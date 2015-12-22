using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.Coupon.Request
{
    /// <summary>
    /// 查询已核销的电子券数量
    /// </summary>
    public class GetConsumeCountRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 码ID
        /// </summary>
        public string CouponId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public string ItemTitle { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        public string ItemCode { get; set; }


        /// <summary>
        /// 订单号
        /// </summary>
        public int TradeId { get; set; }


        /// <summary>
        /// 待查询的核销时间开始
        /// </summary>
        public DateTime? ConsumeTimeStart { get; set; }

        /// <summary>
        /// 待查询的核销时间结束
        /// </summary>
        public DateTime? ConsumeTimeEnd { get; set; }

        /// <summary>
        /// 接收手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 核销状态
        /// </summary>
        public string ConsumeStatus { get; set; }

        /// <summary>
        /// 验证人昵称
        /// </summary>
        public string VerifyNick { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        public string BuyerNick { get; set; }

        public string GetApiName()
        {
            return "chenggou.coupon.consumed.count";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"couponid",CouponId},
                {"itemtitle",ItemTitle},
                {"itemcode",ItemCode},
                {"tradeid",TradeId},
                {"consumetimestart",ConsumeTimeStart},
                {"consumetimeend",ConsumeTimeEnd},
                {"mobile",Mobile},
                {"consumestatus",ConsumeStatus},
                {"verifynick",VerifyNick},
                {"buyernick",BuyerNick}
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
