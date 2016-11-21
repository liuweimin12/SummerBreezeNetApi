using System.Collections.Generic;
using Yun.Interface;
using Yun.Shop.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 获取店铺的财务统计概要数据
    /// yun.shop.financial.summary.get
    /// </summary>
    public class GetShopFinancialSummaryRequest : ITopRequest<GetShopFinancialSummaryResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }


        public string GetApiName()
        {
            return "yun.shop.financial.summary.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid", ShopId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("shopid", ShopId);
        }
    }
}
