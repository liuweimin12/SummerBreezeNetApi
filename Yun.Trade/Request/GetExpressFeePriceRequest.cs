using System.Collections.Generic;
using Yun.Interface;
using Yun.Trade.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 获取运费
    /// yun.trade.expressfee.price.get
    /// </summary>
    public class GetExpressFeePriceRequest : ITopRequest<GetExpressFeePriceResponse>
    {
        /// <summary>
        /// 购买的商品，只允许是一个店铺的
        /// </summary>
        public ExpressFeePriceArgs BoughtGoods { get; set; }

        /// <summary>
        /// 客户的收货地址，完整的，可以
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 省ID
        /// </summary>
        public int ProvinceId { get; set; }

        /// <summary>
        /// 市ID
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// 区ID
        /// </summary>
        public int AreaId { get; set; }

        /// <summary>
        /// 镇ID
        /// </summary>
        public int TownId { get; set; }

        public string GetApiName()
        {
            return "yun.trade.expressfee.price.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"boughtgoods", BoughtGoods},
                {"address", Address},
                {"provinceid", ProvinceId},
                {"cityid", CityId},
                {"areaid", AreaId},
                {"townid", TownId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("buygoods", BoughtGoods);
            RequestValidator.ValidateRequired("address", Address);
        }
    }
}
