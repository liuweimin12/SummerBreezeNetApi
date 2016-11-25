using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{

    /// <summary>
    /// 申请提现
    /// chenggou.pay.withdrawals.apply
    /// </summary>
    public class ApplyWithdrawalsRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 提现至哪个地方的ID
        /// </summary>
        public int BankId { get; set; }

        /// <summary>
        /// 提现的金额
        /// </summary>
        public double Money { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        public string IdCard { get; set; }

        /// <summary>
        /// 银行名字
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        public string BankNum { get; set; }


        /// <summary>
        /// 所在区域
        /// </summary>
        public string Location { get; set; }


        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }


        /// <summary>
        /// 支行
        /// </summary>
        public string SubBranch { get; set; }


        /// <summary>
        /// 账号名字
        /// </summary>
        public string AccountName { get; set; }


        public string GetApiName()
        {
            return "chenggou.pay.withdrawals.apply";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"bankid", BankId},
                {"money", Money},
                {"realname", RealName},
                {"accountname", AccountName},
                {"subbranch", SubBranch},
                {"phone", Phone},
                {"money", Money}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("money", Money);
            RequestValidator.ValidateMinValue("money", Money, 0.01);

            if (BankId <= 0)
            {
                RequestValidator.ValidateRequired("bankname", BankName);
                RequestValidator.ValidateRequired("banknum", BankNum);
                RequestValidator.ValidateRequired("phone", Phone);
                RequestValidator.ValidateRequired("accountname", AccountName);
            }
        }
    }
}
