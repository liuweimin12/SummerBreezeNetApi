using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Shop.Response
{
    [XmlRoot("get_shop_response")]
    public class ShopResponse : YunResponse
    {
        /// <summary>
        /// 店铺信息
        /// </summary>
        [XmlElement("shop")]
        public ShopDetail Shop { get; set; }


        /// <summary>
        /// 用户关联属性，在用户登录后可见
        /// </summary>
        [XmlElement("user_association")]
        public UserAssociation UserAssociation { get; set; }
    }
}
