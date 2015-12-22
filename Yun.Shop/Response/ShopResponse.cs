using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Shop.Response
{
    public class ShopResponse : YunResponse
    {
        /// <summary>
        /// 店铺信息
        /// </summary>
        [XmlElement("shop")]
        public ShopDetail Shop { get; set; }
    }
}
