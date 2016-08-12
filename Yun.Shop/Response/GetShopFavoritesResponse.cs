using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Shop.Response
{
    [XmlRoot("get_shop_favorites_response")]
    public class GetShopFavoritesResponse : YunResponse, IPageResponse
    {
        [XmlArray("shop_favorites")]
        [XmlArrayItem("shop_favorite")]
        public List<ShopFavorite> ShopFavorites { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
