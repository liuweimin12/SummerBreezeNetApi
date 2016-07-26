using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    [XmlRoot("get_favorites_item_response")]
    public class GetFavoritesItemResponse: YunResponse
    {
        /// <summary>
        /// 商品收藏夹列表
        /// </summary>
        [XmlArray("commodity_favorites")]
        [XmlArrayItem("commodity_favorite__list")]
        public List<CommodityFavorites> CommodityFavorites { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
