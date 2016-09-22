using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.Item.Response
{
    public class ItemResponse : YunResponse
    {
        /// <summary>
        /// 商品详情
        /// </summary>
        [XmlElement("item")]
        public GoodsDetail Item { get; set; }


        /// <summary>
        /// 用户关联属性，在用户登录后可见
        /// </summary>
        [XmlElement("user_association")]
        public UserAssociation UserAssociation { get; set; }
    }
}
