using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取当前程序支持的付款机构
    /// </summary>
    public class GetPaymentInstitutionRequest : ITopRequest<GetPaymentInstitutionResponse>
    {
        /// <summary>
        /// 店铺ID，系统会根据店铺ID自动匹配到公司ID
        /// </summary>
        public int? ShopId { get; set; }

        /// <summary>
        /// 公司ID
        /// 公司ID和店铺如果都不传，则取当前系统开发人员配置的支付信息
        /// </summary>
        public int? CompanyId { get; set; }

        public string PayMethod { get; set; }


        public string GetApiName()
        {
            return "chenggou.onlinepayment.institution.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid", ShopId},
                {"companyid", CompanyId},
                {"paymethod", PayMethod}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
