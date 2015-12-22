using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Shop.Response
{
    [XmlRoot("get_shop_categories_response")]
    public class GetShopCategoriesResponse:YunResponse
    {
        [XmlArray("categories")]
        [XmlArrayItem("category")]
        public List<CommonCategory> Categories { get; set; }
    }
}
