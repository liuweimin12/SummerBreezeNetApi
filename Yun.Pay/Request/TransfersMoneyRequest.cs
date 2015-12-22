using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 用户转账
    /// chenggou.pay.transfers
    /// </summary>
    public class TransfersMoneyRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 需要转账的金额
        /// </summary>
        public double Money { get; set; }

        /// <summary>
        /// 目标用户名
        /// </summary>
        public string TargetNick { get; set; }


        /// <summary>
        /// 目标用户ID
        /// </summary>
        public int TargetUserId { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        /// <summary>
        /// IP地址
        /// </summary>
        public string Ip { get; set; }


        /// <summary>
        /// 支付密码
        /// </summary>
        public string PayPassword { get; set; }



        public string GetApiName()
        {
            return "chenggou.pay.transfers";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"money", Money},
                {"targetnick", TargetNick},
                {"targetuserid", TargetUserId},
                {"remark", Remark},
                {"ip", Ip},
                {"paypassword", PayPassword}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
