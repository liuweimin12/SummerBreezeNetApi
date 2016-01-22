using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 新增用户提现信息
    /// chenggou.pay.userbankcard.update
    /// </summary>
    public class ModifyUserBankCardRequest : ITopRequest<BoolResultResponse>
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

        /// <summary>
        /// 提现信息ID
        /// </summary>
        public int Id { get; set; }


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
            return "chenggou.pay.userbankcard.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"realname", RealName},
                {"idcard", IdCard},
                {"bankname", BankName},
                {"banknum", BankNum},
                {"location", Location},
                {"phone", Phone},
                {"subbranch", SubBranch},
                {"accountname", AccountName},
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("bankname", BankName);
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
