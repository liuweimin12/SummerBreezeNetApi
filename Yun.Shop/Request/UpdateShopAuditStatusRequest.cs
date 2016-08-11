using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 更新店铺审核状态
    /// yun.shop.auditstatus.update
    /// </summary>
    public class UpdateShopAuditStatusRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 认证状态，0：未认证；1：已申请；2：已通过；-1:拒绝
        /// </summary>
        public int Status { get; set; }

        public string GetApiName()
        {
            return "yun.shop.auditstatus.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid", ShopId},
                {"status", Status},
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
