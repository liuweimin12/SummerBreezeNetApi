﻿using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 更改退款单状态，不能直接改为完成
    /// </summary>
    public class ChangeRefundStatusRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 退款单编号
        /// </summary>
        public long OrderRefundId { get; set; }

        /// <summary>
        /// 备注留言
        /// </summary>
        public string Remark { get; set; }


        /// <summary>
        /// 退款状态
        /// 可选值："WAIT_SELLER_AGREE", "WAIT_BUYER_RETURN_GOODS", "WAIT_SELLER_CONFIRM_GOODS", "SELLER_REFUSE_BUYER", "CLOSED"
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 凭证照片
        /// </summary>
        public string Images { get; set; }

        /// <summary>
        /// 退款件数
        /// </summary>
        public int? RefundQuantity { get; set; }


        public string GetApiName()
        {
            return "chenggou.trade.refund.changeprocedure";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"orderrefundid", OrderRefundId},
                {"remark", Remark},
                {"status", Status},
                {"images", Images},
                {"refundquantity", RefundQuantity}
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
