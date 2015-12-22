using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 新增公司
    /// chenggou.company.add
    /// </summary>
    public class AddCompanyRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 店名
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 分成比例
        /// </summary>
        public double? PayDeduction { get; set; }


        /// <summary>
        /// 充值卡兑换比例
        /// </summary>
        public double? PrepaidCardProportion { get; set; }



        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户电子邮箱
        /// </summary>
        public string UserEmail { get; set; }


        /// <summary>
        /// 用户手机号
        /// </summary>
        public string UserPhone { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        public string AppSecret { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        public string Ip { get; set; }


        public string GetApiName()
        {
            return "chenggou.company.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name},
                {"paydeduction", PayDeduction},
                {"prepaidcardproportion", PrepaidCardProportion},
                {"username", UserName},
                {"password", string.IsNullOrEmpty(Password) ? null : TopUtils.EncryptAes(Password, AppSecret)},
                {"useremail", UserEmail},
                {"sserphone", UserPhone},
                {"ip", Ip}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMinValue("prepaidcardproportion", PrepaidCardProportion, 0);
        }
    }
}
