using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Shop.Response
{
    [XmlRoot("get_area_category_response")]
    public class GetAreaCateogryResponse:YunResponse
    {
        [XmlElement("area_category")]
        public CommonCategory Category { get; set; }
    }
}
