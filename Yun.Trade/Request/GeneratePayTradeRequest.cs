using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class GeneratePayTradeRequest : ITopRequest<StringResultResponse>
    {
        /// <summary>
        /// 银行代码
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public double OverMoney { get; set; }

        /// <summary>
        /// 在线金额
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
        /// 支付渠道，主要用作区分是否是信用卡支付功能
        /// </summary>
        public string PayChannel { get; set; }

        /// <summary>
        /// 现金
        /// </summary>
        public double Cash { get; set; }

        /// <summary>
        /// 充值卡金额
        /// </summary>
        public double PrepaidCard { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        public string Ext { get; set; }


        public string GetApiName()
        {
            return "chenggou.trade.pay.generate";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"overmoney", OverMoney},
                {"onlinemoney", OnlineMoney},
                {"ip", Ip},
                {"clienttype", ClientType},
                {"paymentins", PaymentIns},
                {"bankcode",BankCode},
                {"cash",Cash},
                {"paychannel",PayChannel},
                {"prepaidcard",PrepaidCard},
                {"ext",Ext}
            };
            return parameters;
        }

        public void Validate()
        {

            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("ip", Ip);
        }
    }
}