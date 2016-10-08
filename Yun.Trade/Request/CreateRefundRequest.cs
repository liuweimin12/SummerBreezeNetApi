using System.Collections.Generic;
using Yun.Interface;
using Yun.Trade.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 创建退款订单
    /// </summary>
    public class CreateRefundRequest : ITopRequest<CreateRefundResponse>
   {
        /// <summary>
        /// 订单ID
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 余额退款的金额
        /// </summary>
        public double Money { get; set; }


        /// <summary>
        /// 退款理由
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 备注留言
        /// </summary>
        public string Remark { get; set; }


        /// <summary>
        /// 凭证照片,多个用英文逗号隔开
        /// </summary>
        public string Images { get; set; }


        /// <summary>
        /// 退款件数
        /// </summary>
        public int? RefundQuantity { get; set; }


        public string GetApiName()
       {
           return "chenggou.trade.refund.create";
       }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"orderid", OrderId},
                {"reason", Reason},
                {"remark", Remark},
                {"refundquantity", RefundQuantity},
                {"images",Images }
            };
            return parameters;
        }

        public void Validate()
       {
           RequestValidator.ValidateMinValue("orderid", OrderId, 1);
       }
   }
}
