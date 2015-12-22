using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    public  class CategorysResponse : YunResponse
    {
        /// <summary>
        /// 返回具体信息
        /// </summary>
        [XmlArray("categories")]
        [XmlArrayItem("category")]
        public List<ShopItemCategory> Categorys { get; set; }
    }
}
