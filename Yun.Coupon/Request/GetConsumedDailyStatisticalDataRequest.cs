using System;
using System.Collections.Generic;
using Yun.Coupon.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Coupon.Request
{
    public class GetConsumedDailyStatisticalDataRequest : ITopRequest<GetConsumedDailyStatisticalDataResponse>
    {
        /// <summary>
        /// 验证人用户ID
        /// </summary>
        public int VerifierId { get; set; }

        /// <summary>
        /// 验证人用户名
        /// </summary>
        public string VerifierUserName { get; set; }


        /// <summary>
        /// 搜索时间段最小的时间
        /// </summary>
        public DateTime? MinDateTime { get; set; }


        /// <summary>
        /// 搜搜时间段最大的时间
        /// </summary>
        public DateTime? MaxDateTime { get; set; }

        public string GetApiName()
        {
            return "chenggou.coupon.consumed.report";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"verifierid", VerifierId},
                {"verifierusername", VerifierUserName},
                {"mindatetime", MinDateTime},
                {"maxdatetime", MaxDateTime},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("mindatetime", MinDateTime);
            RequestValidator.ValidateRequired("maxdatetime", MaxDateTime);
        }
    }
}