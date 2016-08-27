using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 获取按照店铺分组的商品列表
    /// yun.goods.groupingbyshop.list.get
    /// </summary>
    public class GetGroupingShopItemRequest :ITopRequest<GetGroupingShopItemResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public string ShopIds { get; set; }

        /// <summary>
        /// 每店铺里的商品数量
        /// </summary>
        public int PerNumInShop { get; set; }

        /// <summary>
        /// 商品字段
        /// </summary>
        public string GoodsFields { get; set; }

        /// <summary>
        /// 图像尺寸
        /// </summary>
        public int? GoodsImageSize { get; set; }

        /// <summary>
        /// 是否需要促销的信息
        /// </summary>
        public bool NeedPromotion { get; set; }


        /// <summary>
        /// 商品排序
        /// </summary>
        public string GoodsSort { get; set; }


        public string GetApiName()
        {
            return "yun.goods.groupingbyshop.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopids", ShopIds},
                {"pernuminshop", PerNumInShop},
                {"goodsfields",GoodsFields},
                {"goodsimagesize",GoodsImageSize},
                {"needpromotion",NeedPromotion},
                {"goodssort",GoodsSort}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("shopids", ShopIds);
        }
    }
}
