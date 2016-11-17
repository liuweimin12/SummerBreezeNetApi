using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 新增退款的历史记录
    /// yun.refund.remark.add
    /// </summary>
    public class AddRefundRemarkRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 备注留言
        /// </summary>
        public string Remark { get; set; }


        /// <summary>
        /// 凭证照片,多个用英文逗号隔开
        /// </summary>
        public string Images { get; set; }

        /// <summary>
        /// 订单的退款ID
        /// </summary>
        public int OrderRefundId { get; set; }

        public string GetApiName()
        {
            return "yun.refund.remark.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"remark", Remark},
                {"orderrefundid", OrderRefundId},
                {"images", Images}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("orderrefundid", OrderRefundId);
            RequestValidator.ValidateRequired("remark", Remark);
        }
    }
}
