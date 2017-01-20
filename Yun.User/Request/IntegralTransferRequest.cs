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

        /// <summary>
        /// 收入方详情说明文字
        /// </summary>
        public string IncomeDetail { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 变更详情，最长限制50个中文，100个英文
        /// </summary>
        public string Detail { get; set; }


        /// <summary>
        /// 积分类型，不能和系统自有字段冲突
        /// </summary>
        public string IntegralType { get; set; }

        /// <summary>
        /// 流水号,保证全局唯一
        /// </summary>
        public string SerialNumber { get; set; }


        public string GetApiName()
        {
            return "yun.user.integral.transfer";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"integral", Integral},
                {"remark", Remark},
                {"detail", Detail},
                {"integraltype",IntegralType },
                {"serialnumber",SerialNumber },
                {"targetuserid",TargetUserId }
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("integraltype", IntegralType);
            RequestValidator.ValidateRequired("detail", Detail);
            RequestValidator.ValidateMaxLength("detail", Detail, 100);
            RequestValidator.ValidateRequired("serialnumber", SerialNumber);
            RequestValidator.ValidateRequired("targetuserid", TargetUserId);
            RequestValidator.ValidateRequired("integral", Integral);
            RequestValidator.ValidateMinValue("integral", Integral, 1);
        }
    }
}
