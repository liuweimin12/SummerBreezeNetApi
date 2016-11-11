using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 支付宝签名验证
    /// yun.pay.alipay.app.signature.verify
    /// </summary>
    public class VerifyAlipayAppPaySignatureRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 商户网站唯一订单号
        /// </summary>
        public string AlipayOutTradeNo { get; set; }

        /// <summary>
        /// 该交易在支付宝系统中的交易流水号。最长64位。
        /// </summary>
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 支付宝分配给开发者的应用Id。
        /// </summary>
        public string AlipayAppId { get; set; }

        /// <summary>
        /// 该笔订单的资金总额，单位为RMB-Yuan。取值范围为[0.01,100000000.00]，精确到小数点后两位。
        /// </summary>
        public string AlipayTotalAmount { get; set; }

        /// <summary>
        /// 收款支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字
        /// </summary>
        public string AlipaySellerId { get; set; }

        /// <summary>
        /// 处理结果的描述，信息来自于code返回结果的描述
        /// </summary>
        public string AlipayMsg { get; set; }

        /// <summary>
        /// 编码格式
        /// </summary>
        public string AlipayCharset { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public string AlipayTimestamp { get; set; }

        /// <summary>
        /// 结果处理是否成功，成功为T，失败为F
        /// </summary>
        public string AlipayIsSuccess { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        public string AlipayCode { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        public string AlipaySignType { get; set; }


        /// <summary>
        /// 支付宝的签名
        /// </summary>
        public string AlipaySign { get; set; }

        public string AuthAppId { get; set; }

        public string GetApiName()
        {
            return "yun.pay.alipay.app.signature.verify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"alipayouttradeno", AlipayOutTradeNo},
                {"alipaytradeno", AlipayTradeNo},
                {"alipayappid", AlipayAppId},
                {"alipaytotalamount", AlipayTotalAmount},
                {"alipaysellerid", AlipaySellerId},
                {"alipaymsg", AlipayMsg},
                {"alipaycharset", AlipayCharset},
                {"alipaytimestamp", AlipayTimestamp},
                {"alipayissuccess", AlipayIsSuccess},
                {"alipaycode", AlipayCode},
                {"alipaysigntype", AlipaySignType},
                {"alipaysign", AlipaySign},
                {"alipayauthappid", AuthAppId}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("alipayouttradeno", AlipayOutTradeNo);
            RequestValidator.ValidateRequired("alipaytradeno", AlipayTradeNo);
            RequestValidator.ValidateRequired("alipayappid", AlipayAppId);
            RequestValidator.ValidateRequired("alipaytotalamount", AlipayTotalAmount);
            RequestValidator.ValidateRequired("alipaysellerid", AlipaySellerId);
            RequestValidator.ValidateRequired("alipaymsg", AlipayMsg);
            RequestValidator.ValidateRequired("alipaycharset", AlipayCharset);
            RequestValidator.ValidateRequired("alipaytimestamp", AlipayTimestamp);
            RequestValidator.ValidateRequired("alipayissuccess", AlipayIsSuccess);
            RequestValidator.ValidateRequired("alipaycode", AlipayCode);
            RequestValidator.ValidateRequired("alipaysigntype", AlipaySignType);
            RequestValidator.ValidateRequired("alipaysign", AlipaySign);
        }
    }
}
