using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class DeliveryTradeRequest : ITopRequest<StringResultResponse>
    {
        ///<summary>
        /// 订单ID
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 快递公司名字
        /// </summary>
        public string ExpressName { get; set; }

        /// <summary>
        /// 快递公司英文名字
        /// </summary>
        public string ExpressEnName { get; set; }

        /// <summary>
        /// 发货备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        public string TrackingNumber { get; set; }


        public string GetApiName()
        {
            return "chenggou.trade.delivery";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"orderid",OrderId},
                {"expressname",ExpressName},
                {"expressenname",ExpressEnName},
                {"remark",Remark},
                {"trackingnumber",TrackingNumber}
               
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("orderid", OrderId);
        }
    }
}
