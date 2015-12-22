using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    public class GetItemsResponse : YunResponse, IPageResponse
    {
        /// <summary>
        /// 商品
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("item")]
        public List<GoodsDetail> Items { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
