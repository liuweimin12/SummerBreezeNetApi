using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Shop
{
    public class ShopFavorite
    {
        /// <summary>
        /// 收藏ID
        /// </summary>
        [XmlElement("favorite_id")]
        public int FavoriteId { get; set; }



        /// <summary>
        /// 收藏的店铺信息
        /// </summary>
        [XmlElement("shop_info")]
        public ShopDetail ShopInfo { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }


        /// <summary>
        /// 排序
        /// </summary>
        [XmlElement("sort")]
        public int Sort { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
