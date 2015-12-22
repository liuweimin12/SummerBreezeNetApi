using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Shop.Response
{
     [XmlRoot("get_shop_category_response")]
    public class GetShopCategoryResponse:YunResponse
    {
         [XmlElement("shop_category")]
         public CommonCategory Category { get; set; }
    }
}
