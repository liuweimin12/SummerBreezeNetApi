using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 创建充值的支付订单
    /// yun.pay.recharge.order.create
    /// </summary>
    public class CreateRechargeOrderRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 需要充值的金额
        /// </summary>
        public double Money { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 充值
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// 充值名称，如果不传，默认“充值”
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        public string PaymentIns { get; set; }

        /// <summary>
        /// 银行代码
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 支付渠道，主要用作区分是否是信用卡支付功能
        /// </summary>
        public string PayChannel { get; set; }

        /// <summary>
        /// 客户端
        /// </summary>
        public string ClientType { get; set; }

        /// <summary>
        /// 扩展内容
        /// </summary>
        public string Ext { get; set; }


        public string GetApiName()
        {
            return "yun.pay.recharge.order.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"money", Money},
                {"ip", Ip},
                {"serialnumber", SerialNumber},
                {"subject", Subject},
                {"paymentins", PaymentIns},
                {"bankcode", BankCode},
                {"paychannel", PayChannel},
                {"clienttype", ClientType},
                {"ext", Ext}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("money", Money, 0.01);
        }
    }
}
