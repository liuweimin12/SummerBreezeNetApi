using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    public class SetOnlinePaymentRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 支付宝设置信息
        /// 合作者身份ID,交易安全检验码,支付宝账号或卖家支付宝帐户,ReturnUrl,NotifyUrl
        /// </summary>
        public string Alipay { get; set; }


        /// <summary>
        /// 财付通设置信息
        /// BargainorId,Key,ReturnUrl,NotifyUrl
        /// </summary>
        public string Tenpay { get; set; }


        /// <summary>
        /// 盛付通设置信息
        /// MsgSender,Key,ReturnUrl,NotifyUrl
        /// </summary>
        public string Shengpay { get; set; }

        /// <summary>
        /// 使用的哪家第三方机构的网银直连
        /// </summary>
        public string BankingDirectConnect { get; set; }

        /// <summary>
        /// 支付哪些付款方式
        /// </summary>
        public string PaymentCode { get; set; }

        /// <summary>
        /// 是否用自己的第三方支付手段
        /// </summary>
        public bool UseSelf { get; set; }

        /// <summary>
        /// 支付方式，可选字段：MOBILE，PC
        /// </summary>
        public string PayMethod { get; set; }

        /// <summary>
        /// 银联支付
        /// MerchantNo,SignCertPath,SignCertPwd
        /// </summary>
        public string UnionPay { get; set; }

        /// <summary>
        /// 中行支付
        /// MerchantNo,SignCertPath,SignCertPwd
        /// </summary>
        public string BocPay { get; set; }


        /// <summary>
        /// 微信支付
        /// </summary>
        public string WeixinPay { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.onlinepayment.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"alipay", Alipay},
                {"tenpay", Tenpay},
                {"shengpay", Shengpay},
                {"bocpay", BocPay},
                {"unionpay", UnionPay},
                {"bankingdirectconnect", BankingDirectConnect},
                {"paymentcode", PaymentCode},
                {"useself", UseSelf},
                {"paymethod", PayMethod},
                {"weixinpay", WeixinPay},
                {"companyid",CompanyId }
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("paymethod", PayMethod);
        }
    }
}
