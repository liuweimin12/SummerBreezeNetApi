using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.WeiXin.Response
{
    [XmlRoot("get_custom_menu_response")]
    public class GetCustomMenuResponse : YunResponse
    {
        [XmlArray("menus")]
        [XmlArrayItem("menu")]
        public List<CustomMenuButton> Menus { get; set; }
    }
}
