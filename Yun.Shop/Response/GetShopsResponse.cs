using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Shop.Response
{
     public class GetShopsResponse : YunResponse
    {
         /// <summary>
        /// 店铺信息
         /// </summary>
         [XmlArray("shops")]
         [XmlArrayItem("shop")]
         public List<ShopDetail> Shops { get; set; }
    }
}
