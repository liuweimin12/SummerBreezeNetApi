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
    /// 添加充值卡
    /// chenggou.prepaidcard.add
    /// </summary>
    public class AddPrepaidCardRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime? ExpiredTime { get; set; }

        /// <summary>
        /// 自定义单张充值卡金额
        /// </summary>
        public double? Money { get; set; }

        /// <summary>
        /// 充值卡类型ID
        /// </summary>
        public int PrepaidCardTypeId { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        /// 充值卡密码
        /// </summary>
        public string CardPassword { get; set; }


        /// <summary>
        /// 需要绑定的店铺ID
        /// </summary>
        public int BindShopId { get; set; }


        /// <summary>
        /// 需要绑定的公司ID
        /// </summary>
        public int BindCompanyId { get; set; }

        /// <summary>
        /// APP密匙
        /// </summary>
        public string AppSecret { get; set; }


        public string GetApiName()
        {
            return "chenggou.prepaidcard.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"prepaidcardtypeid",PrepaidCardTypeId},
                {"cardnumber",CardNumber},
                {"cardpassword",TopUtils.EncryptAes(CardPassword, AppSecret)},
                {"bindshopid",BindShopId},
                {"bindcompanyid",BindCompanyId},
                {"money",Money},
                {"expiredtime",ExpiredTime?.ToString() ?? ""}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("prepaidcardtypeId", PrepaidCardTypeId);
            RequestValidator.ValidateRequired("cardnumber", CardNumber);
            RequestValidator.ValidateRequired("cardpassword", CardPassword);
        }
    }
}
