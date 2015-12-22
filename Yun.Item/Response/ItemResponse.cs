using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    public class ItemResponse : YunResponse
    {
        /// <summary>
        /// 商品详情
        /// </summary>
        [XmlElement("item")]
        public GoodsDetail Item { get; set; }

    }
}
