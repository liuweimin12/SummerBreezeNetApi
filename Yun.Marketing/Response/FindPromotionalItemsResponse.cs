using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    /// <summary>
    /// 查找促销商品
    /// </summary>
    [XmlRoot("find_promotional_items_response")]
    public class FindPromotionalItemsResponse : YunResponse, IPageResponse
    {
        [XmlArray("promotional_items")]
        [XmlArrayItem("promotional_item")]
        public List<PromotionInItem> PromotionalItems { get; set; }

        /// <summary>
        /// 总商品数
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
