using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 更新商品的审核状态
    /// yun.item.auditstate.update
    /// </summary>
    public class UpdateAuditStateRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 审核状态，1为审核通过，0为审核中，2为拒绝审核
        /// </summary>
        public int AuditState { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public int ItemId { get; set; }

        public string GetApiName()
        {
            return "yun.item.auditstate.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"auditstate",AuditState},
                {"itemid",ItemId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("auditstate", AuditState);
            RequestValidator.ValidateRequired("itemId", ItemId);
        }
    }
}
