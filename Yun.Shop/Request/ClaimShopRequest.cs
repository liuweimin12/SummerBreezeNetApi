using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class ClaimShopRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }


        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 身份证照片URL
        /// </summary>
        public string IdcardImg { get; set; }

        /// <summary>
        /// 营业执照URL
        /// </summary>
        public string LicenseImg { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; }


        public string GetApiName()
        {
            return "chenggou.shop.claim";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid", ShopId},
                {"realname",RealName},
                {"mobile",Mobile},
                {"email",Email},
                {"idcardimg",IdcardImg},
                {"licenseimg",LicenseImg},
                {"companyname",CompanyName}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("shopid", ShopId);
            RequestValidator.ValidateRequired("realname", RealName);
            RequestValidator.ValidateMaxLength("realname", this.RealName, 2000);
            RequestValidator.ValidateRequired("mobile", Mobile);
            RequestValidator.ValidateMaxLength("mobile", this.Mobile, 2000);
            RequestValidator.ValidateRequired("email", Email);
            RequestValidator.ValidateMaxLength("email", this.Email, 2000);
            RequestValidator.ValidateRequired("idcardimg", IdcardImg);
            RequestValidator.ValidateMaxLength("idcardimg", this.IdcardImg, 2000);
            RequestValidator.ValidateRequired("licenseimg", LicenseImg);
            RequestValidator.ValidateMaxLength("licenseimg", this.LicenseImg, 2000);
            RequestValidator.ValidateRequired("companyname", CompanyName);
            RequestValidator.ValidateMaxLength("companyname", this.CompanyName, 2000);
        }
    }
}
