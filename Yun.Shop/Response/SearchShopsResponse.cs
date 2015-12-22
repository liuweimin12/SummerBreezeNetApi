using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Shop.Response
{
    public class SearchShopsResponse : YunResponse, IPageResponse
    {
        /// <summary>
        /// 店铺信息
        /// </summary>
        [XmlArray("shops")]
        [XmlArrayItem("shop")]
        public List<ShopDetail> Shops { get; set; }


        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}