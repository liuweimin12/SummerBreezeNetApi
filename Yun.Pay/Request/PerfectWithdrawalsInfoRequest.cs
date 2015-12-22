using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 新增用户提现信息
    /// chenggou.pay.withdrawalsinfo.add
    /// </summary>
    public class PerfectWithdrawalsInfoRequest : ITopRequest<BoolResultResponse>
    {
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


        public string GetApiName()
        {
            return "chenggou.pay.withdrawalsinfo.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"realname",RealName},
                {"idcard",IdCard},
                {"bankname",BankName},
                {"banknum",BankNum},
                {"location",Location},
                {"phone",Phone}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("realname", RealName);
            RequestValidator.ValidateRequired("bankname", BankName);
        }
    }
}
