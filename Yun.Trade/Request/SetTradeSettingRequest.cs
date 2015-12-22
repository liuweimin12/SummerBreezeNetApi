using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 保存自动确认收货的设置
    /// chenggou.trade.setting.set
    /// </summary>
    public class SetTradeSettingRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 自动确认收货的时间，从发货后开始计时
        /// </summary>
        public int ConfirmHours { get; set; }

        /// <summary>
        /// 关闭订单的时间
        /// </summary>
        public int CloseTradeHour { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.setting.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"closetradehour",CloseTradeHour},
                {"confirmhours",ConfirmHours}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("closetradehour", CloseTradeHour);
            RequestValidator.ValidateRequired("confirmhours", ConfirmHours);
        }
    }
}
