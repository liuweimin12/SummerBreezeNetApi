using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
   public  class ItemCatsResponse: YunResponse
    {
       /// <summary>
        /// 分类列表
       /// </summary>
       [XmlArray("item_cats")]
       [XmlArrayItem("item_cat")]
       public List<ItemCat> ItemCats { get; set; }
    }
}
