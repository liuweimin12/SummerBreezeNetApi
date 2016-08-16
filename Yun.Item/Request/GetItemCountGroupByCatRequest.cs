using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 根据商品关键子获取商品在类目下的商品数量
    /// yun.item.count.groupbycat.get
    /// </summary>
    public class GetItemCountGroupByCatRequest :ITopRequest<GetItemCountGroupByCatResponse>
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }


        public string GetApiName()
        {
            return "yun.item.count.groupbycat.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"goodsname", GoodsName}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("goodsname", GoodsName);
        }
    }
}
