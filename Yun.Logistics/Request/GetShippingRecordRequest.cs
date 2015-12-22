using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Logistics.Response;
using Yun.Util;

namespace Yun.Logistics.Request
{
    /// <summary>
    /// 获取订单的发货信息
    /// </summary>
    public class GetShippingRecordRequest : ITopRequest<GetShippingResponse>
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public int OrderId { get; set; }

        public string GetApiName()
        {
            return "chenggou.order.shippingrecord.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"orderid",OrderId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("orderid", OrderId);
            RequestValidator.ValidateMinValue("orderid", OrderId, 0);
        }
    }
}
