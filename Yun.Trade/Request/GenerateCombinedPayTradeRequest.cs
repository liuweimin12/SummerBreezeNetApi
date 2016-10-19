using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 生成合并付款的支付单
    /// 返回统一付款的付款单ID
    /// </summary>
    public class GenerateCombinedPayTradeRequest : ITopRequest<IntResultResponse>
    {
        public string GetApiName()
        {
            return "chenggou.combinepay.generate";
        }

        /// <summary>
        /// 银行代码
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 支付单的订单号，多个用英文逗号隔开
        /// </summary>
        public string Ids { get; set; }

        /// <summary>
        /// 需要使用余额支付的金额
        /// </summary>
        public double OverMoney { get; set; }

        /// <summary>
        /// 需要使用在线支付的金额
        /// </summary>
        public double OnlineMoney { get; set; }

        /// <summary>
        /// 付款人IP
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 客户端
        /// </summary>
        public string ClientType { get; set; }

        //支付机构
        public string PaymentIns { get; set; }

        /// <summary>
        /// 需要使用线下现金支付
        /// </summary>
        public double Cash { get; set; }

        /// <summary>
        /// 需要使用充值卡金额
        /// </summary>
        public double PrepaidCard { get; set; }

        /// <summary>
        /// 支付渠道，主要用作区分是否是信用卡支付功能
        /// </summary>
        public string PayChannel { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ids", Ids},
                {"overmoney", OverMoney},
                {"onlinemoney", OnlineMoney},
                {"ip", Ip},
                {"clienttype", ClientType},
                {"paymentins", PaymentIns},
                {"bankcode",BankCode},
                {"cash",Cash},
                {"paychannel",PayChannel},
                {"prepaidcard",PrepaidCard }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ids", Ids);
        }
    }
}
