using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    public class CategoryResponse : YunResponse
    {
        /// <summary>
        /// 返回具体信息
        /// </summary>
        [XmlElement("category")]
        public ShopItemCategory Category { get; set; } 
    }
}
