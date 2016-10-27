using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 用户的积分转让
    /// yun.user.integral.transfer
    /// </summary>
    public class IntegralTransferRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 目标用户ID
        /// </summary>
        public int TargetUserId { get; set; }

        /// <summary>
        /// 积分数量
        /// </summary>
        public int Integral { get; set; }


        public string GetApiName()
        {
            return "yun.user.integral.transfer";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"targetuserid", TargetUserId},
                {"integral", Integral}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("targetuserid", TargetUserId);
            RequestValidator.ValidateRequired("integral", Integral);
            RequestValidator.ValidateMinValue("integral", Integral, 1);
        }
    }
}
