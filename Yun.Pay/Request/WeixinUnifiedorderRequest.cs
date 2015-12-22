using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Util;

namespace Yun.Pay.Request
{    
    /// <summary>
    /// 生成微信预付款订单
    /// chenggou.pay.weixin.unifiedorder
    /// </summary>
    public class WeixinUnifiedorderRequest : ITopRequest<WeixinUnifiedorderResponse>
    {
        /// <summary>
        /// 支付流ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 终端IP
        /// </summary>
        public string SpbillCreateIp { get; set; }


        /// <summary>
        /// 交易类型
        /// </summary>
        public string TradeType { get; set; }

        /// <summary>
        /// 用户标记
        /// </summary>
        public string Openid { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        public string TradeNum { get; set; }


        public string GetApiName()
        {
            return "chenggou.pay.weixin.unifiedorder";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"deviceinfo",DeviceInfo},
                {"spbillcreateip",SpbillCreateIp},
                {"tradetype",TradeType},
                {"openid",Openid},
                {"companyid",CompanyId},
                {"tradenum",TradeNum }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("tradetype", TradeType);
        }
    }
}
