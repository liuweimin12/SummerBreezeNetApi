using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Trade.Response;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 获取自动确认收货的设置信息
    /// chenggou.trade.setting.get
    /// </summary>
    public class GetTradeSettingRequest : ITopRequest<GetConfirmReceiptSettingResponse>
    {
        public string GetApiName()
        {
            return "chenggou.trade.setting.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
